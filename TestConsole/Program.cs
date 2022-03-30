// See https://aka.ms/new-console-template for more information
// by alefuentes

var myText = "Testing";
int age;            // is correct, init with default value, in int are ZERO
// int otherAge = 25;  // is correct, init with 25
// var sameAge = 25;   // is correct, init with 25
//var againAge;       // Erro, var need initialized


const int MIN_AGE = 20;
/*
const int MAX_AGE; // Erro, var need initialized
const var MAX_AGE = 20 // Erro, cannot use var with const 
*/

byte myByte = 127;
sbyte MySbyte = -128;

int myInt = 128;
uint myUint = 152625;
long myLong = 325;

double myDouble = 128.0005;
float myFloat = 128.0005f;
decimal myDecimal = 128.0005m;

bool myBool = true;
bool myBoolFalse = false;

char myCharUnicode = 'a';

string myString = "Hi multiverse";

object myObject = "This are a object";
Console.WriteLine("Hello, World!, " + myObject);
myObject = 125;
Console.WriteLine("Hello, World!, " + myObject);

int? myIntNullable = null;
Console.WriteLine("Hello, World!, " + myIntNullable);
myIntNullable = 25;
Console.WriteLine("Hello, World!, " + myIntNullable);