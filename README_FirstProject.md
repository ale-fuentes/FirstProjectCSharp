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
