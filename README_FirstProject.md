# Types of projects
![](https://img.shields.io/badge/Code-C_Sharp-informational?style=flat&logo=csharp&logoColor=white&color=007acc)

[Return HOME](README.md)

#### Some examples of projects

* Class Library (DLLs)
* Console Application (Bash)
* Web Project (ASP.NET WEb, ASP.NET MVC, ASP.NET WebAPI, etc)
* Test Project
* etc ...

For create a project, ussing `dotnet` with paramenters:

```
dotnet new console  // new console project
dotnet new classlib // new class library project
dotnet new web      // new ASP.NET Core project
dotnet new mvc      // new ASP.NET Core project
dotnet new webapi   // new ASP.NET Core project
dotnet new mstest   // new Microsoft Test project
```

We can will create a project in a new folder, ussing `-o nome_folder` parameters:

```
dotnet new console -o MyApp 
```

#### Enviroment variables

Variables separated by enviroment:

* Development
* Staging
* Production
* etc.

Each enviroment has your their configuration:

* key access
* conection with data base, etc.
* etc.

In .Net, we need indicated what enviroment our app running:

```
dotnet run --environment=$My_ENVIRONMENT
```

Example:

```
dotnet run --environment=development
```

#### Console structure

* file `.csproj`: XML format, project definitions, present in all .Net project.
* file `Program.cs`: main file (C#), where start the project, running.

#### Debugging

**A little story**
When the computer used the lamp as a transistor, at that moment, the bugs (looking for a hot spot), came in and stayed close to them. After some time, an error arose in the functionality of the computer, the error broke the contact between the lamp and the electronic board. The technician said 'a bug'.

This expression is also used now, when the programmer says that the code does not work well and breaks its execution.

**How to debuggind**

* Ussing tool Visual Studio Code.
* Ussing Breack point, red point next number line of code.
* Ussing `Run and Debug` tool VSCode.

