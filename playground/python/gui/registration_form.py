import sys

from PySide6 import QtGui
from PySide6 import QtCore
from PySide6 import QtWidgets


class MainProgram(QtWidgets.QMainWindow):
    def __init__(self):
        super().__init__()

        self.TITLE = "Registration Form"

        # Initialize main container and main layout
        container = QtWidgets.QWidget()
        main_layout = QtWidgets.QVBoxLayout(container)

        # Set widgets in the main layout.
        title = QtWidgets.QLabel(self.TITLE)
        title.setFont(QtGui.QFont("Arial", 20))
        title.setAlignment(QtCore.Qt.AlignmentFlag.AlignTop)
        title.setAlignment(QtCore.Qt.AlignmentFlag.AlignHCenter)

        form_layout = QtWidgets.QGridLayout()

        label_name = QtWidgets.QLabel("Name: ")
        self.txt_name = QtWidgets.QLineEdit()
        label_age = QtWidgets.QLabel("Age: ")
        self.txt_age = QtWidgets.QLineEdit()
        label_address = QtWidgets.QLabel("Address: ")
        self.txt_address = QtWidgets.QLineEdit()
        label_course = QtWidgets.QLabel("Course: ")

        radio_button_course_layout = QtWidgets.QHBoxLayout()
        self.selected_course = QtWidgets.QButtonGroup()
        radio_button_course_1 = QtWidgets.QRadioButton("BSIT")
        radio_button_course_2 = QtWidgets.QRadioButton("BSCS")
        # Add radio buttons to the layout
        radio_button_course_layout.addWidget(radio_button_course_1)
        radio_button_course_layout.addWidget(radio_button_course_2)
        # Add radio buttons to the button group
        self.selected_course.addButton(radio_button_course_1)
        self.selected_course.addButton(radio_button_course_2)

        # Add the widgets to the form layout
        form_layout.addWidget(label_name, 0, 0)
        form_layout.addWidget(self.txt_name, 0, 1)
        form_layout.addWidget(label_age, 1, 0)
        form_layout.addWidget(self.txt_age, 1, 1)
        form_layout.addWidget(label_address, 2, 0)
        form_layout.addWidget(self.txt_address, 2, 1)
        form_layout.addWidget(label_course, 3, 0)
        form_layout.addLayout(radio_button_course_layout, 3, 1)

        submit_button = QtWidgets.QPushButton("Submit")
        submit_button.clicked.connect(self.submit)  # Connect `self.submit()` method to the submit button.

        # Add the widgets and layouts to the main layout
        main_layout.addWidget(title)
        main_layout.addLayout(form_layout)
        main_layout.addWidget(submit_button, alignment=QtCore.Qt.AlignmentFlag.AlignRight)

        container.setLayout(main_layout)  # Add main layout to main container

        # Set widget to show in the window
        self.setWindowTitle(self.TITLE)
        self.setCentralWidget(container)

    def submit(self):
        # Check for valid name
        if self.txt_name.text() == "":
            QtWidgets.QMessageBox.warning(self, self.TITLE, "Please fill up the form.")
            return

        # Check for valid age
        try:
            if int(self.txt_age.text()) < 18:
                QtWidgets.QMessageBox.warning(self, self.TITLE, "You must be 18 years old or above.")
                return

        except ValueError:
            QtWidgets.QMessageBox.warning(self, self.TITLE, "Please input a valid age.")
            return

        # Check for valid address
        if self.txt_address.text() == "":
            QtWidgets.QMessageBox.warning(self, self.TITLE, "Please fill up the form.")
            return

        # Check for valid course
        elif self.selected_course.checkedButton() is None:
            QtWidgets.QMessageBox.warning(self, self.TITLE, "Please select a course.")
            return

        # Show success message and quit the application
        QtWidgets.QMessageBox.information(
            self,
            self.TITLE,
            f"{self.txt_name.text()}, your registration to the {self.selected_course.checkedButton().text()} program is successful!"
        )
        QtWidgets.QApplication.exit(0)  # Exit the application


def main() -> int:
    app = QtWidgets.QApplication(sys.argv)

    window = MainProgram()
    window.show()

    return app.exec()


if __name__ == "__main__":
    sys.exit(main())
