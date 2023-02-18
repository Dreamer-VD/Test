try
{
Console.WriteLine("Введите a");
double a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b");
double b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите c");
double c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("a={0},b={1},c={2}",a,b,c);
double x1, x2;
double d = Math.Pow(b, 2) - 4 * a * c;
    if (d < 0)
{
        Console.WriteLine("********");
}
else
{
    if (d > 0)
    {
        Console.WriteLine("D={0}",d);
        x1 = (-b + Math.Sqrt(d)) / (2 * a);
        x2 = (-b - Math.Sqrt(d)) / (2 * a);
        Console.WriteLine("X1={0:F1} и X2={1:F1}", x1, x2);
    }
    if (d == 0)
    {
        x1 = b / (2 * a);
        x2 = x1;
        if (x2==0)
        {
            Console.WriteLine("D={0}", d);
            x2 = Math.Abs(x2);
            Console.WriteLine("X={0:F1}", x2);
        }
        else
        {
                Console.WriteLine("D={0}", d);
                Console.WriteLine("X={0:F1}", x2);
        }
    }
}
Console.WriteLine("Для выхода нажмите любую клавишу...");
Console.ReadKey(true);
}
catch (Exception e)
{
    Console.WriteLine("ОШИБКА В ВВОДЕ! Повторите попытку");
}
