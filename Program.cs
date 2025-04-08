using System;
using System.Globalization;

class Program{
    static void Main(string[] args){

        Console.WriteLine("Digite um num: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite outro num: ");
        int num2 = int.Parse(Console.ReadLine());

        if(num1 > num2){
            Console.WriteLine(num1 + ">" + num2);
        }else{
            Console.WriteLine(num2 + " > " + num1);
        }

        }
}