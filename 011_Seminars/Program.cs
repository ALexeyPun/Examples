// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

string NewNumber(int num)
{
    string binary = string.Empty;
    for(; num > 0; num/=2)
    {
        binary += num % 2;
    }
    return FlipOver(binary);
}

string FlipOver(string binary)
{
    string result = string.Empty;
    for(int i = binary.Length-1; i >= 0; i--)
    {
        result += binary[i];
    }
    return result;
}

System.Console.Write("Введите десятичное число: ");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(NewNumber(num));

// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

string Fibonacci(int N)
{
    int one = 0;
    int two = 1;
    string answer = one + ", " + two;

    for(int i = 0; i < N; i++)
    {
        int temp = 0;
        temp = one;
        one = two;
        two += temp;
        answer += ", " + two;
    }
    return answer;
}

int N = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(Fibonacci(N));


// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int InputSize(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[] array)
{
    Random rnd = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(1,10);
    }
}

int[] CopyArray(int[] array)
{
    int[] arrayCopy = new int[array.Length];
    for(int i = 0; i < array.Length; i++)
    {
        arrayCopy[i] = array[i];
    }
    return arrayCopy;
}

int size = InputSize("Введите размер массива: ");
int[] array = new int[size];
FillArray(array);
// int[] array2 = array;    //ссылка array2 на array
System.Console.WriteLine(String.Join(", ", array));
int[] array2 = CopyArray(array);
array[0] = 43;
System.Console.WriteLine(String.Join(", ", array2));