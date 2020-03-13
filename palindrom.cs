using System;

class Palindrome{
    public static void Main(String[] args){
        int num = 151;
        int rem, temp, rev;
        temp = num;
        rev = 0;
        while(num > 0){
            rem = num % 10;
            rev = rev * 10 + rem;
            num /= 10;
        }
        if(temp == rev){
            Console.WriteLine("Palindrome");
        }else{
            Console.WriteLine("Not Palindrome");
        }
    }
}