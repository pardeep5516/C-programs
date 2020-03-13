using System;
class ParametrizedConstructor{
    public static void Main(String[] args){
        Employee employee1 = new Employee(1, 20000, "alice");
        Employee employee2 = new Employee(2, 30000, "max");
        employee1.Put();
        employee2.Put();
    }
}
class Employee{
    public int id, salary;
    String name;
    public Employee(int eid, int esalary, String ename){
        id = eid;
        salary = esalary;
        name = ename;
    }
    public void Put(){
        Console.WriteLine("Employee id is: " + id);
        Console.WriteLine("Employee salary is: " + salary);
        Console.WriteLine("Employee name is: " + name);
    }
}