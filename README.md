# CompetitiveCSharp
If you participate in a programming contests and use C# then you are probably a bit tired of the C# input features. Basically you need to parse and convert all input data by yourself. This template contains `ConsoleReader` class that simplify the data input process. You can copy and paste the template into you solution.

### Read Single Value
To read data like this
````
12
astring
````

the following code can be used.
````C#
var n = Read<int>();
var s = Read<string>();
````

Every call of the `Read` method skips whitespace symbols, gets all non whitespace symbols until the new whitespace, and convert the sequence of the read characters into the type specified. Therefore, `Read<string>()` won't read a string with a space. Only the part before space will be read.

### Read Array
If you need to read an array, you can use the `ReadArray` method.
````C#
var a = ReadArray<int>(5);
````
The code above is suitable to read data like this
````
2 6 3 100 34
```` 
This code is to read an array of strings
````C#
var a = ReadArray<string>(3);
````
The input can look like this
````
string1 string2 string3
````
Also it can look like this
````
string1
string2
string3
````

### Typical Input For Contest Problem
````
N M
A1 A2 ... AN
````
This data can be read with the following code
````C#
var n = Read<int>();
var m = Read<int>();
var a = ReadArray<int>(n);
````

### Supported Types
Every standard type that implements `IConvertible` is supported.

### Other Improvements
If you do not like to write `for` loops, you can try to use the `Times` method implemented in the template.
````C#
n.Times(i => Console.WriteLine(i));
````

And the same for nested loops
````C#
(n, m).Times((i, j) => Console.WriteLine($"{i} {j}"));
````

### Final Note
Do not use `Read` and `ReadArray` together with methods from the standard `Console` class. Some whitespace can be lost.