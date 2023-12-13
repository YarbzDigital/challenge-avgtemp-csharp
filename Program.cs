public class Program
{
  public static void Main(string[] args)
  {
    // If no args are given, alert the user and exit the application
    if (args.Length == 0)
    {
      Console.WriteLine("Error: You must provide at least one temperature");
      Environment.Exit(1);
    }

    // Convert all of our input strings into floats so we can calculate
    // the average
    float[] temps = args.Select(tempString => 
    {
      // Check if we can parse the string as a float. If a valid string
      // is given/the parse succeeds, return the float
      if (float.TryParse(tempString, out float tempFloat))
      {
        return tempFloat;
      }

      // If the app fails to parse the given value as a float, alert the user
      // and exit the application
      Console.WriteLine($"Error: Could not parse '{tempString}' as float.");
      Environment.Exit(1);
      return 0f;

    }).ToArray();

    // Average is calculated by calculating the sum of all values, divided by the 
    // number of values.
    float average = temps.Sum() / temps.Count();

    // Alert the user.
    Console.WriteLine($"The average temperature was {average}");
  }
}