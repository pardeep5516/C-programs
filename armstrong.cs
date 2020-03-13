using System;

class ArmStrong{
    public static void Main(String[] args){
        int num = 151;
        int temp, rem, sum = 0;
        temp = num;
        while(num > 0){
            rem = num % 10;
            sum += rem * rem * rem;
            num /= 10;
        }
        if(temp == sum){
            Console.WriteLine("True");
        }else{
            Console.WriteLine("False");
        }
    }
}