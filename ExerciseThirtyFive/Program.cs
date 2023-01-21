/*Задача 35: Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150]. 
Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5*/


// Создаем метод, который выводит массив с рандомными значениями от 0 до 150
int[] SetArray(int size, int left, int right)
{
    int[] userArray = new int[size];

    for (int i = 0; i < userArray.Length; i++)
    {
        userArray[i] = new Random().Next(0, 150);
    }
    return userArray;

}

//Создаем метод, который считает количество чисел в заданном диапазоне

int Even(int[] userArray)
{
    int result = 0;

    for (int i = 0; i < userArray.Length; i++)
    {
        int index = userArray[i];
        if (index >= 10 && index <= 99)
        {

            result = result + 1;
        }
    }
    return result;
}

const int size1 = 123; // Длина массива
const int left1 = 10; // левая граница диапазона
const int right1 = 99; // правая граница диапазона



int[] arrayOne = SetArray(size1, left1, right1);
int newEven = Even(arrayOne);

Console.WriteLine("Наш массив:");
Console.WriteLine(string.Join(", ", arrayOne));
Console.WriteLine($"В нашем массиве {newEven} чисел в отрезке от {left1} до {right1}");