using System;

class SingleInheritance{
    public static void Main(String[] args){
        Employee employee = new Employee();
        employee.Get(10, "HR");
        employee.GetData(20, 300000, "Alice");
        employee.Put();
        employee.PutData();
    }
}
class Department{
    public int dno;
    public String dname;
    public void Get(int no, String name){
        dno = no;
        dname = name;
    }
    public void Put(){
        Console.WriteLine("Department no: " + dno);
        Console.WriteLine("Department name: " + dname);
    }
}
class Employee:Department{
    public int esal, eid;
    public String ename;
    public void GetData(int id, int sal, String name){
        esal = sal;
        eid = id;
        ename = name;
    }
    public void PutData(){
        Console.WriteLine("Employee id is: " + eid);
        Console.WriteLine("Employee salary is: " + esal);
        Console.WriteLine("Employee name is: " + ename);
    }
}