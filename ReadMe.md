# Publish & Run
#### Linux

Publishing both builds the program and creates a publish folder where you will find the executable file.

1: From the solution folder, run the following in the console: 

Publish
```
dotnet publish
```
Run
```
./Person_Registry/bin/Release/net10.0/publish/Person_Registry
```
#### Windows
1: From the solution folder, run the following in the console: 
```
dotnet publish
```
2: Go to: 
```
.\Person_Registry\bin\Release\net10.0\publish
```
3: Double click Person_Registry.exe


# Code segmentation
I have grouped properties and methods into separate classes depending on their responsibility and relations. For instance all methods which extend types went into their separate extension classes named after the type they extend, and these extension classes in turn went into a file called Extensions.cs to group them together. For classes representing data, like Person.cs, I grouped together related properties and methods operating on those properties into their own classes. For the Person class, any property related directly to a person was defined in the class itself. All properties relating to an Address or a Company got defined in their own respective classes. Because the Company and Address classes relate to the Person class, as properties, I put those classes into the Person.cs file to group them together. This was done to give the program a structure that is easier to follow. By grouping related methods and classes together it makes it easier to read and debug the code.

# C# and .NET
C# is one of the programming languages used in .NET, and .NET itself is a platform we can use to develop and build different kinds of applications. .NET also has libraries with already written functionality we can use to avoid writing unnecessary boilerplate code. By using .NET's libraries together with C# we can write simpler applications, like programs that run directly in the console of the computer, or we can use different .NET packages like WPF and Blazor to write more complex desktop and website GUI applications.

One distinct difference between C# and other languages like JavaScript, for instance, is that C# is a type-safe language. This means that each type provided in an operation must be compatible in order to compile. In JavaScript mismatched type operations will be silently converted to a format that runs, but it may not be the format you need in the code. This can result in errors at runtime which are not easily debugged. By enforcing type-safe rules writing in C# allows us to more easily catch and fix errors at compile time.

# Visual Studio, Git, PowerShell
Visual Studio is an IDE (integrated development environment) we can use to code in and to interact with .NET's features directly via a GUI. VS also provides an integrated debugging suite that makes debugging the code a more streamlined process. Git is a version control system that lets us handle different versions of our codebase. We can use Git to upload and download versions of our code to and from different storage locations, like cloud storage sites (like GitHub) or a self hosted NAS storage. PowerShell is a console interface we can use instead of bash. It provides a light and user friendly environment to work with dotnet and git directly in the console.

# Commit & Branch
When we commit something we register changes to the version history of the code repository. A branch represents different version histories in the repository. Committing to a branch only changes the commit history of the given branch. This lets us keep different branches for different stages in the program, for example having one main branch that represents the current stable state of the program and a development branch where we can develop new functionality. By keeping this separation we avoid breaking needed functionality in production code.
