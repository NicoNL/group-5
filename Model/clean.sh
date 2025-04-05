#!/bin/bash

# Detect the operating system
if [[ "$OSTYPE" == "msys" || "$OSTYPE" == "win32" || "$OSTYPE" == "cygwin" ]]; then
    # Windows
    echo "Detected Windows system"
    # Use PowerShell to delete .class files
    powershell -Command "Get-ChildItem -Path . -Filter *.class -Recurse | Remove-Item -Force"
else
    # Linux/Unix
    echo "Detected Linux/Unix system"
    # Use find command to delete .class files
    find . -name "*.class" -type f -delete
fi

echo "All .class files have been deleted." 