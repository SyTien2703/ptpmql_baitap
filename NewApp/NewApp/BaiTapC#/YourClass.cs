namespace Newapp.YourClass
{
    public class YourClass
    {
        public string Fullname {get; set;}

        public string Address {get; set;}

 public void EnterData()

    {
        System.Console.Write ("Full name = ");
        FullName = Consol. ReadLine();
        System.Console.Write ("Address = ");
        Address = Consol. ReadLine();
        
    }
    public void Display()
    {
        System.Console.WriteLine ("{0}" - {1}, FullName, Address);
    }
    }
}