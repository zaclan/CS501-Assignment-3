using BMI_Calculator_Revisited.BMI;

class Program
{
    // Helper method for the input loop getting valid input for every field
    // Action<string> setter field is the setter method to call when getting the input
    private static void GetValidInput(string prompt, Action<string> setter)
    {
        bool isValid = false;
        while (!isValid)
        {
            Console.WriteLine(prompt);

            try
            {
                setter(Console.ReadLine() ?? "");
                isValid = true;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    static void Main(string[] args)
    {

        BMI bmi = new BMI();

        Console.WriteLine("Welcome to the BMI Calculator Revisited App!");  // User input step
        GetValidInput("Enter your gender (m/f)", bmi.setGender);
        GetValidInput("Enter your height in inches", bmi.setHeight);
        GetValidInput("Enter your weight in pounds", bmi.setWeight);
        GetValidInput("Enter your age in years", bmi.setAge);

        Console.WriteLine($"Your BMI is {bmi.calculateBMI()}!");    // BMI calculation step
    }
}


