namespace Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Хоть бы вышло");
            Console.WriteLine("Введите число больше 5, но меньше 100");
            int a = Convert.ToInt32(Console.ReadLine());
            string str = "a > 5 - " + Convert.ToString(a > 5) + " & a < 100 - " + Convert.ToString(a < 100);
            Console.WriteLine(str);
        }
    }
}