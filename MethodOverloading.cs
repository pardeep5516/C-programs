using System;

class MethodOverloading{
    double areaOfCircle, areaOfRectangle; 
    public static void Main(String[] args){
        int radius = 5, lenght = 5, breath = 7;
        MethodOverloading obj = new MethodOverloading();
        obj.area(radius);
        obj.area(lenght, breath);
    }
    public void area(int r){
        areaOfCircle = 3.14 * r * r;
        Console.WriteLine("Area of Circle is: " + areaOfCircle); 
    }
    public void area(int l, int b){
        areaOfRectangle = l * b;
        Console.WriteLine("Area of Rectangle is: " + areaOfRectangle);
    }

}