//Задание 2
//Дан двумерный массив размерностью 5×5, заполненный случайными числами из диапазона от –100 до 100.
//Определить сумму элементов массива, расположенных между минимальным и максимальным элементами.

using System;

namespace HW_2_C_Sharp_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int row = 5;
            int col = 5;
            int rndMin = -100;
            int rndMax = 100;
            int min = rndMax;
            int max = rndMin;
            int summ = 0;
            int[,] arrMinMaxItem = new int[2, 2];
            int[,] arr = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    arr[i, j] = random.Next(rndMin, rndMax);
                    Console.Write($"{arr[i, j]}. ");
                    if (min > arr[i, j])
                    {
                        min = arr[i, j];
                        arrMinMaxItem[0, 0] = i;
                        arrMinMaxItem[0, 1] = j;
                    }
                    if (max < arr[i, j])
                    {
                        max = arr[i, j];
                        arrMinMaxItem[1, 0] = i;
                        arrMinMaxItem[1, 1] = j;
                    }
                }
                Console.WriteLine();
            }
            int minRow = (arrMinMaxItem[0, 0] < arrMinMaxItem[1, 0]) ? arrMinMaxItem[0, 0] : arrMinMaxItem[1, 0];
            int maxRow = (arrMinMaxItem[0, 0] > arrMinMaxItem[1, 0]) ? arrMinMaxItem[0, 0] : arrMinMaxItem[1, 0];
            int minCol = (arrMinMaxItem[0, 1] < arrMinMaxItem[1, 1]) ? arrMinMaxItem[0, 1] : arrMinMaxItem[1, 1];
            int maxCol = (arrMinMaxItem[0, 1] > arrMinMaxItem[1, 1]) ? arrMinMaxItem[0, 1] : arrMinMaxItem[1, 1];
            Console.WriteLine($"min = {min} with row = {arrMinMaxItem[0, 0] + 1} and column = {arrMinMaxItem[0, 1] + 1}");
            Console.WriteLine($"max = {max} with row = {arrMinMaxItem[1, 0] + 1} and column = {arrMinMaxItem[1, 1] + 1}");
            if (minCol == 4)
            {
                minRow++;
                minCol = 0;
            }
            else
                minCol++;
            for (int i = minRow; i < row; i++)
            {
                for (int j = minCol; j < col; j++)
                {
                    if (i >= maxRow && j >= maxCol)
                    {
                        i = 4;
                        j = 4;
                    }    
                    else
                        summ +=arr[i, j];
                }
                minCol = 0;
            }
            Console.WriteLine($"Summ numbers between min amd max = {summ}");
        }
    }
}
