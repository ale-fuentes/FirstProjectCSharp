# Types of projects
![](https://img.shields.io/badge/Code-C_Sharp-informational?style=flat&logo=csharp&logoColor=white&color=007acc)

[Return HOME](README.md)


## Some Tips

**dont use spacing or special character in names of program:**

* Good: `MyApp`, `Orders`, `MeApp`.
* Bad: `My App`, `$APP`, `App#Teste`.

**ussing short path and without special character:**

* Good: `C:\dev`, `C:\apps`.
* Bad: `C:\way with some spaces special\My app`.

**avoid net path**

* `C:\dev` is a good option

**C# are sensitive code**

* C# can distinct between lowercase and uppercase
* `Test` is different that `test`

---

## Structure of a class

#### scope 

* import: `using System`
* namespace: is a logical division (similar name of folder where project where was created), `namespace MyApp`
* class: similair name of file, `class Program`
* main method: `static void Main(string[] args)`

#### namespace

* is a logical division of project.
* cannot has two class with similar name inner a `namespace`.
* scope of `namespace` are between brackets.
* a `namespace` can be use for several files.
* can create several `namespace` that wants.
* `namespace` cannot has spaces or special character.
* all word of name the `namespace`, init with upercase.
* can has a `namespace` inner other separted with dot ".".
* generallity `namespace` has a similar estructure to folders.
* `namespace` are a keyword. 

#### using

* indicated wich library our class will using.
* using are locationg in first line of file.
* `using` are a keyword. 

#### resumen

* organization our project in folders and namespaces are fundamental.
* in big applications, to value of code are high.
* many files.
* many people or cowokers working together in the same project
* understing good this organization are fundamental.
* Make extensive use of file creation and namespaces.

---

## Variavel

**tips**

* use cohesive names.
* dont use special character or spaces.
* cannot start name with a number.
* the first letter of name is lowcase.


Can use type or keyword `var`.

```
int age;            // is correct, init with default value, in int are ZERO
int otherAge = 25;  // is correct, init with 25
var sameAge = 25;   // is correct, init with 25
var againAge;       // Erro, var need initialized
```

#### Const

* use for content a information that can will using without modified.
* cannot alter your content after created.
* when creating a const variavel, it need set a value .
* cannot using the keyword `var` for create constant.
* constant are more otimized that variavel.
* use cohesive names.
* dont use special character or spaces.
* dont start name with a number.
* is comom using names in upercase separate entre underscore "_".
* this idea is with a simple see, we know that this variavel are constant.


```
const int MIN_AGE = 20; // is correct, init const with 25.
const int MAX_AGE;      // Erro, var need initialized.
const var MAX_AGE = 20  // Erro, cannot use var with const.
```

#### KeyWord

[C# Keywords](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/)


#### comments

* it is useful where I need say some thing about code.
* `dotnet` cannot  execute it
* comment can being: one line `//`, few lines `/* */`, and metadata (XML) `///`.

#### built-in types

* are types where another complex type will derive.
* when difined correct types get otimizing execute.
* also called `type value`.
* stores the value and not the reference to an elemento in memory.
* classified:
    * simple types
    * enums
    * structs
    * nullabel types
* each built-in types has a capacity.
* if this capacity is overfload, to app give error.
* its pre-definited capacity do help to otimize we app.
* exemplo if `int` type: -2.147.483.648 to 2.147.483.647.

#### System

* in `.Net` all init from base type called `system`.
* all types (complex or built-in) derive to him.
* its are the base of `.Net` objects.
* your using are explicited.

#### Byte

* represented a byte (8 bits). Its range are 0 to 255.
* `sbyte` allow negative values. Its range are -128 to 127.

 > **Signed e usigned**
 > 
 > the charater `s` of `sbyte` is `Signed Byte`. 


#### integer

* are number without decimal number.
* `short/ushort`, `int/uint`, `long/ulong`.
* the letter `u` is for set `unsigned` value (only greater than or equal to 0).
* short (16 bit): -32.768 to 32.767.
* ushort (16 bit): 0 to 65.535.
* int (32-bit): -2.147.483.648 to 2.147.483.647.
* uint (32-bit): 0 to 4.294.967.295.
* long (64-bit): -9.223.372.036.854.775.808 to 9.223.372.036.854.775.807.
* ulon (64-bit): 0 to 18.446.744.073.709.551.615.


#### float

#### boolean

#### char

#### string

#### var

#### object

#### nullable types

#### alias

#### custom values

`built-in` has custom values when programmer dont assigned a value:

```
int       => 0
float     => 0
decimal   => 0
bool      => false
char      => '\0'
string    => ""
```


#### implicit conversion

```
sbyte     to : short, int, long, float, double, or decimal.
byte      to : short, ushort, int, uint, long, ulong, float, double, or decimal.
short     to : int, long, float, double, or decimal.
ushort    to : int, uint, long, ulong, float, double, or decimal.
int       to : long, float, double, or decimal.
uint      to : long, ulong, float, double, or decimal.
long      to : float, double, or decimal.
ulong     to : float, double, or decimal.
char      to : ushort, int, uint, long, ulong, float, double, or decimal.
float     to : double.
```


#### explicit conversion