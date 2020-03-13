using System;

class SquareAndCube{
    public static void Main(String[] args){
        int num = 2;
        Console.WriteLine("Square of Number is: " + Square(num));
        Console.WriteLine("Cube of Numebr is: " + Cube(num));
    }
    static int Square(int num){
        return num * num;
    }
    static int Cube(int num){
        return num * num * num;
    }
}