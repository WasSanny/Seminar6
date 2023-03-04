// Программа, которая принимает на вход три числа и проерет,
// может ли существовать треугольник с сторонами такой длинны!

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

void GetExamination(int a, int b, int c)
{
  if ((a < b + c) && (b < a + c) && (c < a + b))
  {
    Console.WriteLine("Треугольник с заданными парамерами может существовать!");
  }
  else
  {
    Console.WriteLine("Треугольника с заданными парамерами не существует!");
  }

}

int a = EnterNumber("a");
int b = EnterNumber("b");
int c = EnterNumber("c");

Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);

GetExamination(a, b, c);