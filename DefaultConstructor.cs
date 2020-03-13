using System;

class DefaultConstructor{
    public static void Main(String[] args){
        Employee employee = new Employee();
        employee.Put();
    }
}
class Employee{
    public int id, salary;
    String name;
    public Employee(){
        id = 1;
        salary = 20000;
        name = "Alice";
    }
    public void Put(){
        Console.WriteLine("Employee id: " + id);
        Console.WriteLine("Employee salary: " + salary);
        Console.WriteLine("Employee name: " + name);
    }
}