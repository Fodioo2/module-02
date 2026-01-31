using System;

public class Class1
{
    public void PrintPositiveNumbers(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            return;

        foreach (int number in numbers)
        {
            if (number > 0)
                Console.WriteLine(number);
        }
    }
}