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
Controls the flow of the application. It acts as the program's point of entry and point of exit. It contains functionality for starting the menu loop, setting and getting the menu, and exiting the menu loop. It is designed to give the program a top-down structure (start-loop-exit), which makes the flow easier to follow.

UserInputHandler:
Contains methods for reading user input. The naming and grouping of the methods gives the reader a clear indication that this is where user input is handled. This makes it easier to debug issues related to user input.

Ui.cs
Contains a method for writing to the console. Wrapping the write functionality in a specific class and method makes it so that we only have to change the code in that specific place. If we want to change how we write to the console in the future this saves us from having to change code in many different places.

Extensions.cs
Contains all the extension classes and extension methods used in the program. These add custom functionality to existing type, and by using extension methods we can chain together several method calls in sequence. In the program this makes the code more concise and readable. For instance, in GetMenuItem() we can return the result in a single line by passing the return value along the extension chain, instead of writing separate method calls on different lines.
Example: return DataSorter.GetFiveByName().BuildMenu();

IMenu.cs
IMenu.cs is an interface defining a method that a Menu class must implement. This ensures that any Menu class implementing the interface follows the same contract. In this case they must implement the GetMenu method definition.
