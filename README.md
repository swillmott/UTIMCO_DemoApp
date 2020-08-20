# UTIMCO_DemoApp
Simple App for UTIMCO to read a json file and output a summary

# Use
1. Download  the .exe from \UTIMCO_DemoApp\bin\Release\netcoreapp3.1\UTIMCO_DemoApp.exe
2. Run it using the command line
3. Either supply a filepath as the first argument, or the program will prompt the user to enter a filepath. Filepaths can be relative or absolute.

# Assumptions:
- User has access to file
- File has a .json extension


# To-Dos
- Security checking that the user has permissions to access the file
- Checking that the filepath is valid, and better error messaging around that
- Checking that the filepath isn't null or empty
- Unit tests for the Controller