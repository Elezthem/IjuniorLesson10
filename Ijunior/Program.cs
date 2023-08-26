bool thimble1 = false;
bool thimble2 = false;
bool thimble3 = true;

Console.WriteLine("Игра в наперстки");
Console.WriteLine();
Console.WriteLine("под одним из трех наперстков находится шарик. Попробуйте угадать в каком!");
Console.WriteLine();
Console.Write("Введите ваше число от 1 до 3: ");
int input = Convert.ToInt32(Console.ReadLine());

bool result = false;

switch (input) { case 1: result = thimble1; break; case 2: result = thimble2; break; case 3: result = thimble3; break; }

if (result == true)
{
    Console.WriteLine("Да! Вы нашли шарик!");
}
else
{
    Console.WriteLine("Нет! Вы не угадали!");
}