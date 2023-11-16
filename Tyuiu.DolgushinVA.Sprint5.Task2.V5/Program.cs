using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.DolgushinVA.Sprint5.Task2.V5.Lib;
namespace Tyuiu.DolgushinVA.Sprint5.Task2.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Долгушин В. А. | ИИПб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Долгушин Вадим Алексеевич | ИИПб-23-3                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая заменяет нечетные элементы целочисленного   *");
            Console.WriteLine("* массива 3 на 3 элементов, заполненного значениями с клавиатуры.         *");
            Console.WriteLine("* Результат сохранить в файл OutPutFileTask2.csv и вывести на консоль.    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int rows = 3;
            int columns = 3;
            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Введите {i},{j} элемент массива: ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(matrix);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        matrix[i, j] = 0;
                        Console.Write($"{matrix[i, j]} \t");
                    }
                    else
                    {
                        Console.Write($"{matrix[i, j]} \t");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Фaйл: " + res);
            Console.WriteLine("Coздан!");
            Console.ReadKey();
        }
    }
}
