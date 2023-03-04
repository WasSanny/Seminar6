// Программа, которая перевернет одномерный массив
//(1-й элемент на последний, последний на первый)

int[] array = new int[5];
RandomArr(array);
Console.WriteLine(string.Join(" ", array));

Switch(array);
Console.WriteLine(string.Join(" ", array));

void RandomArr(int [] array)
{
  Random random = new Random(); // объект генератора чисел

  for(int i = 0; i < array.Length; i++)
  {
    array[i] = random.Next(); // массив заполненслучайными значениями
  }

}

void Switch(int [] array) // переворачиваем массив
{
  int a = 0; // объявляем доп переменную для переворота масиива

  for (int i = 0; i < array.Length/2; i++)
  {
    a = array[i];
    array[i] = array[array.Length -1 - i];
    array[array.Length -1 - i] = a;
  }

}
