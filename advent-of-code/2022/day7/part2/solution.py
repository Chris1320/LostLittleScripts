import os
import sys
import shlex

from typing import Final
from typing import Optional


class FileSystem:
    def __init__(self):
        self.filenames: list[str] = ["/"]  # Contains full filepaths.
        self.parents: list[int] = [0]  # Contains the parents of each filepath in self.__filenames
        self.children: list[list[int]] = [[]]  # Contains a list of lists that contain indexes of children.
        self.is_dir: list[bool] = [True]  # True = folder; False = file
        self.filesizes: list[float] = [0.0]  # The size of the files.
        self._cwd = 0  # The index of the filename of the current working directory.

    def _getAbsolutePath(self, filepath: str) -> str:
        return filepath if filepath.startswith('/') else os.path.join(self.cwd, filepath)

    def _createPathEntry(self, full_path: str, is_dir: bool, filesize: Optional[float] = None) -> None:
        if not full_path.startswith('/'):
            full_path = os.path.join(self.cwd, full_path)

        if full_path in self.filenames:
            return

        self.filenames.append(full_path)
        self.parents.append(self._cwd)
        self.children.append([])
        self.is_dir.append(is_dir)
        self.filesizes.append(filesize if type(filesize) is float else 0.0)
        self.children[self._cwd].append(len(self.filenames) - 1)

    def getAllFilepaths(self) -> list[tuple[str, bool, float, int, list[int]]]:
        return [
            (
                self.filenames[i],
                self.is_dir[i],
                self.filesizes[i]
                    if not self.is_dir[i]
                    else self.getTotalSize(self.filenames[i]),
                self.parents[i],
                self.children[i],
            )
            for i in range(0, len(self.filenames))
        ]

    def makeDir(self, filepath: str) -> None:
        self._createPathEntry(filepath, True)

    def makeFile(self, filepath: str, filesize: float) -> None:
        self._createPathEntry(filepath, False, float(filesize))

    def changeDir(self, cd_filepath: str = "/"):
        # FIXME: does NOT support more than one `..` yet
        self._cwd = self.parents[self._cwd] \
            if cd_filepath == ".." \
            else self.filenames.index(self._getAbsolutePath(cd_filepath))

    @property
    def cwd(self) -> str:
        return self.filenames[self._cwd]

    def getParent(self, filepath: Optional[str] = None) -> str:
        filepath = self.cwd if filepath is None else filepath
        return self.filenames[self.parents[self.filenames.index(self._getAbsolutePath(filepath))]]

    def getChildren(self, filepath: Optional[str] = None) -> list[str]:
        filepath = self.cwd if filepath is None else filepath
        return [
            self.filenames[idx]
            for idx in self.children[self.filenames.index(self._getAbsolutePath(filepath))]
        ]

    def getTotalSize(self, filepath: str):
        filepath = self._getAbsolutePath(filepath)
        if self.is_dir[self.filenames.index(filepath)]:
            return sum(
                self.filesizes[self.filenames.index(child)]  # Get the size of the file
                if not self.is_dir[self.filenames.index(child)]  # If it is a file,
                else self.getTotalSize(child)                # Otherwise, get the directory contents
                for child in self.getChildren(filepath)
            )

        else:
            return self.filesizes[self.filenames.index(filepath)]


def main() -> int:
    TOTAL_DISK_SPACE: Final[float] = 70000000.0
    REQUIRED_SPACE: Final[float] = 30000000.0

    with open(os.path.join("..", "terminal_output.txt"), 'r') as f:
        terminal_output = f.read().split('\n')

    filesystem = FileSystem()
    for line in terminal_output:
        if len(line) < 1:  # Skip empty lines
            continue

        if line.startswith("$ "):  # Check if it is a command.
            print(f"({filesystem.cwd}) {line}")
            command = shlex.split(line.partition("$ ")[2])
            if command[0] == "cd":
                filesystem.changeDir(command[1])

            continue

        # If it is not a command, assume that it is an `ls` output.
        if line.startswith("dir"):
            dir_info = line.partition(' ')[2]
            filesystem.makeDir(dir_info)
            print(f"Created directory `{dir_info}`")

        else:
            file_info = line.partition(' ')
            filesystem.makeFile(file_info[2], float(file_info[0]))
            print(f"Created file `{file_info[2]}` with size {file_info[0]}")

    free_space = TOTAL_DISK_SPACE - filesystem.getTotalSize('/')
    need_to_free_space = REQUIRED_SPACE - free_space
    possible_candidates: list[float] = []
    for filepath in filesystem.getAllFilepaths():
        description = ""
        for info in filepath:
            description += f"{info}, "

        print(description)

        # second index is True if it is a directory
        # third index contains the directory/file size in float data type.
        if filepath[2] >= need_to_free_space and filepath[1]:
            print(f"Possible Candidate: {filepath[0]} with size {filepath[2]}")
            possible_candidates.append(filepath[2])

    print(possible_candidates)
    print(f"\nResult: {min(possible_candidates)}")

    return 0


if __name__ == "__main__":
    sys.exit(main())
