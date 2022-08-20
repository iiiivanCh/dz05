// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным
// элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

int[] array = GetArrayRandom(5, 0, 99);
Console.Write($"[{String.Join(", ", array)}]  -->  ");
Console.Write(GetArrayDeductMaxMin(array));

// Выводим массив заданной длины и в определенном диапазоне
int[] GetArrayRandom(int lengthArray, int minItem, int maxItem)
{
  int[] result = new int[lengthArray];
  for (int i = 0; i < lengthArray; i++)
    result[i] = new Random().Next(minItem, maxItem + 1);
  return result;
};

// Выводим разницу между максимальным и минимальным
// элементом массива на печать
int GetArrayDeductMaxMin(int[] arrayCalc)
{
  int max = arrayCalc[0];
  int min = arrayCalc[0];
  for (int i = 1; i < arrayCalc.Length; i++)
  {
    if (arrayCalc[i] > max)
      max = arrayCalc[i];
    if (arrayCalc[i] < min)
      min = arrayCalc[i];
  }
  int count = max - min;
  return count;
};
