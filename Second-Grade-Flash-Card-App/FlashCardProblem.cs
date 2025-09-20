namespace FlashCardProblem;

internal class FlashCardProblem
{
    // CONSTANTS
    private const int MIN_NUMBER = 0;
    private const int MAX_NUMBER = 12;
    private static readonly Random RANDOM = new Random();
    private static readonly char[] ALLOWED_OPERATIONS = { '+', '-', '*', '/' };


    // FIELDS
    private int firstNumber;
    private int secondNumber;
    private char operation;
    private int solution;
    private int attempt;

    public FlashCardProblem()
    {
        operation = ALLOWED_OPERATIONS[RANDOM.Next(0, ALLOWED_OPERATIONS.Length)];
        attempt = 1;
        setProblemAndSolutionByOperation();
    }

    private void setProblemAndSolutionByOperation()
    {
        switch (operation)
        {
            case '-':
                // - case: first number must always be >= second number
                firstNumber = RANDOM.Next(MIN_NUMBER, MAX_NUMBER);
                secondNumber = RANDOM.Next(MIN_NUMBER, firstNumber);
                solution = firstNumber - secondNumber;
                break;
            case '/':
                // / case: must be divisible and denominator cannot be 0
                int a = RANDOM.Next(1, MAX_NUMBER);
                int b = RANDOM.Next(1, MAX_NUMBER);

                // dividend is the multiple of the 2 random numbers between 0 and 12
                // randomly choose which number is the divisor
                firstNumber = a * b;
                secondNumber = RANDOM.Next(0, 2) == 0 ? a : b;
                solution = secondNumber == a ? b : a;
                break;
            default:
                // + or * case: there are no restrictions
                firstNumber = RANDOM.Next(MIN_NUMBER, MAX_NUMBER);
                secondNumber = RANDOM.Next(MIN_NUMBER, MAX_NUMBER);
                solution = operation == '+' ? firstNumber + secondNumber : firstNumber * secondNumber;
                break;
        }
    }

    // ACCESSORS
    public int getFirstNumber() { return  firstNumber; }
    public int getSecondNumber() { return secondNumber; }
    public int getSolution() { return solution; }
    public char getOperation() { return operation; }
    public int getAttempt() { return attempt; }

    // METHODS
    public bool validateSolution(int solution)
    {
        attempt += 1;
        return solution == this.solution;
    }
}
