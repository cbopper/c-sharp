using System;

public class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Please select a snack:\n1: Wispa\n2: Walkers Ready Salted\n3: Curly Worly\n4:DairyMilk MiniChocolate bar\n\nNumber:");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch(choice)
        {
            case 1:
                Console.WriteLine("Enjoy your Wispa!");
                break;
            case 2:
                Console.WriteLine("Enjoy your Walkers Ready Salted!");
                break;
            case 3:
                Console.WriteLine("Enjoy your Curly Worly!");
                break;
            case 4:
                Console.WriteLine("Enjoy your DairyMilk MiniChocolate bar!");
                break;
            default:
                Console.WriteLine("That is not an option. Choose one or die.");
                break;

        }
    }
}
