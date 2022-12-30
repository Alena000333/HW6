// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int[] Numbers (int size)
{
int[] myArray = new int[size];
for(int i=0;i<size;i++)
{
Console.WriteLine($"Введите {i+1} число ");
myArray[i] = Convert.ToInt32(Console.ReadLine());
}
return myArray;
}

Console.WriteLine("Введите количество чисел:");
int M = Convert.ToInt32(Console.ReadLine());


int CountSpecific(int[] arr)
{
int count=0;
for(int i = 0; i < arr.Length; i++)
{
if(arr[i]>0)
{
count++;
}
else
{
count+=0;
}
}
return count;
}

int result = CountSpecific( Numbers (M));
Console.WriteLine($"{result} чисел больше 0 ввёл пользователь ");