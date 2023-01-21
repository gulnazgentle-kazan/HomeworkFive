/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

int[] SetArray(int size)
{
    int[] userArray = new int[size];

    for (int i = 0; i < userArray.Length; i++)
    {
        userArray[i] = new Random().Next(100, 1000);
    }
    return userArray;

}

int Even(int[] userArray)
{
    int result = 0;

    for (int i = 0; i < userArray.Length; i++)
    {
        int index = userArray[i];
        if (index % 2 == 0)
        {

            result = result + 1;
        }
    }
    return result;
}
Console.WriteLine("Задайте длину массива");
int size1 = Convert.ToInt32(Console.ReadLine());


int[] arrayOne = SetArray(size1);
int newEven = Even(arrayOne);

Console.WriteLine("Наш массив:");
Console.WriteLine(string.Join(" , ", arrayOne));
Console.WriteLine($"В нашем массиве {newEven} четных чисел");






