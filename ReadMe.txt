Build & Run

Linux
Publish
1: From the solution folder, run 'dotnet publish' in the console.

Run application
Option 1:
From the solution folder, run './Person_Registry/bin/Release/net10.0/publish/Person_Registry' in the console.

Option 2: 
Copy and paste the full path to the file into the console '/your/full/path/to/Person_Registry/bin/Release/net10.0/publish/Person_Registry'

Windows
Publish
1: From the solution folder, run 'dotnet publish' in the console.

Run application
1: Go to .\Person_Registry\bin\Release\net10.0\publish
2: Double click Person_Registry.exe


Code segmentation

MenuFlow:
Controls the flow of the application.

It acts as the program's point of entry and point of exit. From the Start method it loops through the given menu and displays it to the user until the user signals to exit the program.

It contains two other methods, SetStartMenu and GetMenuItem. They set the first menu shown to the user and get the user's menu choice respectively.

This design gives the program a top-down structure, which makes the flow easier to follow.

UserInputHandler:
Contains two methods, GetUserKey and GetUserLine, to get the user's key press and text input respectively.
The naming and grouping of the methods in this class give the reader a clear indication that this is where user input is handled, which makes it easier to debug issues related to user input.

Ui.cs
Contains a single method, ShowUi, to write the given text output to the console.
Wrapping Console in the Ui class makes it more readable when we need to write to the console from the menu flow. Instead of having to write Console.WriteLine(), we can now write Ui.ShowUi(). Having Console.WriteLine contained in a given method also ensures that we only need to change the code in that specific place if we want to alter how we write to the console.

Extensions.cs
Contains all the extension classes and their methods.
Each extension class is named after the respective type its methods extends, followed by the word 'Extensions'.
StringExtensions
DictionaryExtensions
ListExtensions

Using extension methods allows us to extend a type's functionality by adding our own methods. These methods will then act as if they existed in the given type, and they will also appear in the autocomplete for that type. This also lets us perform operations directly on the type itself, which means we can chain several methods together to perform operations in sequence using dot notation.

In rhe program it makes the code more consize and readable.
