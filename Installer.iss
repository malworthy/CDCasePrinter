; -- Example1.iss --
; Demonstrates copying 3 files and creating an icon.

; SEE THE DOCUMENTATION FOR DETAILS ON CREATING .ISS SCRIPT FILES!

[Setup]
AppName=CD Case Printer
AppVersion=1.10
WizardStyle=modern dynamic
DefaultDirName={autopf}\CD Case Printer
DefaultGroupName=CD Case Printer
UninstallDisplayIcon={app}\CDCasePrinter.exe
Compression=lzma2
SolidCompression=yes
OutputBaseFilename=CDCasePrinterInstaller
OutputDir=InstallOutput

[Files]
Source: "cdcaseprinter\bin\release\net8.0-windows7.0\publish\win-x64\*"; DestDir: "{app}"

[Icons]
Name: "{group}\CD Case Printer"; Filename: "{app}\CDCasePrinter.exe"
