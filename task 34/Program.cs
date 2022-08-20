// Задача 34: Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();

int[] array = GetArrayRandom(10, 100, 999);
Console.Write($"[{String.Join(", ", array)}]  -->  ");
Console.Write(GetArrayEvenItem(array));

// Выводим массив заданной длины и в определенном диапазоне
int[] GetArrayRandom(int lengthArray, int minItem, int maxItem)
{
  int[] result = new int[lengthArray];
  for (int i = 0; i < lengthArray; i++)
    result[i] = new Random().Next(minItem, maxItem + 1);
  return result;
};

// Выводим количество четных чисел массива на печать
int GetArrayEvenItem(int[] arrayCalc)
{
  int count = 0;
  for (int i = 0; i < arrayCalc.Length; i++)
    if (arrayCalc[i] % 2 == 0)
      count++;
  return count;
};
