// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.Clear();

int[] array = GetArrayRandom(5, 1, 10);
Console.Write($"[{String.Join(", ", array)}]  -->  ");
Console.Write($"[{String.Join(", ", GetArrayCouple(array))}]");

// Выводим массив заданной длины и в определенном диапазоне
int[] GetArrayRandom(int lengthArray, int minItem, int maxItem)
{
  int[] result = new int[lengthArray];
  for (int i = 0; i < lengthArray; i++)
    result[i] = new Random().Next(minItem, maxItem + 1);
  return result;
};

// Создание нового массива, на основе произведения пар
// чисел в одномерном массиве, согласно условию задачи
int[] GetArrayCouple(int[] arrayCalc)
{
  int[] result;
  if (arrayCalc.Length % 2 == 0)
  {
    result = new int[(arrayCalc.Length / 2)];
    for (int i = 0; i < arrayCalc.Length / 2; i++)
    {
      result[i] = arrayCalc[i] * arrayCalc[arrayCalc.Length - 1 - i];
    }
  }
  else
  {
    result = new int[(arrayCalc.Length / 2 + 1)];
    for (int i = 0; i <= arrayCalc.Length / 2; i++)
    {
      if (arrayCalc.Length / 2 == i)
      {
        result[i] = arrayCalc[i];
      }
      else
      {
        result[i] = arrayCalc[i] * arrayCalc[arrayCalc.Length - 1 - i];
      }
    }
  }
  return result;
}