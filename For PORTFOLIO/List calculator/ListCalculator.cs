using System;

class ListCalculator
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int user_number = -1;
        Console.WriteLine("---LIST CALCULATOR---")
        do {
            Console.Write("Enter a list of numbers, type 0 when finished: ");
            user_number = int.Parse(Console.ReadLine());

            if (user_number != 0)
            {
            numbers.Add(user_number);  
            }
        } while (user_number != 0);
        
        //COMPUTE SUM
        Console.WriteLine($"The sum is: {ComputeSum(numbers)}");

        //COMPUTE AVERAGE
        Console.WriteLine($"The average is: {ComputeAverage(numbers)}");

        //COMPUTE MAX
        Console.WriteLine($"The largest is: {ComputeLargest(numbers)}");
    }

    static float ComputeSum(List<int> numbers)
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        return sum;
    }
    static float ComputeAverage(List<int> numbers)
    {
        float average = ComputeSum(numbers) / numbers.Count;
        return average;
    }
    static float ComputeLargest(List<int> numbers)
    {
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        return max;
    }
}
