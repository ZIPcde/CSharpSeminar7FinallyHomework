// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.
using System.Diagnostics.Metrics;

System.Console.WriteLine("Задача 1:");
void Main()
{
    System.Console.WriteLine("Вам предстоит ввести два числа в порядке возрастания...");
    int M = takeTheNumber("Введите число 'M': ");
    int N = takeTheNumber("Введите число 'N': ");
    if (M > N)
    {
        System.Console.WriteLine("Вы ввели числа не в порядке возрастания, но Skynet милостиво поменял их местами!");
        int temp = M;
        M = N;
        N = temp;
    }
    System.Console.Write("from 'M' -   ");
    intervalOutput(M, N);
    System.Console.Write(" - to 'N'");
    Akkerman();
    task3();
}

int takeTheNumber(string msg)
{
    System.Console.WriteLine(msg);
    int inputNumber = Convert.ToInt32(System.Console.ReadLine());
    return inputNumber;
}
void intervalOutput(int M, int N)
{
    if (M == N + 1) return;
    System.Console.Write(M + "  ");
    intervalOutput(M + 1, N);
}


// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 


void Akkerman()
{
    System.Console.WriteLine("\nЗадача 2:");
    Console.WriteLine("Для вычисления функции Аккермана нам вновь вонадобятся числа M и N...");
    Console.Write("Введите число M: ");
    int mNumber = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите значение N: ");
    int nNumber = Convert.ToInt32(Console.ReadLine());

    int akkFuncCalc(int mNumber, int nNumber)
    {
        if (mNumber == 0)
        {
            // System.Console.WriteLine("n + 1");
            return nNumber + 1;

        }

        else if (mNumber == 0)
        {
            // System.Console.WriteLine("AkkFunct(m-1, 1)");
            return akkFuncCalc(mNumber - 1, 1);
        }
        else
        {
            // System.Console.WriteLine("AkkFunct(m-1, AkkFunct(m, n-1)");
            return akkFuncCalc(mNumber - 1, akkFuncCalc(mNumber, nNumber - 1));
        }
    }
    Console.Write($"Функция Аккермана равно {akkFuncCalc(mNumber, nNumber)} ");
}
// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.
void task3()
{
    System.Console.WriteLine("\nЗадача 3:");
    System.Console.WriteLine("Введите требуемую длинну одномерного массива:");
    int arrayLength = Convert.ToInt32(Console.ReadLine());
    int printCounter = arrayLength;                               // counter for second recursion.
    int[] arrayOfNumbers = new int[arrayLength];
    arrayOfNumbers = arrayGenerate(arrayLength);
    arrayPrint(printCounter, arrayOfNumbers);

    int[] arrayGenerate(int counter)
    {
        counter--;
        if (counter < 0) return arrayOfNumbers;
        arrayOfNumbers[counter] = new Random().Next(1, 10);
        arrayGenerate(counter);
        return arrayOfNumbers;
    };
    // for (int i = 0; i < arrayOfNumbers.Length; i++)                                          //  контрольный цикл "for"
    // {                                                                                        //  для проверки
    //     System.Console.WriteLine($"Элемент массива №_{i} = {arrayOfNumbers[i]}");            //  правильности работы рекурсии
    // }                                                                                        //  в функии "void arrayPrint()"
    void arrayPrint(int i, int[] array)
    {
        i--;
        if (i < 0) return;
        arrayPrint(i, array);
        System.Console.WriteLine($"Элемент массива №_{i} = {arrayOfNumbers[i]}"); //System.Console.Write(array[i - 1] + " ");
    }
}
Main();