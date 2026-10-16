Linux
Publish and run:
1: From the solution folder, run 'dotnet publish' in the console.
2: From the solution folder, run './Person_Registry/bin/Release/net10.0/publish/Person_Registry' in the console.

Windows
Publish and run
1: From the solution folder, run 'dotnet publish' in the console.
2: Go to .\Person_Registry\bin\Release\net10.0\publish
3: Double click Person_Registry.exe

Code segmentation
I have grouped properties and methods into separate classes depending on their responsibility and relations. For instance all methods which extend types went into their separate extension classes named after the type they extend, and these extension classes in turn went into a file called Extensions.cs to group them together. For classes representing data, like Person.cs, I grouped together related properties and methods operating on those properties into their own classes. For the Person class any property related directly to a person was defined in the class itself. All properties relating to an Address or a Company got defined in their own respective classes. Because the Company and Address classes relate to the Person class as properties I put those into the Person.cs file to group them together. This was done to give the program a structure that is easier to follow. By grouping related methods and classes together it makes it easier to read and debug the code.

C# and .NET
C# is one of the programming languages used in .NET, and .NET itself is a platform we can use to develop and build different kinds of applications. .NET also has libraries with already written functionality we can use to avoid writing unnecessary boilerplate code.

One distinct difference between C# and other languages like Javascript, for instance, is that C# is a type-safe language. This means that each type provided in an operation must be compatible in order to compile. In Javascript mismatched type operations will be silently converted to a format that runs, but it may not be the format you need in the code. This can result in errors at runtime which are not easily debugged. By enforcing type-safe rules writing in C# allows us to more easily catch and fix errors at compile time.
