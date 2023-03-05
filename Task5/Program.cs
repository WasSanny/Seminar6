// Написать программу, которая будет создавать копию заданного массива
// с помощью поэлементного копирования.

int[] arr = RandomArr(10, 0, 100);
PrintNumber(arr);
PrintNumber(CopyArray(arr));

int[] RandomArr(int length, int min, int max) // массив случайных чисел 
{
  int[] array = new int [length];
  Random random = new Random(); // объект генератора чисел

  for(int i = 0; i < length; i++)
  {
    array[i] = random.Next(min, max + 1); // массив заполненслучайными значениями
  }
 
  return array;
}

int[] CopyArray(int[] array)
{
  int[] newArray = new int[array.Length]; // создали новый массив той же длинны 

  for (int i = 0; i < array.Length; i++)
  {
    newArray[i] = array[i];
  }

  return newArray;
}

void PrintNumber(int[] array) // выводим массив на консоль
{
  Console.WriteLine(string.Join(", ", arr));
}

