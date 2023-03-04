import sys

from PySide6 import QtCore
from PySide6 import QtWidgets


class MainProgram(QtWidgets.QMainWindow):
    def __init__(self):
        super().__init__()

        self.setWindowTitle("Button Actions")
        self.setMinimumSize(QtCore.QSize(350, 200))

        self.button = QtWidgets.QPushButton("Click Me!")  # Create a button.
        self.button.clicked.connect(self.button_clicked)  # Connect the button to a method.

        self.setCentralWidget(self.button)

    def button_clicked(self):
        """
        This method changes the text in the button when it is clicked.
        """

        if self.button.text() == "Click Me!":
            self.button.setText("I have been clicked!")

        else:
            self.button.setText("Click Me!")


def main() -> int:
    app = QtWidgets.QApplication(sys.argv)  # Create the object that handles the event loop.

    window = MainProgram()
    window.show()  # Show the window.
    return app.exec()  # Start the event loop.


if __name__ == "__main__":
    sys.exit(main())
