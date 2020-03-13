using System;
class Reference{
    public static void Main(String[] args){
        int num1 = 10, num2 = 20;
        Console.WriteLine("Before Swap num1 = " + num1 + " num2 = " + num2);
        Swap(ref num1, ref num2); 
        Console.WriteLine("Before Swap num1 = " + num1 + " num2 = " + num2);
    }
    static void Swap(ref int num1, ref int num2){
        int temp;
        temp = num1;
        num1 = num2;
        num2 = temp;
    }    
}