public class Sorting
{
    Random random = new Random(4711);
    int[] numbers;
    //double[] averageDistances;
    public int minimum, maximum;
    double solution;

    public Sorting(int sizeOfNumbers, int maxValue)
    {
        numbers = new int[sizeOfNumbers];
        for (int i = 0; i < sizeOfNumbers; i++)
        {
            numbers[i] = random.Next(1, maxValue + 1);
        }

        //Sort();
    }
    /*private void Sort()
    {
        for (int j = 0; j < numbers.Length; j++)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i + 1]) { var help = numbers[i + 1]; numbers[i + 1] = numbers[i]; numbers[i] = help; }
            }
        }
    }*/ 
    /*  averageDistances = new double[numbers.Length - 1];
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            averageDistances[i] = numbers[i + 1] - numbers[i];
        }
        for (int j = 0; j < averageDistances.Length; j++)
        {
            solution += averageDistances[j];
        }
        solution = solution / averageDistances.Length;
        return solution;*/
    public double Calculate ()
    {
        minimum = numbers.Min();
        maximum = numbers.Max();
        double distance = maximum - minimum;

       solution = distance / (numbers.Length - 1);
       return solution;
    }
}