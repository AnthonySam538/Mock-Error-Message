#!/bin/bash
#In the official documentation the line above always has to be the first line of any script file.

# Author: Anthony Sam
# Program Name: Mock Error Message

#This is a bash shell script to be used for compiling, linking, and executing the C# (.cs) files.
#Execute this file by navigating the terminal window to the folder where this file resides, and then enter either of the commands below:
#  sh run.sh OR ./run.sh

echo "First, remove any potentially outdated .dll or .exe files using the keyword rm"
rm *.dll
rm *.exe

echo "Display the list of the remaining files in the terminal using the keyword ls"
ls -l

echo "Compile MockErrorMessageForm.cs to create the file: MockErrorMessageForm.dll"
mcs -target:library -r:System.Windows.Forms.dll -r:System.Drawing -out:MockErrorMessageForm.dll MockErrorMessageForm.cs

echo "Compile MockErrorMessageMain.cs and link the previously created .dll file(s) to create an executable (.exe) file."
mcs -r:System.Windows.Forms.dll -r:MockErrorMessageForm.dll -out:MockErrorMessage.exe MockErrorMessageMain.cs

echo "Display the updated list of files in the folder, now including the newly created .dll and .exe files"
ls -l

echo "Run the program."
./MockErrorMessage.exe

echo "The script has terminated."
