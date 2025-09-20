using FlashCardProblem;

namespace Second_Grade_Flash_Card_App;

public partial class Form1 : Form
{
    // CONSTANTS
    private const int MAX_ATTEMPTS = 3;
    private const int MAX_PROBLEMS = 10;

    // PRIVATE FIELDS FOR STATE
    private FlashCardProblem.FlashCardProblem currentProblem;
    private int problemNumber;
    private int numCorrect;
    public Form1()
    {
        InitializeComponent();
        currentProblem = new FlashCardProblem.FlashCardProblem();
        problemNumber = 1;
        numCorrect = 0;
    }

    private void btnSubmitAnswer_Click(object sender, EventArgs e)
    {
        if (int.TryParse(tbAnswerInput.Text, out int userSolution))
        {
            lbInvalidInput.Visible = false;

            if (currentProblem.validateSolution(userSolution))
            {
                lbSubmissionStatus.Text = "Correct!";
                numCorrect++;
                btnContinue.Visible = true;
                tbAnswerInput.Enabled = false;
            }
            else if (currentProblem.getAttempt() <= MAX_ATTEMPTS)
            {
                lbSubmissionStatus.Text = $"Incorrect, try again ({MAX_ATTEMPTS + 1 - currentProblem.getAttempt()} attempts remaining)";
                lbTryNumber.Text = $"Attempt #{currentProblem.getAttempt().ToString()}";
            }
            else
            {
                lbSubmissionStatus.Text = "Out of attempts. Lets try something different!";
                btnContinue.Visible = true;
                tbAnswerInput.Enabled = false;
            }
        }
        else
        {
            // Parsing failed, input was not a valid integer
            lbInvalidInput.Text = "Please enter a valid integer";
            lbInvalidInput.Visible = true;
        }

        tbAnswerInput.Text = ""; // reset input
    }

    private void setupNewProblem()
    {
        // generate new problem and populate all labels
        currentProblem = new FlashCardProblem.FlashCardProblem();
        lbNumberOne.Text = currentProblem.getFirstNumber().ToString();
        lbNumberTwo.Text = currentProblem.getSecondNumber().ToString();
        lbOperator.Text = currentProblem.getOperation().ToString();
        lbTryNumber.Text = $"Attempt #{currentProblem.getAttempt()}";
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        setupNewProblem();
        lbProblemNumber.Text = $"Problem #{problemNumber}";
    }

    private void btnContinue_Click(object sender, EventArgs e)
    {
        btnContinue.Visible = false;
        lbSubmissionStatus.Text = "";
        tbAnswerInput.Enabled = true;
        problemNumber++;

        if (problemNumber <= MAX_PROBLEMS)
        {
            setupNewProblem();
            lbProblemNumber.Text = $"Problem #{problemNumber.ToString()}";
        }
        else
        {
            // set all items on the first page as not visible
            lbNumberOne.Visible = false;
            lbNumberTwo.Visible = false;
            lbOperator.Visible = false;
            lbTryNumber.Visible = false;
            lbProblemNumber.Visible = false;
            lbSubmissionStatus.Visible = false;
            lbEnterAnswer.Visible = false;
            tbAnswerInput.Visible = false;
            btnSubmitAnswer.Visible = false;
            btnContinue.Visible = false;

            // set the score page as visible
            lbScoreText.Visible = true;
            lbScoreValue.Text = $"{(int)(((double)numCorrect / MAX_PROBLEMS) * 100)}%";
            lbScoreValue.Visible = true;
            btnRetry.Visible = true;
        }
    }

    private void btnRetry_Click(object sender, EventArgs e)
    {
        // set the score page as not visible
        lbScoreText.Visible = false;
        lbScoreValue.Visible = false;
        btnRetry.Visible = false;

        // reset state
        currentProblem = new FlashCardProblem.FlashCardProblem();
        problemNumber = 1;
        numCorrect = 0;
        setupNewProblem();
        lbProblemNumber.Text = $"Problem #{problemNumber}";

        // set all items on the first page as visible
        lbNumberOne.Visible = true;
        lbNumberTwo.Visible = true;
        lbOperator.Visible = true;
        lbTryNumber.Visible = true;
        lbProblemNumber.Visible = true;
        lbSubmissionStatus.Visible = true;
        lbEnterAnswer.Visible = true;
        tbAnswerInput.Visible = true;
        btnSubmitAnswer.Visible = true;
        btnContinue.Visible = true;
    }
}
