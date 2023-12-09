#!/usr/bin/env python3

"""
Extract media files from PowerPoint file (.pptx)
"""

import os
import re
import sys
from pathlib import Path
from typing import Final
from zipfile import ZipFile

from PySide6 import QtCore, QtGui, QtWidgets

TITLE: Final[str] = "PowerPoint Media Extractor"
VERSION: Final[tuple[int, int, int]] = (1, 0, 0)


class Main(QtWidgets.QMainWindow):
    def __init__(self):
        """
        Set up the main window.
        """

        super().__init__()
        self.setWindowTitle(TITLE)

        container = QtWidgets.QWidget()
        main_layout = QtWidgets.QVBoxLayout(container)

        title = QtWidgets.QLabel(TITLE)
        title.setAlignment(QtCore.Qt.AlignmentFlag.AlignHCenter)
        title.setFont(QtGui.QFont("Arial", 20))

        in_form_layout = QtWidgets.QHBoxLayout()
        in_filepath_lbl = QtWidgets.QLabel("Filepath: ", self)
        self.in_filepath_txt = QtWidgets.QLineEdit(self)
        in_filepath_btn = QtWidgets.QPushButton("Browse", self)
        in_filepath_btn.clicked.connect(self.get_input_filepath)

        in_form_layout.addWidget(in_filepath_lbl)
        in_form_layout.addWidget(self.in_filepath_txt)
        in_form_layout.addWidget(in_filepath_btn)

        out_form_layout = QtWidgets.QHBoxLayout()
        out_filepath_lbl = QtWidgets.QLabel("Output: ", self)
        self.out_filepath_txt = QtWidgets.QLineEdit(self)
        self.out_filepath_txt.setReadOnly(True)
        out_filepath_btn = QtWidgets.QPushButton("Browse", self)
        out_filepath_btn.clicked.connect(self.get_output_directory)

        out_form_layout.addWidget(out_filepath_lbl)
        out_form_layout.addWidget(self.out_filepath_txt)
        out_form_layout.addWidget(out_filepath_btn)

        extract_btn = QtWidgets.QPushButton("Extract", self)
        extract_btn.clicked.connect(self.start)

        main_layout.addWidget(title)
        main_layout.addLayout(in_form_layout)
        main_layout.addLayout(out_form_layout)
        main_layout.addWidget(extract_btn)

        container.setLayout(main_layout)
        self.setCentralWidget(container)

    def get_input_filepath(self) -> None:
        """
        Get the PowerPoint file to extract media from.
        """

        self.in_filepath_txt.setText(
            str(
                Path(
                    QtWidgets.QFileDialog.getOpenFileName(
                        self, "Open File", "", "PowerPoint (*.pptx)"
                    )[0]
                )
            )
        )

        if self.out_filepath_txt.text() == "":
            self.out_filepath_txt.setText(
                str(
                    Path(os.path.dirname(self.in_filepath_txt.text())).joinpath(
                        Path(
                            os.path.splitext(
                                os.path.basename(self.in_filepath_txt.text())
                            )[0],
                        )
                    )
                )
            )

    def get_output_directory(self) -> None:
        """
        Get the directory to extract the media files to.
        """

        dir_path = QtWidgets.QFileDialog.getExistingDirectory(self, "Select Directory")
        if len(dir_path) != 0:
            self.out_filepath_txt.setText(str(Path(dir_path).absolute()))

    def increment_filename(self, filename: str) -> str:
        """
        Increment the filename if it already exists.
        """

        filename, ext = os.path.splitext(filename)

        if re.search(r"\([0-9]+\)$", filename):
            new_filename = re.sub(
                r"\(([0-9]+)\)$",
                lambda matched: f"({int(matched.group(1)) + 1})",
                filename,
            )

        else:
            new_filename = f"{filename} (1)"

        new_filename += ext
        return new_filename

    def start(self) -> None:
        """
        Start the extraction process.
        """

        files_extracted: int = 0
        try:
            in_filepath = self.in_filepath_txt.text()
            out_filepath = self.out_filepath_txt.text()

            if os.path.exists(out_filepath):
                if len(os.listdir(out_filepath)) != 0:
                    overwrite_msg = QtWidgets.QMessageBox()
                    overwrite_msg.setWindowTitle("Warning")
                    overwrite_msg.setText(
                        "The output directory is not empty. "
                        "Do you want to continue the extraction?"
                    )
                    overwrite_msg.setStandardButtons(
                        QtWidgets.QMessageBox.StandardButton.Yes
                        | QtWidgets.QMessageBox.StandardButton.No
                    )
                    overwrite_msg.setDefaultButton(
                        QtWidgets.QMessageBox.StandardButton.No
                    )
                    if overwrite_msg.exec() == QtWidgets.QMessageBox.StandardButton.No:
                        return

            os.makedirs(out_filepath, exist_ok=True)
            with ZipFile(in_filepath, "r") as zip:
                for filename in zip.namelist():
                    # Extract only media files.
                    if filename.startswith("ppt/media"):
                        media_filename: str = os.path.join(
                            out_filepath, os.path.basename(filename)
                        )
                        while os.path.exists(media_filename):
                            # well, this shouldn't run because we check
                            # if the directory exists before creating it,
                            # but just in case...
                            media_filename = self.increment_filename(media_filename)

                        with open(media_filename, "wb") as out_file:
                            out_file.write(zip.read(filename))
                            files_extracted += 1

            msg = QtWidgets.QMessageBox()
            msg.setWindowTitle("Success")
            msg.setText(f"Extracted {files_extracted} files.")
            msg.exec()

        except Exception as e:
            err_msg = QtWidgets.QMessageBox()
            err_msg.setWindowTitle("Error")
            err_msg.setText(str(e))
            err_msg.exec()


if __name__ == "__main__":
    app = QtWidgets.QApplication(sys.argv)
    main_window = Main()
    main_window.show()

    sys.exit(app.exec())
