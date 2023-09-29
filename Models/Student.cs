 namespace NewApp.Models
 {
 public class Students  {
        public string Name {get;set;}
        public string Address {get; set;}
        public string StudentID {get; set;}
        
        
    // tran thi mai anh -2021050093
    // phuong co gia tri tra ve-student
        public Students ()
        {
            Name = "ho ten cua ban";
            Address ="Ha Noi";
            StudentID ="2021050637";
        }
        public int GetYearOfBirth(int age)
    {
        int yearOfBirth = 2023-age;
        return yearOfBirth;
    }