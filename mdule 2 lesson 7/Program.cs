
// task 1

using System;
using System.Collections.Concurrent;
using System.ComponentModel.Design;
using System.Threading.Channels;
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
Console.WriteLine("Podaj swój wiek:");
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
Console.WriteLine("Podaj swój wzrost w\"cm\":");
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

Console.WriteLine("Podaj proszę trzy liczby:");

int h = Int32.Parse (Console.ReadLine());
int j = Int32.Parse(Console.ReadLine());
int k = Int32.Parse(Console.ReadLine());

int max = Math.Max(h,Math.Max( j, k));

Console.WriteLine($"{max} jest najwieksze");


// Task 8

Console.WriteLine("Podaj kolejno wyniki z egzaminów 1.Matematyka 2.Fizyka 3.Chemia");
int mathExam = Int32.Parse(Console.ReadLine());
int physicsExam = Int32.Parse(Console.ReadLine());
int chemistryExam = Int32.Parse(Console.ReadLine());

if (((mathExam > 70 || physicsExam > 55 || chemistryExam > 45) && (mathExam + physicsExam + chemistryExam) > 180 || (mathExam + physicsExam) > 150 || (mathExam + chemistryExam) > 150))
    {
    Console.WriteLine("Kandydat dopuszczony do rekrutacji");
}
else
{
    Console.WriteLine("Kandydat nie dopuszczony do rekrutacji");
}

// Task 9

Console.WriteLine("Podaj temperature:");
int temp = Int32.Parse(Console.ReadLine());

if (temp < 0)
{
    Console.WriteLine("cholernie piździ");
}
else if (temp >= 0 && temp < 10)
{
    Console.WriteLine("zimno");
}
else if (temp >= 10 && temp < 20)
{
    Console.WriteLine("chłodno");
}
else if (temp >= 20 && temp < 30)
{
    Console.WriteLine("w sam raz");
}
else if(temp >= 30 && temp < 40)
{
    Console.WriteLine("zaczyna być słabo, bo gorąco");
}
else if (temp >= 40)
{
    Console.WriteLine("a weź wyprowadzam się na Alaskę");
}

// Task 10

Console.WriteLine("Podaj trzy długości zeby zbudować trójką, sprawdzimy czy da sie zbudowac z tego trójkąt:");

int triangleA = Int32.Parse(Console.ReadLine());
int triangleB = Int32.Parse(Console.ReadLine());
int triangleC= Int32.Parse(Console.ReadLine());

if ((triangleA < triangleB+triangleC && triangleB < triangleA + triangleC && triangleC < triangleA+triangleB) && (triangleA > 0 && triangleB > 0 && triangleC >0))
{
    Console.WriteLine("Można zbudować trójkąt");
}
else
{
    Console.WriteLine("Nie można zbudować trójką");
}

// Task 11

Console.WriteLine("Podaj ocene ucznia:");

int grade = Int32.Parse(Console.ReadLine());

switch (grade)
{
    case 1:
        Console.WriteLine("Niedostateczny");
        break;
    case 2:
        Console.WriteLine("Dopuszczający");
        break;
    case 3:
        Console.WriteLine("Dostateczny");
        break;
    case 4:
        Console.WriteLine("Dobry");
        break;
    case 5:
        Console.WriteLine("Bardzo dobry");
        break;
    case 6:
        Console.WriteLine("Celujący");
        break;
    default:
        Console.WriteLine("Niepoprawne dane.");
        break;

}


//task 12

Console.WriteLine("Podaj numer dnia tygodnia:");

int day = Int32.Parse(Console.ReadLine());

switch (day)
{
    case 1:
        Console.WriteLine("Poniedziałek");
        break;
    case 2:
        Console.WriteLine("Wtorek");
        break;
    case 3:
        Console.WriteLine("Środa");
        break;
    case 4:
        Console.WriteLine("Czwartek");
        break;
    case 5:
        Console.WriteLine("Piątek");
        break;
    case 6:
        Console.WriteLine("Sobota");
        break;
    case 7:
        Console.WriteLine("Niedziela");
        break;
    default:
        Console.WriteLine("Niepoprawne dane.");
        break;
}
