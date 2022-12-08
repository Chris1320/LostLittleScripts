"""
NOTE: The intended use of this script is to rename VLC-formatted subtitle files
      into Jellyfin-compatible naming system.

EXAMPLE:
      `2_Arabic.srt` -> `<tv_show name> S<s>E<e>.ara.srt`

WARNING: MAKE SURE TO BACK UP YOUR FILES FIRST!
        This script overwrites subtitles with the same filename.

REQUIREMENTS:

    - Python 3.10+ (Might work on 3.6+ with some modifications)
    - pycountry (https://pypi.org/project/pycountry/)

HOW TO USE (TV Shows):

1. Install the requirements.
2. Open a terminal and `cd` to the folder of the TV show.

    `$ cd "F:/HomeTheater/TV Shows/Sample TV Show (2022)/"`

3. Make sure that your files follow this file hierarchy:

- Sample TV Show (2022)/
    - Sample TV Show (2022) S1E1
        - Sample TV Show (2022) S1E1.mkv
        - 3_English.srt
        - 19_Japanese.srt
        - 21_Korean.srt
        - 29_Spanish.srt
    - Sample TV Show (2022) S1E2
        - Sample TV Show (2022) S1E2.mp4
        - Sample TV Show (2022) S1E1.nfo
        - 3_English.srt
        - 19_Japanese.srt
        - 21_Korean.srt
        - 29_Spanish.srt
    - Sample TV Show (2022) S1E3
        - Sample TV Show (2022) S1E3.mkv
        - 3_English.srt
        - 19_Japanese.srt
        - 21_Korean.srt
        - 29_Spanish.srt

4. Run the script.

    `$ python3 srt_renamer.py -s "Sample TV Show (2022)"`

"""

import os
import sys

import pycountry


class Country:
    def __init__(self, filename: str):
        """
        The initialization method of the Country() class.
        """
        
        self.language_name_alternatives = {
            "Greek": "Ancient Greek (to 1453)"
        }

        self.filename = filename
        self.extension = self.filename[::-1].partition('.')[0][::-1]
        self.country_code = self.getCountryName(filename)

    def getCountryName(self, filename: str) -> str:
        """
        Get country name using filename.

        :param str filename:

        :returns str: the country name
        """

        language_name = (filename.partition('_')[2].partition('.')[0])
        if language_name in self.language_name_alternatives:
            language_name = self.language_name_alternatives[language_name]

        try:
            return pycountry.languages.get(name=language_name).alpha_3

        except AttributeError:  # Try if name is already alpha_3
            try:
                return pycountry.languages.get(alpha_3=language_name).alpha_3

            except AttributeError:  # Try to get country's alpha_3 code and then check if its language is in `pycountry.languages`.
                try:
                    return pycountry.languages.get(alpha_3=pycountry.countries.get(name=language_name).alpha_3)

                except AttributeError:  # Just return the current value.
                    return filename.partition('_')[2].partition('.')[0]

    def buildNewFilename(self, name: str) -> str:
        """
        Generate a new filename using `self.country_code`.

        :param str name: Name of the subtitle file.

        :returns str: The new filename.
        """

        return f"{name}.{self.country_code}.{self.extension}"


def seasonEpisodeChecker(filename: str) -> int:
    """
    Gets season and episode numbers.

    :param str filename: Filename to get season and episode from.

    :returns int, int: Season, Episode
    """

    separator = ' '  # The old version of the script used to be '.', maybe if the file has not yet been renamed? (e.g., "A.Sample.Show.mp4")
    season = None
    episode = None

    for word in filename.split(separator):
        if 'S' in word.upper() and season is None:  # Get season.
            try:
                # print(word.upper().partition('S')[2].partition('E')[0])
                season = int(word.upper().partition('S')[2].partition('E')[0])

            except ValueError:
                pass

        if 'E' in word.upper() and episode is None:  # Get episode.
            try:
                # print(word.upper().partition('E')[2])
                episode = int(word.upper().partition('E')[2])

            except ValueError:
                pass

    # Check if season and episode is not None.
    if season is None or episode is None:
        raise ValueError("Insufficient data to get season and/or episode!")

    return season, episode


def main(media_type: str, fnb_title: str) -> int:
    subtitle_extensions = (".srt", ".vtt", ".ass")
    if media_type.lower() == "-d":
        for file in os.listdir(os.getcwd()):
            if file.lower().endswith(subtitle_extensions):
                c_obj = Country(file)
                new_filepath = os.path.join(os.getcwd(), c_obj.buildNewFilename(f"{fnb_title}"))
                if os.path.join(os.getcwd(), file) == new_filepath:
                    print(f"Skipping rename of {new_filepath}...")
                    continue

                if os.path.exists(new_filepath):
                    os.remove(new_filepath)  # Replace with new file.
                    print("\nReplacing existing file...")

                os.rename(os.path.join(os.getcwd(), file), new_filepath)
                print("Renamed {0} to {1}.".format(os.path.join(os.getcwd(), file), new_filepath))

        return 0

    elif media_type.lower() == "-s":
        print("Scanning subdirectories...\n")
        print()
        for episode_folders in os.listdir():
            for root, subdirs, files in os.walk(os.path.join(os.getcwd(), episode_folders)):
                print(f"[i] Scanning `{root}`.")
                for f in files:
                    full_filepath = os.path.join(root, f)
                    parent_folder = root[::-1].partition(os.sep)[0][::-1]
                    if f.lower().endswith(subtitle_extensions):
                        c_obj = Country(f)
                        fnb_season, fnb_episode = seasonEpisodeChecker(parent_folder)
                        new_filepath = os.path.join(root, c_obj.buildNewFilename(f"{fnb_title} S{fnb_season}E{fnb_episode}"))
                        if full_filepath == new_filepath:
                            print(f"Skipping rename of {full_filepath}...")
                            continue

                        if os.path.exists(new_filepath):
                            os.remove(new_filepath)  # Replace with new file.
                            print("\nReplacing existing file...")

                        os.rename(full_filepath, new_filepath)
                        print("Renamed {0} to {1}".format(full_filepath, new_filepath))

        return 0

    else:
        return 1


if __name__ == "__main__":
    print(f"USAGE: {sys.argv[0]} -d|s [MOVIE/SHOW NAME]")
    print()
    print("-d        Files are on CWD. (Direct)")
    print("-s        Subdirectories (For Shows)")
    print()
    assert type(sys.argv[1]) is str
    assert type(sys.argv[2]) is str
    sys.exit(main(sys.argv[1], sys.argv[2]))
