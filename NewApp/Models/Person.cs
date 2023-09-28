using System.Runtime.Intrinsics.Arm;
using NewApp.Models;

//nguyen sy tien - 2021050637

public class Person
{
    public static void Main(string[]args)
    {
    
     
    Student std = new Student();
    std.NhapThongTin();
    std.StudentCode = "12345678";
    std.HienThi();
    
    }
}
