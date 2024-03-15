
// task 1

using System.Collections.Concurrent;
using System.ComponentModel.Design;
using System.Xml.Linq;

int a = 5;
int b = 5;

if (a == b)
{
    Console.WriteLine("5 i 5 sa równe");
}

// task 2

int c = 15;
if (c % 2 == 0)
{
    Console.WriteLine(c + " jest liczbą parzystą");
}
else
{
    Console.WriteLine(c + " jest liczbą nieparzystą");
}

// task 3

int d = 14;

if (d > 0)
{
    Console.WriteLine(d + " jest liczba dodatnia");
}
else if (d < 0)
{
    Console.WriteLine(d + " jest liczba ujemna");
}
else
{
    Console.WriteLine(d + " nie jest ujemne ani dodanie jest zerem");
}

// task 4

int e = 2016;
if (e % 4 == 0)
{
    Console.WriteLine(e + " jest rokiem przestępnym");
}
else
{
    Console.WriteLine(e + " nie jest rokiem przestępnym");
}

// task 5
Console.WriteLine("Please input your age:");
byte f = byte.Parse(Console.ReadLine());

if (f >= 21 && f <= 29)
{
    Console.WriteLine("Możesz zostać posłem i premierem");
}
else if (f >= 30 && f <= 34)
{
    Console.WriteLine("Możesz zostać posłem i premierem");
    Console.WriteLine("Możesz zostać senatorem");
}
else if (f >= 35)
{
    Console.WriteLine("Możesz zostać posłem i premierem");
    Console.WriteLine("Możesz zostać senatorem");
    Console.WriteLine("Możesz zostać prezydentem");
}
else if (f < 21)
{
    Console.WriteLine("Jestes za młody");
}

// task 6
Console.WriteLine("What's your height, please use \"cm\":");
short g = short.Parse(Console.ReadLine());
if ( g <= 140)
{
    Console.WriteLine("Jesteś krasnoludem");
}
else if ( g >= 141 &&  g <= 160)
{
    Console.WriteLine("Jesteś niski");
}
else if (g >= 161 && g <= 179)
{
    Console.WriteLine("Jesteś średniego wzrostu");
}
else if (g >= 180 && g <= 215)
{
    Console.WriteLine("Jesteś wysoki");
}
else if (g >= 216)
{
    Console.WriteLine("Jesteś gigantem");
}

// Task 7
