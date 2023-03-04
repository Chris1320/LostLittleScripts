import sys

from PySide6 import QtCore
from PySide6 import QtWidgets


class MainProgram(QtWidgets.QMainWindow):
    # A class that represents the main window of the program.

    def __init__(self):
        super().__init__()  # Call the superclass's constructor.

        self.setWindowTitle("First Python GUI Program")  # Set the window title.

        label = QtWidgets.QLabel("Hello, World!")  # Create a label that contains "Hello, World!".
        label.setAlignment(QtCore.Qt.AlignmentFlag.AlignCenter)  # Align the text to the center.

        self.setCentralWidget(label)  # Set the central widget of the window.


def main() -> int:
    app = QtWidgets.QApplication(sys.argv)  # Create the object that handles the event loop.

    window = MainProgram()
    window.show()  # Show the window.
    return app.exec()  # Start the event loop.


if __name__ == "__main__":
    sys.exit(main())
