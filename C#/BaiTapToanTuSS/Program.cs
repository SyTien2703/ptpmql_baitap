
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("So sanh 2 so:");
        Console.WriteLine("Nhap so thu nhat: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap so thu hai: ");
        int b = Convert.ToInt32(Console.ReadLine());
        if (a > b)
        {
            Console.WriteLine("So thu nhat lon hon so thu hai.");
        }
        //Nguyễn Sỹ Tiến - 2021050637
        else if (a < b)
        {
            Console.WriteLine("So thu nhat nho hon so thu hai.");
        }
        else
        {
            Console.WriteLine("Hai so bang nhau");
        }
    }
}