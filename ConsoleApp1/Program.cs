//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Console.Write("Write your name: ");
//string? name = Console.ReadLine();
//Console.WriteLine($"Hello {name}");

//{
//    Console.WriteLine("Hello");
//    Console.WriteLine("Welcome to C#");
//}

//string name = "Tom";
//Console.WriteLine(name);
//name = "Bob";
//Console.WriteLine(name);

//const string NAME = "Bill";
//Console.WriteLine(NAME);

//Console.WriteLine(true);
//Console.WriteLine(false);

//Console.WriteLine(-11);
//Console.WriteLine(0b11011);
//Console.WriteLine(0x0A);

//Console.WriteLine(3.2e3);

//Console.WriteLine('T');
//Console.WriteLine('2');
//Console.WriteLine('A');

//Console.WriteLine("Company \"Boo\"");
//Console.WriteLine("Hello \nWorld");

//bool check = true;
//Console.WriteLine(check ? "Checked" : "Not checked");
//Console.WriteLine(false ? "Checked" : "Not checked");


//string name = "Mary";
//int age = 35;
//bool isEmployed = true;
//double weight = 60.80;

//Console.WriteLine($"NAME: {name}");
//Console.WriteLine($"AGE: {age}");
//Console.WriteLine($"WORK: {isEmployed}");
//Console.WriteLine($"WEIGHT: {weight}");

//string name = "Hisha";
//int age = 1;
//double length = 0.5;
//Console.WriteLine($"NAME: {name} AGE: {age} LENGTH: {length}m");


//string name = "Hisha";
//int age = 1;
//double length = 0.5;
//Console.WriteLine("NAME: {0} AGE: {2} LENGTH: {1}m", name, length, age);

//string name = "Hisha";
//int age = 1;
//double length = 0.5;
//Console.Write($"NAME: {name} AGE: {age} LENGTH {length}m");

//int a = 3;
//int b = 5;
//int c = 40;
//int d = c-- - b * a;
//Console.WriteLine($"a = {a} b = {b} c = {c} d = {d}");

//int x1 = 2;
//int y1 = 5;
//Console.WriteLine(x1 & y1);

//int x2 = 4;
//int y2 = 5;
//Console.WriteLine(x2 & y2);

//int x = 45;
//int key = 102;
//int encrypt = x ^ key;
//Console.WriteLine($"Encoded number: {encrypt}");
//int decrypt = encrypt ^ key;
//Console.WriteLine($"Decrypted number: {decrypt}");

//int x = 12;
//Console.WriteLine(~x);

//int x = 12;
//int y = ~x;
//y += 1;
//Console.WriteLine(y);

//int a = 16;
//int b = 2;
//int c = a << b;
//Console.WriteLine($"Encrypted number: {c}");

//byte a = 4;
//byte b = (byte)(a+70);
//Console.WriteLine(b);

//int a = 10;
//a *= 2;
//Console.WriteLine(a);

//ushort a = 4;
//byte b = (byte)a;
//Console.WriteLine(b);

//int a = 4;
//int b = 6;
//byte c = (byte)(a+b);
//Console.WriteLine(c);

//int a = 10;
//int b = 4;
//bool c = a == b;
//Console.WriteLine(c);

//int num1 = 8;
//int num2 = 6;
//if (num1 > num2)
//{
//    Console.WriteLine($"Число {num1} больше числа {num2}");
//}

//int num1 = 18;
//int num2 = 18;
//if (num1 > num2)
//{
//    Console.WriteLine($"Число {num1} больше числа {num2}");
//}
//else if (num1 < num2)
//{
//    Console.WriteLine($"Число {num1} меньше числа {num2}");
//}
//else
//{
//    Console.WriteLine($"Число {num1} равно числу {num2}");
//}

//string name = "Bob";
//    if (name == "Tom")
//{
//    Console.WriteLine($"Your name is Tomas");
//}
//else if (name == "Bob")
//{
//    Console.WriteLine($"Your name is Robert");
//}
//else if (name == "Mike")
//{
//    Console.WriteLine($"Your name is Michael");
//}
//else
//    Console.WriteLine($"Unknown name");

//int x = 3;
//int y = 4;
//int z = x < y ? (x + y) : (y-x);
//Console.WriteLine(z);

//for (int i = 1; i < 4; i++)
//{
//    Console.WriteLine(i);
//}

//int i = 6;
//while (i > 0)
//{
//    Console.WriteLine(i);
//    i--;
//}

//foreach (var c in "Tom")
//{
//    Console.WriteLine(c);
//}

//int j = 2;
//for (int i = 1; i < 100; i = i + 2)
//{
//    j = j - 1;
//    while (j < 15)
//    { 
//        j = j + 5;
//    }
//}


//Random generator = new Random();
//int generatedNumber = generator.Next(100);
//int count = 1;


//Console.WriteLine("Компьютер загадал число от 1 до 100. Попробуйте отгадать его за 10 попыток");

//while (count <= 10)
//{
//    Console.WriteLine($"Попытка #{count}. Введите число");
//    var answer = Convert.ToInt32(Console.ReadLine());
//    if (generatedNumber == answer)
//    {
//        Console.WriteLine($"Вы угадали. Это число {generatedNumber}!");
//        break;
//    }
//    else if (generatedNumber > answer)
//    {
//        Console.WriteLine("Вы не отгадали. Я загадал большее число.");
//    }
//    else if (generatedNumber < answer)
//    {
//        Console.WriteLine("Вы не отгадали. Я загадал меньшее число.");
//    }

//    if (count == 10)
//    {
//        Console.WriteLine($"Game over. Number was {generatedNumber}");
//    }

//    count++;

//}

//Console.ReadLine();

//Console.WriteLine("What is your name?");
//Console.WriteLine($"Hello, {Console.ReadLine()}");



//int[] numbers = { 5, 13, 7, 1, 8, 2, 18, 4, 17, 9, 3, 6, 10, 15, 20, 11, 19, 16, 12, 14 };

//int example ;
//for (int i = 0; i < numbers.Length - 1; i++)
//{
//    for (int k = i + 1; k < numbers.Length; k++)
//    {
//        if (numbers[i] > numbers[k])
//        {
//            example = numbers[i];
//            numbers[i] = numbers[k];
//            numbers[k] = example;
//        }
//    }
//}

//Console.WriteLine();
//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine(numbers[i]);
//}


int arrayLength = 20;
int[] numbers = new int[arrayLength];

Random rnd = new Random();
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = rnd.Next(1000);
}
Console.WriteLine("base array");
foreach (var number in numbers)
{
    Console.Write($"{number}, ");
}


int example;
for (int i = 0; i < numbers.Length - 1; i++)
{
    for (int k = i + 1; k < numbers.Length; k++)
    {
        if (numbers[i] > numbers[k])
        {
            example = numbers[i];
            numbers[i] = numbers[k];
            numbers[k] = example;
        }
    }
}
Console.WriteLine();
Console.WriteLine("sorted array");
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"{numbers[i]}, ");
}