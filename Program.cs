/*
// Задача: Программа выбирает из двух чисел большее и меньшее

int a;
int b;

// Ввод данных
Console.Write("Введите первое число: ");
a=Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
b=Convert.ToInt32(Console.ReadLine());

// Условие
int max=a;

if (a>max) max=a;
if (b>max) max=b;

// Вывод решения
Console.WriteLine("max=" );
Console.WriteLine(max);

*/

/*
//Задача: Программа выбирает максимальное из трех чисел

int a;
int b;
int c;

// Ввод данных
Console.Write("Введите первое число: ");
a=Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
b=Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
c=Convert.ToInt32(Console.ReadLine());

// Условие
int max=a;

if (a>max) max=a;
if (b>max) max=b;
if (c>max) max=c;

// Вывод решения
Console.WriteLine("max=" );
Console.WriteLine(max);

*/


/*
///Задача: Программа определяет число четное или нет

int num;

// Ввод данных
Console.Write("Введите число: ");
num=Convert.ToInt32(Console.ReadLine());

//Условие
if (num % 2 == 0)
            {
                Console.WriteLine("четное число");
           
            }

else if (num % 2 == 1)
            {
                Console.WriteLine("нечетное число");
           
            }
*/


//Задача: Программа определяет все четные от 1 до N

int N;

// Ввод данных
Console.Write("Введите число: ");
N=Convert.ToInt32(Console.ReadLine());

//Цикл на четное число
int current = 1;
while(current<=N)
{
    if (current % 2 == 0)
    {
    Console.Write(current + " ");
    }
    current++;
}

