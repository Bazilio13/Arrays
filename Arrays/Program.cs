using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Найти минимальный элемент массива" +
                              "\n2. Найти максимальный элемент массива" +
                              "\n3. Найти индекс минимального элемента массива" +
                              "\n4. Найти индекс максимального элемента массива" +
                              "\n5. Посчитать сумму элементов массива с нечетными индексами" +
                              "\n6. Сделать реверс массива(массив в обратном направлении)" +
                              "\n7. Посчитать количество нечетных элементов массива" +
                              "\n8. Поменять местами первую и вторую половину массива, например, для массива 1 2 3 4, результат 3 4 1 2, или для 12345 - 45312." +
                              "\n9. Отсортировать массив по возрастанию одним из способов: пузырьком(Bubble), выбором(Select) или вставками(Insert))" +
                              "\n10. Отсортировать массив по убыванию одним из способов, (отличным от способа в 9 - м задании) :  пузырьком(Bubble), выбором(Select) или вставками(Insert))" +
                              "\nВведите номер, для запуска соответствующего задания ");
            
            int taskSelection;
            taskSelection = Convert.ToInt32(Console.ReadLine());
            switch (taskSelection)
            {
                case 1:
                    Task1();
                    break;
                case 2:
                    Task2();
                    break;
                case 3:
                    Task3();
                    break;
                case 4:
                    Task4();
                    break;
                case 5:
                    Task5();
                    break;
                case 6:
                    Task6();
                    break;
                case 7:
                    Task7();
                    break;
                case 8:
                    Task8();
                    break;
                case 9:
                    Task9();
                    break;
                case 10:
                    Task10();
                    break;
            }
        }

        static void Task1()
        {
            Console.WriteLine("Введите размер массива:");

            int arraySize;
            int minNum;
            arraySize = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int[] array = new int[arraySize];

            Console.WriteLine("Массив содержит числа: ");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0,100);
                Console.Write($"{array[i]} ");
            }
            minNum = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (minNum > array[i])
                {
                    minNum = array[i];
                }
            }
            Console.WriteLine($"\nМинимальное число в массиве: {minNum}");
        }

        static void Task2()
        {
            Console.WriteLine("Введите размер массива:");

            int arraySize;
            int maxNum;
            arraySize = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int[] array = new int[arraySize];

            Console.WriteLine("Массив содержит числа: ");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 100);
                Console.Write($"{array[i]} ");
            }
            maxNum = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (maxNum < array[i])
                {
                    maxNum = array[i];
                }
            }
            Console.WriteLine($"\nМаксимальное число в массиве: {maxNum}");
        }

        static void Task3()
        {
            Console.WriteLine("Введите размер массива:");

            int arraySize;
            int minNum;
            int minNumIndex = 0;
            arraySize = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int[] array = new int[arraySize];

            Console.WriteLine("Массив содержит числа: ");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 100);
                Console.Write($"{array[i]} ");
            }
            minNum = array[minNumIndex];
            for (int i = 1; i < array.Length; i++)
            {
                if (minNum > array[i])
                {
                    minNum = array[i];
                    minNumIndex = i;
                }
            }
            Console.WriteLine($"\nИндекс минимального числа в массиве: {minNumIndex}");
        }

        static void Task4()
        {
            Console.WriteLine("Введите размер массива:");

            int arraySize;
            int maxNum;
            int maxNumIndex = 0;
            arraySize = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int[] array = new int[arraySize];

            Console.WriteLine("Массив содержит числа: ");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 100);
                Console.Write($"{array[i]} ");
            }
            maxNum = array[maxNumIndex];
            for (int i = 1; i < array.Length; i++)
            {
                if (maxNum < array[i])
                {
                    maxNum = array[i];
                    maxNumIndex = i;
                }
            }
            Console.WriteLine($"\nИндекс максимального числа в массиве: {maxNumIndex}");
        }

        static void Task5()
        {
            Console.WriteLine("Введите размер массива:");

            int arraySize;
            int summOdd = 0;
            arraySize = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int[] array = new int[arraySize];

            Console.WriteLine("Массив содержит числа: ");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 100);
                Console.Write($"{array[i]} ");
            }
            
            for (int i = 1; i < array.Length; i += 2)
            {
                summOdd += array[i]; 
            }
            Console.WriteLine($"\nСумма чисел с нечетными индексами= {summOdd}");
        }

        static void Task6()
        {
            Console.WriteLine("Введите размер массива:");

            int arraySize;
            arraySize = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int[] array = new int[arraySize];

            Console.WriteLine("Массив содержит числа: ");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 100);
                Console.Write($"{array[i]} ");
            }

            int tmp;

            for (int i = 0; i < array.Length / 2; i ++)
            {
                tmp = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length -1 - i] = tmp;
            }

            Console.WriteLine($"\nРеверс массива:");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }

        static void Task7()
        {
            Console.WriteLine("Введите размер массива:");

            int arraySize;
            arraySize = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int[] array = new int[arraySize];

            Console.WriteLine("Массив содержит числа: ");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 100);
                Console.Write($"{array[i]} ");
            }

            int numberOfOdd = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 1)
                {
                    numberOfOdd++;
                }
            }

           
            Console.Write($"\nКоличество нечетных чисел в массиве: {numberOfOdd}");
        }

        static void Task8()
        {
            Console.WriteLine("Введите размер массива:");

            int arraySize;
            arraySize = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int[] array = new int[arraySize];

            Console.WriteLine("Массив содержит числа: ");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 100);
                Console.Write($"{array[i]} ");
            }

            int tmp;
            int i2;
            i2 = array.Length - 1;

            for (int i = array.Length / 2 - 1; i >= 0; i--)
            {
                tmp = array[i];
                array[i] = array[i2];
                array[i2] = tmp;
                i2--;
            }

            Console.WriteLine($"\nПервая и вторая половины массива поменяны местами:");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }

        static void Task9()
        {
            Console.WriteLine("dfgd");
        }

        static void Task10()
        {
            Console.WriteLine("dfgd");
        }
    }
}
