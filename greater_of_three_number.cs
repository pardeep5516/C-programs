using System;

public class GFG{
    static public void Main (){
        int a, b, c;
        a = 20;
        b = 10;
        c = 30;
        if(a > b){
            if(a > c){
                Console.WriteLine("A is greater ");
            }else{
                Console.WriteLine("C is greater ");
            }
        }else{
            if(b > c){
                Console.WriteLine("B is greater ");
            }else{
                Console.WriteLine("C is greater ");
            }
        }
    }
}