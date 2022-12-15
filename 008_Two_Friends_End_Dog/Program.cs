Console.Clear();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Задача из первой лекции.");

Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.DarkYellow;

Console.WriteLine("Существуют некие 2 друга и собака. Друзья движутся навстречу друг к другу.");
Console.WriteLine("Вместе с первым другом начинает движение собака. Найти:");
Console.WriteLine("сколько раз собака перебежит от одного друга к другому,");
Console.WriteLine("если известны скорости и расстояние между друзьями.");

Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("ВНИМАНИЕ: СКОРОСТИ НЕОБХОДИМО СТАВИТЬ ВЫШЕ 0, \r\n ТАКЖЕ СКОРОСТЬ СОБАКИ ДОЛЖНА БЫТЬ ВЫШЕ СОРОСТЕЙ ДРУЗЕЙ \r\n ИАЧЕ ПРОГРАММА СЛОМАЕТСЯ =)");

Console.ResetColor();

Console.Write("Введите скорость первого друга:");
int speedFirstFriend = Int32.Parse(Console.ReadLine());

Console.Write("Введите скорость второго друга:");
int speedSecondFriend = Int32.Parse(Console.ReadLine());

Console.Write("Введите скорость собаки:");
int speedDog = Int32.Parse(Console.ReadLine());

Console.Write("Введите расстояние:");
int distance = Int32.Parse(Console.ReadLine());

int count = 0;
int friend = 2;
int time = 0;


while( distance > 10 )
{

if( friend == 1) 
{
    time = distance/(speedFirstFriend + speedDog);
    friend = 2;
}
else
{
    time = distance/(speedSecondFriend + speedDog);
    friend = 1;
}

distance = distance - (speedFirstFriend + speedSecondFriend) * time;
count++;

}



Console.WriteLine("Собака пробежит " + count + " раз");