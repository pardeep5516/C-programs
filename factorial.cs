using System;

public class GFG{
    static public void Main (){
        int num = 6;
        int fact = 1;
        for(int i = 0; i <= num; i++){
            fact = fact * i;
        }
        Console.WriteLine("Factorial of number is: " + fact);
    }
}