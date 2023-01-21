/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0*/

// Создаем метод, который выводит массив с рандомными значениями
int[] SetArray(int size)
{
    int[] userArray = new int[size];

    for (int i = 0; i < userArray.Length; i++)
    {
        userArray[i] = new Random().Next(100, 1000);
    }
    return userArray;

}

//Создаем метод, который считает сумму элементов нечетных чисел
int Even(int[] userArray)
{
    int result = 0;

    for (int i = 0; i < userArray.Length; i++)
    {
        int index = userArray[i];
        if (index % 2 != 0)
        {

            result = result + index;
        }
    }
    return result;
}
Console.WriteLine("Задайте длину массива");
int size1 = Convert.ToInt32(Console.ReadLine());


int[] arrayOne = SetArray(size1);
int newEven = Even(arrayOne);

Console.WriteLine("Наш массив:");
Console.WriteLine(string.Join(", ", arrayOne));
Console.WriteLine($"Сумма нечетных элементов равна {newEven}");