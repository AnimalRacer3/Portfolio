import os
import json
from pathlib import Path

def main():
    organize_junk()
    return 0

def organize_junk():
    with open('Jsons/directories.json', 'r') as f:
        DIRECTORIES = json.load(f)

    FILE_FORMATS = {file_format: directory
                    for directory, file_formats in DIRECTORIES.items()
                    for file_format in file_formats}
    
    for entry in os.scandir():
        if entry.is_dir():
            continue
        file_path = Path(entry)
        file_format = file_path.suffix.lower()
        if file_format in FILE_FORMATS:
            directory_path = Path(FILE_FORMATS[file_format])
            directory_path.mkdir(exist_ok=True)
            file_path.rename(directory_path.joinpath(file_path))

        for dir in os.scandir():
            try:
                os.rmdir(dir)
            except:
                pass

if __name__ == "__main__":
    main()