//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Math.Pow не использовать
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

/*
void FindPowerPositive(int numA, int numB) // метод, в котором степень является положительным числом
{
    int degree = numA;
    for (int B1 = 2; B1 <= numB; B1++)  //счетчик начинается с двух, так как число в первой степени равно самому себе
    {
        degree = degree * numA;
    }
    Console.Write ($"The {numA} to the power of {numB} is {degree}");
}

void FindPowerNegative(int numA, int numB) // метод, в котором степень является отрицательным числом
{
    int numB1 = (-1) * numB;
    int degree = numA;
    for (int B1 = 2; B1 <= numB1; B1++)
    {
        degree = degree * numA;
    }
    Console.Write ($"The {numA} to the power of {numB} is 1/{degree}");
}

Console.Write("Input number A: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberB == 0)
    Console.Write ($"The {numberA} to the power of {numberB} is 1");
else
    if (numberB > 0)
        FindPowerPositive(numberA, numberB);
    else
        FindPowerNegative(numberA, numberB);
*/


//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

/*
void SumOfDigits(int number)
{
    number = Math.Abs(number); // применяем модуль на случай, если введенное число будет отрицательным
    int sum = 0;
    int unit;
    while (number > 0)
    {
        unit = number % 10;
        sum = sum + unit;
        number = number / 10;
    }
    Console.Write($"The sum of the digits of your number is: {sum}");
}

Console.Write("Input your number: ");
int num = Convert.ToInt32(Console.ReadLine());

SumOfDigits(num);
*/


//Задача 29: Напишите программу, которая задаёт массив из произвольного колчества элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int [] NewArray(int array)
{
    Console.Write("Input a range of array values. Beginning of the range: ");
    int a = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("Input a range of array values. End of the range: ");
    int z = Convert.ToInt32(Console.ReadLine());

    int [] randomArray = new int[array]; // создаем массив с типом даанных int
    for (int i = 0; i < array; i++)
    {
        randomArray[i] = new Random().Next(a, z); 
    }
    return randomArray;
}

void ShowNewArray(int [] array01)
{
    Console.WriteLine("Your array is: ");
    for (int i = 0; i < array01.Length; i++)
    {
        Console.Write(array01[i] + " ");
    }
}

Console.Write("Input the size of the array: ");
int array_length = Convert.ToInt32(Console.ReadLine());

if (array_length <= 0)
    Console.Write("The size of the array must be greater then 0!");
else
    ShowNewArray(NewArray(array_length));