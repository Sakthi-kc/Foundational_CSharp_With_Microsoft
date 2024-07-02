// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//class and methods
Random dice = new Random();
int roll = dice.Next(1, 6);
Console.WriteLine("And the dice rolled to - " + roll);

//Math class
int firstValue = 500;
int secondValue = 600;
int largerValue = Math.Max(firstValue, secondValue);
Console.WriteLine($"The maximum value is {largerValue}");

//String - Char array - String
string str = "The quick brown fox jumps over the lazy dog";
char[] charMsg = str.ToCharArray();
string newString = new string(charMsg);
Console.WriteLine(newString);


//Datatype conversion
//Widening or implicit conversion meaning converting a data type which holds less info to data type which can hold more information
int myInteger = 3;
decimal myDecimal = myInteger;
Console.WriteLine( "Int to Decimal via direct assignment - widening or implicit conversion:" + myDecimal);

//Type cast - this truncates the decimal points while casting
decimal myDecimal1 = (decimal)myInteger / 2m;
Console.WriteLine("Int to Decimal via type cast technique:" + myDecimal1);

//Narrowing conversion is vice versa
float myFloat = (float)myDecimal1;
Console.WriteLine("Float to Decimal which is narrowing conversion:" + myFloat);

//toString is used to convert any datatype to string
string floatString = myFloat.ToString();
Console.WriteLine("Float to String using .ToString():" + floatString);

//Parse conversion is used to convert from string to any datatype
string firstNumber = "5";
string secondNumber = "10";
int stringInteger = int.Parse(firstNumber) + int.Parse(secondNumber);
Console.WriteLine("String to int using int.Parse(name):" + stringInteger);

//Convert class conversion rounds up the decimal
Console.WriteLine("Another method of String to Int using Convert.ToInt32(name):" + Convert.ToInt32(firstNumber));


