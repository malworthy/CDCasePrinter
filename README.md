# CD Case Printer

A simple tool for printing the front and rear cover for a CD Jewel Case. Also has support for slimline cases.

This application works offline by reading metadata from audio files. It does not need an internet connection.

Windows only. Written in c# using windows forms, a GUI framework that reached peak popularity at the height of the CD era.

### Installing

Windows installer provided in releases section.

### How to use

1. Purchase music as a digital download from Bandcamp or elsewhere
2. Copy music into a folder
3. Burn said music to a CD
4. Open CD Case printer
5. Press "Select Folder" and browse to the folder where your music is
6. Fields will be pre-populated with artist, album and song list
7. If your music folder contains an image file, it will be set as the cover art
8. Populate text in "Front insert". Here I add notes about the album, either from its Bandcamp page or from wikipedia
9. Press the "Print" button
10. Get out your scissors and cut out front and rear covers.

### Supported audio files

- mp3
- wav
- flac
- ogg
- m4a

### Fields

- **Cover Art**: Image file of cover art. This will be printed on the front of the front insert.
- **Artist**: Artist name is populated from audio meta-data
- **Album**: Album name is populated from audi meta-data
- **Front insert**: Text printed on the back of the front insert. NOTE: This field is ignored when printing a slimline case
- **Back Cover**: Text printed on the back cover. This is automatically populated from the audio files meta-data.
- **Code/Serial #**: Printed on the top left hand corner of back cover. Populated with the ISRC field from meta-data.
- **QR Code**: A QR Code that is printed in the top right hand corner of the back cover. Populated with a url of the album on bandcamp. This url is extracted from meta-data. Bandcamp purchases add a url to the comment file.

### Options

You can set the font size for the text on the back cover and front insert. You can also choose to print a cover for a slimline case.

Text positions are hard-coded and cannot be changed. Excessive options suck and make software harder to use and bloat the codebase. This application will never fall victim to unnecessary options.

## Screenshots

![CD Case Printer](images/screenshot1.png)

![Print Preview](images/screenshot2.png)
