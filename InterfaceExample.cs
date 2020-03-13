using Syatem;
class InterfaceExample{
    public static void Main(String[] args){
        Result result = new Result();
        result.getmarks();
        result.getSport();
        result.calculate();
    }
}
interface student{
    void getmarks();
}
interface sport{
    void getSport();
}
class Result:student, sport{
    public int m1, m2, m3, total, sport;
    public void getmarks(){
        Console.WriteLine("Enter Marks of 3 Student");
        m1 = Convert.ToInt32(Console.ReadLine());
        m2 = Convert.ToInt32(Console.ReadLine());
        m3 = Convert.ToInt32(Console.ReadLine());
    }
    double avg;
    public void getSport(){
        Console.WriteLine("Enter Marks of Sports");
        sport = Convert.ToInt32(Console.ReadLine());
    }
    public void calculate(){
        total = m1 + m2 + m3 + sport;
        avg = total / 4.0;
        Console.WriteLine("total: " + total);
        Console.WriteLine("avg: " + avg);
    }
}