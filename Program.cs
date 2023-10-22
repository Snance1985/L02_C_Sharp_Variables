//variable example
// int num = 3;
// string name = "Bob";

// Console.WriteLine(num);
// Console.WriteLine(name);   


//integral data type example
// Console.WriteLine("Integral Data Types");

// sbyte byteNum = 12;
// short shortNum = 15000;
// int regNum = 1252458965;
// long longNum = 9125487523412536548;
// char characterQuote = 'A';

// Console.WriteLine(byteNum);
// Console.WriteLine(shortNum);
// Console.WriteLine(regNum);
// Console.WriteLine(longNum);
// Console.WriteLine(characterQuote);


//floating point data type example
// Console.WriteLine("Floating Point Data Types");

// float floatData = 5.96f;
// double doubleData = 45.321D;
// double anotherDoubleData = 485.21;

// Console.WriteLine(floatData);
// Console.WriteLine(doubleData);
// Console.WriteLine(anotherDoubleData);


//unicode string example
// Console.WriteLine("String Type Variables");

// string myName = "Ben";
// string nickname = "BDog";
// string numString = "123";
// string mixString = "Password123";

// Console.WriteLine(myName);
// Console.WriteLine(nickname);
// Console.WriteLine(numString);
// Console.WriteLine(mixString);


//escape sequence characters example
// Console.WriteLine("Strings with Escape Sequence");

// string intro = "My name\'s Ivan and I like \"programming\". \nThis is a new line of text.";

// Console.WriteLine(intro); 


//comments examples
// This is a single-line comment
// Console.WriteLine("Comments Examples"); // This is also a single line comment

/* This is a multi line comment with
mutiple lines of text*/
// Console.WriteLine("Text with a multi-line comment above it");


//operator example
// int x = 10;
// int y = 20;
// int z = x + y;


//unary plus and unary negation example
// int num = 3;
// int hexNum = 0xff;
// double invalidNum = double.NaN;

// // using unary negation on num
// int negativeNum = -num;

// // using unary plus to extract hex value
// int hexVal = +hexNum;

// // converting invalid value using unary plus
// double invalidVal = +invalidNum;

// Console.WriteLine(negativeNum);
// Console.WriteLine(hexVal);
// Console.WriteLine(invalidVal);


//logical negation example
// bool trueVar = true;
// bool falseVar = false;

// using logical NOT operator on the variables
// Console.WriteLine(!trueVar);
// Console.WriteLine(!falseVar);


//Increment/Decrement Operator example
// int num = 2;
// int num2 = 2;

// int postIncNum = num++;
// int preIncNum = ++num2;

// Displaying post incremented and pre-incremented values
// Console.WriteLine(postIncNum);
// Console.WriteLine(preIncNum);

// num = 2;
// num2 = 2;

// int postDecNum = num--;
// int preDecNum = --num2;

// Displaying post decremented and pre-decremented values
// Console.WriteLine(postDecNum);
// Console.WriteLine(preDecNum);


// arithmetic operators
// int num = 23;
// int num2 = 3;

// // number arithmetic examples
// int sum = num + num2;
// int difference = num - num2;
// int product = num * num2;
// int divisor = num / num2;
// int remainder = num % num2;

// // Displaying values using string addition
// Console.WriteLine("Sum: " + sum);
// Console.WriteLine("Difference: " + difference);
// Console.WriteLine("Product: " + product);
// Console.WriteLine("Integer Divisor: " + divisor);
// Console.WriteLine("Remainder: " + remainder);
// Console.WriteLine("Double Division: " + 23.0/3.0);


//string operations
// string text1 = "This is a long text containing a couple sentences to illustrate string methods. String methods are pretty useful to use and manipulate strings and implement decision making";

// string text2 = "This is just another line that can be added";

// // Using the .length property to find length
// Console.WriteLine("Length of text1 : " + text1.Length);

// // Concatenating text1 and text2 using the concat method
// Console.WriteLine("Concatenated text1 and text2: " + string.Concat(text1, text2));

// // Checking if text1 contains the word "and"
// Console.WriteLine("Does \"and\" exist?  " + text1.Contains("and"));

// // Convert text2 to lowercase
// Console.WriteLine("text2 as lowercase: " + text1.ToLower());

// // Convert text2 to uppercase
// Console.WriteLine("text2 as UPPERCASE:  " + text2.ToUpper());

// // Remove all whitespaces from text1:
// Console.WriteLine("text 1 with no extra white space: " + text1.Trim());

// // Find the first occurrence of 'a'
// Console.WriteLine("First occurrence of \'a\' in text1:  " + text1.IndexOf('a'));


//other console method write
// int inputChar = 1;
// string? inputString = "";

// Console.Write("Enter A Number from 1 to 10: ");
// inputChar = Console.Read();
// Console.WriteLine("ASCII of Number Entered: " + inputChar);

// Console.Write("Enter Full Name (press ENTER after filling the info): ");
// Console.ReadLine();
// inputString = Console.ReadLine();
// Console.WriteLine("Name Entered: " + inputString);


//constant types example
// const double PI = 3.14;


//Explicit Conversions (Casting) example
// double num1 = 25;
// double num2 = 4;

// int divide = (int) (num1/num2);
// Console.WriteLine(divide);


//Implicit Data Types example
var numVar = 23;
Console.WriteLine("Type of numVar is {0}", numVar.GetType());

var strVar = "Hello World!!";
Console.WriteLine("Type of strVar is {0}", strVar.GetType());

var dblVar = 3.14d;
Console.WriteLine("Type of dblVar is {0}", dblVar.GetType());

var boolVar = true;
Console.WriteLine("Type of boolVar is {0}", boolVar.GetType());


