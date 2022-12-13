using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Aksana.Patrubeika
{
    class Scanner
    {
        public int urNumber;
       
        public int getNumber()        {
            
            urNumber = Int32.Parse(Console.ReadLine());
            return urNumber;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            0.При помощи цикла for вывести на экран нечетные числа от  1 до 99.
            При решении используйте операцию инкремента(++).
            1.Необходимо вывести на экран числа от 5 до 1.
            При решении используйте операцию декремента(--).
            2.Напишите программу, где пользователь вводит любое целое положительное число.
            А программа суммирует все числа от 1 до введенного пользователем числа.
            Для ввода числа воспользуйтесь Console.ReadLine.
            3.Создайте массив целых чисел.Напишете программу, 
            которая выводит сообщение о том, входит ли заданное число в массив или 
            нет.Пусть число для поиска задается с консоли(класс Scanner).
            4.Создайте и заполните массив случайным числами и выведете максимальное, 
            минимальное и среднее значение.
            Для генерации случайного числа используйте метод Math.random().
            Пусть будет возможность создавать массив произвольного размера.
            Пусть размер массива вводится с консоли.
            5.Создайте 2 массива из 5 чисел.
            Выведите массивы на консоль в двух отдельных строках.
            6.Выведите на экран первые 11 членов последовательности  Фибоначчи.
            7.Создайте массив и заполните массив.
            Выведите массив на экран в строку.
            Замените каждый элемент с нечётным индексом на ноль.
            Снова выведете массив на экран на отдельной строке.
            8.Создайте массив строк.Заполните его произвольными именами людей.
            Отсортируйте массив.
            Результат выведите на консоль.
                */

            //0.Нечетные числа
            Console.WriteLine("0.Odd numbers of the array:");
            int[] array0 = new int[100];
            ouputOodNumbers(array0);
            Console.WriteLine("_____________________");

            //1.Вывод чисел от 5 до 1
            Console.WriteLine("1.Numbers from 5 to 0: ");
            int[] array1 = { 1, 2, 3, 4, 5 };
            reversOfNumbers(array1);
            Console.WriteLine("_____________________");

            //2.Сумма чисел
            Console.WriteLine("2.Sum of array numbers: ");
            Console.WriteLine("Enter numbers for array (use whitespase between and will push Enter)");
            int[] arrayOfNumbers = Console.ReadLine().Split(' ').Select(s => Convert.ToInt32(s)).ToArray();
            sumOfArray(arrayOfNumbers);
            Console.WriteLine("_____________________");

            //3.Чек числа в массиве
            Console.WriteLine("3.Checking number in the array: ");
            int[] arrayOfNumbers2 = { 2, 6, 8, 66, 200, 6, 9, 4 };
            Scanner scanner = new Scanner();
            scanner.getNumber();
            checkOfNumber(arrayOfNumbers2, scanner.urNumber);
            Console.WriteLine("_____________________");


            //4.Мин, Мах, Ср.арифм. массива
            Console.WriteLine("4.Max, Min, Arithmetic mean of array numbers: ");
            Console.WriteLine("Enter capacity of array: ");
            int capacity = Int32.Parse(Console.ReadLine());
            int[] oversixedArray = new int[capacity];
            randomArray(oversixedArray);
            Console.WriteLine("_____________________");

            //5.Два массива
            Console.WriteLine("5.Output of two arrays");
            int[] arrayOfFive1 = { 5, 6, 8, 9, 10 };
            int[] arrayOfFive2 = { 3, 99, 20, 6, 52 };
            randomFiveArray(arrayOfFive1);
            randomFiveArray(arrayOfFive2);
            Console.WriteLine("_____________________");

            //6.Числа Фибоначчи
            Console.WriteLine("6.Fabinachi's numbers");
            int[] arrayOfFive3 = new int[11];
            fabinachyNumbers(arrayOfFive3);
            Console.WriteLine("_____________________");

            //7.Массив с заменой
            Console.WriteLine("7.Exchenging of array number");
            int[] zeroArray = new int[10];
            exchengeNumbers(zeroArray);
            Console.WriteLine("_____________________");

            //8.Сортировка массива
            Console.WriteLine("8.Sorting of array: ");
            string[] Names = { "Оксана", "Петр", "Светлана", "Леонид", "Надежда", "Елена", "Марк" };
            sortingOfArray(Names);
            Console.ReadLine();
            Console.WriteLine("_____________________");
        }

        static void ouputOodNumbers(int[] array)   //Searching add numbers
        {
            Random random = new Random();           //filling the array use rundom
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 100);
            }
            for (int i = 0; i < array.Length; i++)
            {
                int j = array[i];
                if (j % 2 != 0) Console.Write($" {j}");
            }
            Console.WriteLine();
        }

        static void reversOfNumbers (int[] array)
        {
            int i = array[4];
            while ( i >= array[0])            
            {
                Console.Write($" {i}");
                i--;
            }
            Console.WriteLine();
        }

        static void sumOfArray(int [] array)
        {
            int sum = 0;            
            foreach (int number in array)
            {
                sum += number;
            }
            Console.WriteLine($"Sum of array numbers is: {sum}");
        }

        static void checkOfNumber(int[] array, int number)
        {
            if (array.Contains(number))
            {
                Console.WriteLine($"Array contains {number}");
            }
            else
            {
                Console.WriteLine($"Array doesn't contain {number}");
            }
        }

        static void randomArray(int[] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 100);
            }
            foreach (int values in array)
            {
                Console.Write($" {values}");
            }
            Console.WriteLine();
            Console.WriteLine($"Max of the array is: {array.Max()}");
            Console.WriteLine($"Min of the array is: {array.Min()}");
            int sum = 0;
            foreach (int number in array)
            {
                sum += number;
            }
            double average = sum / array.Length;
            Console.WriteLine($"Arithmetic mean of array is: {average}");
        }

        static void randomFiveArray(int[] array)
        {
            //Random random = new Random();
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = random.Next(0, 100);
            //}
            foreach (int values in array)
            {
                Console.Write($" {values}");
            }
            Console.WriteLine();
        }

        static void fabinachyNumbers(int[] array)
        {
            //int x = 1;
            array[0] = 1;
            array[1] = 1;
            for (int i = 2; i < array.Length; i++)
            {   
                array[i] = array[i-2] + array[i-1];  
            }
            foreach (int item in array)
            {
                Console.Write($" {item}");
            }
            Console.WriteLine();
        }

        static void exchengeNumbers(int[] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 100);
            }
            foreach (int values in array)
            {
                Console.Write($" {values}");
            }
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    array[i] = 0;                    
                } 
            }
            foreach (int values in array)
            {
                Console.Write($" {values}");
            }
            Console.WriteLine();
        }

        static void sortingOfArray(string[] array)
        {
            foreach (string values in array)
            {
                Console.Write($" {values}");
            }
            Console.WriteLine();
            Array.Sort(array);
            foreach (string values in array)
            {
                Console.Write($" {values}");
            }
            Console.WriteLine();
        }  
    }
}
