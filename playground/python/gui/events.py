import sys

from PySide6 import QtGui
from PySide6 import QtCore
from PySide6 import QtWidgets


class MainProgram(QtWidgets.QMainWindow):
    def __init__(self):
        super().__init__()

        container = QtWidgets.QWidget()
        layout = QtWidgets.QVBoxLayout()

        self.label = QtWidgets.QLabel("No mouse event yet.")
        self.label.setAlignment(QtCore.Qt.AlignmentFlag.AlignCenter)
        self.note = QtWidgets.QLabel("Move the mouse over the window to see the mouse position.")
        self.note.setAlignment(QtCore.Qt.AlignmentFlag.AlignCenter)

        layout.addWidget(self.label)
        layout.addWidget(self.note)
        container.setLayout(layout)

        self.setCentralWidget(container)
        self.setMouseTracking(True)
        self.setMinimumSize(500, 500)

    def mouseMoveEvent(self, event: QtGui.QMouseEvent) -> None:
        super().mouseMoveEvent(event)
        self.note.setVisible(False)
        self.label.setText(f"Mouse move event on {event.position().x()}, {event.position().y()}")

    def mousePressEvent(self, event: QtGui.QMouseEvent) -> None:
        super().mousePressEvent(event)
        self.note.setVisible(False)
        self.label.setText(f"Mouse press event on {event.position().x()}, {event.position().y()}")

    def mouseDoubleClickEvent(self, event: QtGui.QMouseEvent) -> None:
        super().mouseDoubleClickEvent(event)
        self.note.setVisible(False)
        self.label.setText(f"Mouse double click event on {event.position().x()}, {event.position().y()}")

    def mouseReleaseEvent(self, event: QtGui.QMouseEvent) -> None:
        super().mouseReleaseEvent(event)
        self.note.setVisible(False)
        self.label.setText(f"Mouse release event on {event.position().x()}, {event.position().y()}")


def main() -> int:
    app = QtWidgets.QApplication(sys.argv)

    window = MainProgram()
    window.show()

    return app.exec()


if __name__ == "__main__":
    sys.exit(main())
