// Не имспользуя рекурсию, выведите первиые N чисел Фибоначчи!
// Первые два числа Фибоначчи 0 и 1.

int EnterNumber(string argument) // вводим число
{
  int num;

  Console.Write($"Введите число {argument}: ");

  while(!int.TryParse(Console.ReadLine(), out num))
  {
    Console.WriteLine("Вы ввели не целое число");
    Console.Write($"Повторите попытку! {argument}: ");
  }

  return num;
}


void Fibonacci(int num)
{
  int[] array = new int [num];

  if (num > 2)
  {
    array[0] = 0;
    array[1] = 1;

    for (int i = 2; i < num; i++)
    {
      array[i] = array[i - 2] + array[i - 1];
    }
    Console.WriteLine(string.Join(" ", array));
  }
  else
  {
    Console.WriteLine("Введите число больше 2");
  }

}

Fibonacci(EnterNumber(""));