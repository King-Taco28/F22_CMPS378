using System;
public class Program
{
    static void Main(string[] args)
    {
        //The prices of gas
        System.Console.WriteLine("Regular(R)................$3.95");
        System.Console.WriteLine("Midgrade(M)...............$4.15");
        System.Console.WriteLine("Premium(P)................$4.35");
        System.Console.WriteLine("Diesel(D).................$4.05");
        double Rgas=3.95;
        double Mgas=4.15;
        double Pgas=4.35;
        double Dgas=4.05;

        Console.Write("Enter gas type (R/M/P/D): ");
        char gasC = Console.ReadLine().ToUpper()[0];

        Console.Write("Enter amount of gas in gallons: ");
        double gasa = Convert.ToDouble(Console.ReadLine());

        double subtotal =0;
        if(gasC== 'R'|| gasC== 'r')
        {subtotal= gasa*Rgas;}

        else if(gasC== 'M'|| gasC== 'm')
        {subtotal= gasa*Mgas;}

        else if(gasC== 'P'|| gasC== 'p')
        {subtotal= gasa*Pgas;}

        else
        {subtotal= gasa*Dgas;}

        double tax= subtotal*0.0725; 
        double Finaltotal= tax+subtotal;

        System.Console.WriteLine("Subtotal: " + subtotal); 
        System.Console.WriteLine("Sales Tax: " + tax); 
        System.Console.WriteLine("Final total: " + Finaltotal); 
    }
}