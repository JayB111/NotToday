// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    
    public static double Calculate(string operation, double num1, double num2)
    {
        switch (operation)
        {
            case "add":         
                return num1 + num2;
            case "subtract":    
                return num1 - num2;
            case "multiply":    
                return num1 * num2;
            case "divide":      
                if (num2 != 0)  
                {
                    return num1 / num2;
                }
                else
                {
                    Console.WriteLine("Where did my logic go?");
                    return 0;
                }
            default:            
                Console.WriteLine("I really want to understand Gebberish!!! urrggg");
                return 0;
        }
    }

    
    static void Main(string[] args)
    {
        Console.WriteLine(Calculate("add", 10, 5));        
        Console.WriteLine(Calculate("subtract", 10, 5));   
        Console.WriteLine(Calculate("multiply", 10, 5));   
        Console.WriteLine(Calculate("divide", 10, 5));     
        Console.WriteLine(Calculate("divide", 10, 0));     
        Console.WriteLine(Calculate("modulus", 10, 5));    

        Console.ReadKey(); 
    }
}