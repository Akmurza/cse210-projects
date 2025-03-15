using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        List<int>numbers=new List<int>();
        int numberNoZero=1;
        while(numberNoZero !=0){
            Console.WriteLine("insert any number, until you want to quit, to quit insert zero");
            string usersNumber = Console.ReadLine();
            numberNoZero = int.Parse(usersNumber);
            if (numberNoZero!=0){
                numbers.Add(numberNoZero);
            }

        }


        int computedNumbers = 0;
        foreach (int number in numbers)
        {
            computedNumbers+=number;
        }
        Console.WriteLine($"The sum is: {computedNumbers}");


        double averageValue = ((double)computedNumbers) /numbers.Count;
        Console.WriteLine($"The average in the List is: {averageValue}");





        int maximumValue = numbers[0];

        foreach (int number in numbers)
        {
            if (number > maximumValue)
            {
                
                maximumValue = number;
            }
        }
        Console.WriteLine($"the maximum value in the list is: {maximumValue}");








      
        


    }
}