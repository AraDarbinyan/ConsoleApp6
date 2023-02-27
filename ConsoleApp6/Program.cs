//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2
int[] RandPosNum()
{
    int[] RandPos = new int[4];
    for (int i = 0; i < RandPos.Length; i++)
    {
        RandPos[i] = Random.Shared.Next(100, 1000);
    }
    return RandPos;
}
int NumbOfPosNum(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i]%2 ==0)
        {
            count++;
        }
    }
    return count;
}
int[] ints = RandPosNum();
Console.WriteLine($"[{string.Join(", ", ints)}]");
Console.WriteLine(NumbOfPosNum(ints));

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6]-> 0
int[] RandNum()
{
    int[] RandNums = new int[4];
    for (int i = 0; i<RandNums.Length; i++)
    {
        RandNums[i] = Random.Shared.Next();
    }
    return RandNums;
}
int sumofelements(int[] array)
{
    int sum = 0;
    for(int i = 0; i<array.Length;i++)
    {
        if (array[i]%2 ==1) {
        sum =sum + array[i];
        }
    }
    return sum;
}
int[] ints1= RandNum();
Console.WriteLine($"[{string.Join(", ", ints1)}]");
Console.WriteLine(sumofelements(ints1));
//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76
double MaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];
    for(int i = 0; i<array.Length;i++)
    {
        if (max < array[i])
        {
             max = array[i];
        }
        if (min > array[i])
        {
            min = array[i];
        }
    }
    return (max - min);
}
double[] ints2 = { 1233.4, 65, 2244.99, 5, 59};
Console.WriteLine($"[{string.Join(", ", ints2)}]");
Console.WriteLine(MaxMin(ints2));