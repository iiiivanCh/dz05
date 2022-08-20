// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

int[] array = GetArrayRandom(10, 0, 9);
Console.Write($"[{String.Join(", ", array)}]  -->  ");
Console.Write(GetArraySumItemOddIndex(array));

// Выводим массив заданной длины и в определенном диапазоне
int[] GetArrayRandom(int lengthArray, int minItem, int maxItem)
{
  int[] result = new int[lengthArray];
  for (int i = 0; i < lengthArray; i++)
    result[i] = new Random().Next(minItem, maxItem + 1);
  return result;
};

// Выводим сумму элементов, стоящих на нечётных позициях на печать
int GetArraySumItemOddIndex(int[] arrayCalc)
{
  int count = 0;
  for (int i = 0; i < arrayCalc.Length; i++)
    if (i % 2 != 0)
    {
      count += arrayCalc[i];
      if (i == arrayCalc.Length - 1)
        Console.Write($"{arrayCalc[i]} = ");
      else
        Console.Write($"{arrayCalc[i]} + ");
    }
  return count;
};