/*Задача 38: Задайте массив натуральных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

// Создаем метод, который выводит массив с рандомными значениями
int[] SetArray(int size)
{
    int[] userArray = new int[size];

    for (int i = 0; i < userArray.Length; i++)
    {
        userArray[i] = new Random().Next();
    }
    return userArray;

}

//Создаем метод, который считает сумму элементов нечетных чисел
int Even(int[] userArray)
{
    int min = userArray[0]; // переменная, хранящая минимальное значение
    int max = userArray[0];// переменная, хранящая максимальное значение
    int result = 0; //переменная, хранящая разницу между максимальным и минимальным элементами

    for (int i = 0; i < userArray.Length; i++)
    {
        int index = userArray[i];

        if (index < min)
        {
            min = index;
        }
        else if (index > max)
        {
            max = index;
        }
        result = max - min;
    }
    return result;
}
Console.WriteLine("Задайте длину массива");
int size1 = Convert.ToInt32(Console.ReadLine());


int[] arrayOne = SetArray(size1);
int newEven = Even(arrayOne);

Console.WriteLine("Наш массив:");
Console.WriteLine(string.Join(", ", arrayOne));
Console.WriteLine($"Разница между максимальным и минимальным элементов массива равна {newEven}");