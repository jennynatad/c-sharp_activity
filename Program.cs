using System; 


  
public class Program
{ 
    public static void Main()
    {
    
    
        Console.WriteLine("Input no. of days:" );
        int number_of_days = Convert.ToInt32(Console.ReadLine());

        int year = number_of_days / 365 ;
        Console.WriteLine(number_of_days / 365 + " Year(s)");

        number_of_days = number_of_days-(365*year);

        int month = number_of_days / 30;
        Console.WriteLine(number_of_days / 30 + " Month(s)");

        Console.WriteLine(number_of_days - (month * 30) + " Day(s)");


        
    }

}