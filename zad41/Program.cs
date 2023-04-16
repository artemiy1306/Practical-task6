// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Введите М чисел через пробел");
string[] nums = Console.ReadLine().Split(" ");

int NumberOfPositiveNumbers(string[] nums)
{  
int[] arr = Array.ConvertAll(nums, int.Parse);
  int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
     if (arr[i] > 0) count++;   
    }
    return count;
}   
int count = NumberOfPositiveNumbers(nums);
Console.WriteLine($"Кол-во элементов > 0: {count}");
