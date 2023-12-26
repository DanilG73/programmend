using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp141617
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задачи");
            int pr = int.Parse(Console.ReadLine());

            switch (pr)
            {
                case 1:
                    {

                        int[,] array = new int[,]
                          {
                           {1, 2, 3},
                           {4, 5, 6},
                           {7, 8, 9}
                                     };

                        int k = 1; // номер строки
                        int s = 2; // номер столбца

                        int rows = array.GetLength(0); // количество строк
                        int columns = array.GetLength(1); // количество столбцов

                        // Замена элементов к-й строки
                        for (int i = 0; i < columns; i++)
                        {
                            if (i != s) // проверка, чтобы не изменять элемент, стоящий на пересечении
                            {
                                array[k, i] = -array[k, i];
                            }
                        }

                        // Замена элементов s-го столбца
                        for (int i = 0; i < rows; i++)
                        {
                            if (i != k) // проверка, чтобы не изменять элемент, стоящий на пересечении
                            {
                                array[i, s] = -array[i, s];
                            }
                        }

                        // Вывод получившегося массива
                        for (int i = 0; i < rows; i++)
                        {
                            for (int j = 0; j < columns; j++)
                            {
                                Console.Write($"{array[i, j]} ");
                            }
                            Console.WriteLine();
                        }
                    }
                    break;

                case 2:
                    {
                        Console.Write("Введите n");
                        int n = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите m");
                        int m = Convert.ToInt32(Console.ReadLine());
                        int[,] matrix = new int[m, n]; // создаем двумерный массив размером m строк и n столбцовr
                        int[] array = new int[m * n]; // создаем одномерный массив размером m*n

                        int index = 0; // индекс для прохода по одномерному массиву

                        // Заполнение двумерного массива значениями (пример)
                        for (int i = 0; i < m; i++)
                        {
                            for (int j = 0; j < n; j++)
                            {
                                matrix[i, j] = i + j; // пример значения элемента в двумерном массиве
                            }
                        }

                        // Копирование значений из двумерного массива в одномерный по столбцам
                        for (int j = 0; j < n; j++)
                        {
                            for (int i = 0; i < m; i++)
                            {
                                array[index] = matrix[i, j]; // копирование значения элемента из двумерного массива в одномерный
                                index++;
                            }
                        }

                        // Вывод значений одномерного массива (проверка)
                        for (int i = 0; i < m * n; i++)
                        {
                            Console.Write(array[i] + " ");
                        }

                        Console.ReadKey();
                    }
                        break;
                case 3:
                    { 
                        //Практика 16
                        string str = "++++---0-12-3+0+0";

                        int countPlusMinus = 0;
                        int countZeroAfterPlusMinus = 0;

                        for (int i = 0; i < str.Length - 1; i++)
                        {
                            if (str[i] == '+' || str[i] == '-')
                            {
                                countPlusMinus++;

                                if (Char.IsDigit(str[i + 1]) && str[i + 1] == '0')
                                {
                                    countZeroAfterPlusMinus++;
                                }
                            }
                        }

                        Console.WriteLine("Количество символов '+' и '-': " + countPlusMinus);
                        Console.WriteLine("Количество символов '+' и '-' после которых следует цифра ноль: " + countZeroAfterPlusMinus);
                    }
                            break;

                case 4:
                    {
                        string text = "Привет   мир!         Как    дела?";
                        string result = "";

                        for (int i = 0; i < text.Length; i++)
                        {
                            // Проверяем, что текущий символ не является пробелом
                            if (text[i] != ' ')
                            {
                                result += text[i];
                            }
                            else
                            {
                                // Если предыдущий символ в результате не пробел, добавляем текущий пробел
                                if (i > 0 && result[result.Length - 1] != ' ')
                                {
                                    result += text[i];
                                }
                            }
                        }
                        Console.WriteLine(result); 
                    }
                    break;

                    case 5:
                   //Практика 17
                    {
                        string str1 = "Привет как настроение сегодня";
                        string str2 = "настроение";
                        string str3 = "настрой";

                        // Разделительные символы между словами
                        char[] delimiterChars = { ' ', ',', '.', ':', '\t' };

                        // Разбиваем первую строку на слова
                        string[] words = str1.Split(delimiterChars);

                        // Создаем новую строку для результата
                        string result = "";

                        // Проходим по каждому слову
                        foreach (string word in words)
                        {
                            // Если текущее слово совпадает со второй строкой, заменяем его на третью строку
                            if (word == str2)
                            {
                                result += str3 + " ";
                            }
                            else
                            {
                                result += word + " ";
                            }
                        }

                        // Удаляем лишний пробел в конце строки
                        result = result.TrimEnd();

                        Console.WriteLine(result);
                    }
                    break;

                case 6:
                    {
                        string input = "Здравствуйте какой чудесный день сегодня";
                        string[] words = input.Split(' ');

                        var uniqueWords = words.Where(word => word.Distinct().Count() == word.Length)
                                               .OrderBy(word => word)
                                               .OrderByDescending(word => word.Length)
                                               .Take(1);

                        foreach (var word in uniqueWords)
                        {
                            Console.WriteLine(word);
                        }
                    }
                    break;

            }
            Console.ReadKey();








        }
    }
}
