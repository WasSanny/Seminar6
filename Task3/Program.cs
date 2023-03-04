// Программа, которая будет преобразовывать десятичное число в двоичное!

int EnterNumber(string argument)
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

string GetTransform (int dec)
{
  string binn = "";

  while(dec > 0)
  {
    binn = dec % 2 + binn;
    dec = dec / 2; // dec /= 2
  }
  Console.WriteLine(binn);
  return binn;
}

GetTransform(EnterNumber(""));
