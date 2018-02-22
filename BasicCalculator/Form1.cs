using System;
using System.Linq;
using System.Windows.Forms;

namespace BasicCalculator
{
    /// <summary>
    /// A basic calculator
    /// </summary>
    public partial class Form1 : Form
    {
        #region Constructor

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        #endregion

        #region Clearing Methods
        /// <summary>
        /// Clears the user input text
        /// </summary>
        /// <param name="sender">The event sender </param>
        /// <param name="e">The event arguments</param>
        private void buttonCE_Click(object sender, EventArgs e)
        {
            //Clears the text from the user input text box
            this.UserInputText.Text = string.Empty;

            //Focus the user input text
            FocusInputText();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteTextValue();

            //Focus the user input text
            FocusInputText();
        }

        #endregion

        #region Operator Methods    

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            InsertTextValue("/");

            //Focus the user input text
            FocusInputText();
        }

        private void buttonTimes_Click(object sender, EventArgs e)
        {
            InsertTextValue("*");

            //Focus the user input text
            FocusInputText();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            InsertTextValue("-");

            //Focus the user input text
            FocusInputText();
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            InsertTextValue("+");

            //Focus the user input text
            FocusInputText();
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            CalculateEquation();
        }

        #endregion

        #region Number Methods

        private void buttonDot_Click(object sender, EventArgs e)
        {
            InsertTextValue(".");

            //Focus the user input text
            FocusInputText();
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            InsertTextValue("9");

            //Focus the user input text
            FocusInputText();
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            InsertTextValue("8");

            //Focus the user input text
            FocusInputText();
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            InsertTextValue("7");

            //Focus the user input text
            FocusInputText();
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            InsertTextValue("6");

            //Focus the user input text
            FocusInputText();
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            InsertTextValue("5");

            //Focus the user input text
            FocusInputText();
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            InsertTextValue("4");

            //Focus the user input text
            FocusInputText();
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            InsertTextValue("3");

            //Focus the user input text
            FocusInputText();
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            InsertTextValue("2");

            //Focus the user input text
            FocusInputText();
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            InsertTextValue("1");

            //Focus the user input text
            FocusInputText();
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            InsertTextValue("0");

            //Focus the user input text
            FocusInputText();
        }

        #endregion

        /// <summary>
        /// Evaluates the given operation and returns the answer to the user label
        /// </summary>
        private void CalculateEquation()
        {

            this.CalculationResultText.Text = ParseOperation();

            FocusInputText();
        }

        /// <summary>
        /// Parses the users equation and calculates the result
        /// </summary>
        /// <returns></returns>
        private string ParseOperation()
        {
            try
            {
                // Get the users equation input
                var input = this.UserInputText.Text;

                // Remove all spaces
                input = input.Replace(" ", "");

                // Create a new top-level operation
                var operation = new Operation();
                var leftSide = true;

                // Loop throught each character of the input
                for (int i = 0; i < input.Length; i++)
                {
                    // TODO: Handle order priority
                    //       4 + 5 * 3
                    //       It should calculate 5*3 first then 4 plus the result

                    // Check if the current character is a number
                    var myString = "0123456789.";

                    if (myString.Any(c => input[i] == c))
                    {
                        if (leftSide)
                            operation.LeftSide = AddNumberPart(operation.LeftSide, input[i]);
                        else
                            operation.RightSide = AddNumberPart(operation.RightSide, input[i]);
                    }
                    // Checks if the character is an operator and sets the operator type ( +, -, *, /)
                    else if ("+-*/".Any(c => input[i] == c))
                    {
                       //if we are on the right side we need to calculate current operation and use the result to continue the operation
                       if(!leftSide)
                        {
                            // get the operator type
                            var operatorType = GetOperationType(input[i]);
                        }
                        else
                        {
                            // get the operator type
                            var operatorType = GetOperationType(input[i]);

                            // check if there is a leftSide number
                            if (operation.LeftSide.Length == 0)
                            {
                                // Check that the operator is not a minus (used to create negative number)
                                if (operatorType != OperationType.Minus)
                                    throw new InvalidOperationException($"Operator +,*,/ or more than one -, specified without a left side number");

                                // If we got here, the operator type is a minus, and there is no left number currently, so add the minus to number
                                operation.LeftSide += input[i];
                            }
                            else
                            {
                                // If we get here, we have a left number, and now and operator, so we move to the rightSide

                                // Set the operation type
                                operation.OperationType = operatorType;

                                // Move to the right side
                                leftSide = false;

                            }
                        }
                    }
                }

                // If we are done parsing, and there were no exceptions
                // calculate the current operation
                return CalculateOperation(operation);

                return string.Empty; 
            }
            catch(Exception ex)
            {
                return $"Invalid equation. {ex.Message}";
            }
        }

        /// <summary>
        /// Calculates an <see cref="cref="Operation"/> and returns the result
        /// </summary>
        /// <param name="operation">The operation to calculate</param>
        private string CalculateOperation(Operation operation)
        {
            // Store the number values of the string representations
            double left = 0;
            double right = 0;

            // Check if we have a valid left side number
            if (string.IsNullOrEmpty(operation.LeftSide) || !double.TryParse(operation.LeftSide, out left))
                throw new InvalidOperationException($"Left side of the operation was not a number. {operation.LeftSide}");

            // Check if we have a valid right side number
            if (string.IsNullOrEmpty(operation.RightSide) || !double.TryParse(operation.RightSide, out right))
                throw new InvalidOperationException($"Left side of the operation was not a number. {operation.RightSide}");

            try
            {
                switch (operation.OperationType)
                {
                    case OperationType.Add:
                        return (left + right).ToString();
                    case OperationType.Minus:
                        return (left - right).ToString();
                    case OperationType.Divide:
                        return (left / right).ToString();
                    case OperationType.Multiply:
                        return (left * right).ToString();
                    default:
                        throw new InvalidOperationException($"Unknown operator type when calculating operation. { operation.OperationType}");
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Failed to calculate opeartion {operation.LeftSide} {operation.OperationType} {operation.RightSide} {ex.Message}");
            }

            return string.Empty;
        }

        /// <summary>
        /// Accepts a character and returns the known <see cref="OperationType"/>
        /// </summary>
        /// <param name="character">The character to parse</param>
        /// <returns></returns>
        private OperationType GetOperationType(char character)
        {
            switch (character)
            {
                case '+':
                    return OperationType.Add;
                case '-':
                    return OperationType.Minus;
                case '*':
                    return OperationType.Multiply;
                case '/':
                    return OperationType.Divide;
                default:
                    throw new InvalidOperationException($"Unknown operator type { character }");
            }
        }

        /// <summary>
        /// Attempts to add a new character to the current number, checking for valid characters
        /// </summary>
        /// <param name="currentNumber">The current number string</param>
        /// <param name="newCharacter">The new character to append to the string</param>
        /// <returns></returns>
        private string AddNumberPart(string currentNumber, char newCharacter)
        {
            // Check if there is already a . in the number
            if (newCharacter == '.' && currentNumber.Contains('.'))
                throw new InvalidOperationException($"Number {currentNumber} already contains a . and another cannot be added");

            return currentNumber + newCharacter;
        }
        #region Private Helpers

        /// <summary>
        /// Focuses the user input text
        /// </summary>
        private void FocusInputText()
        {
            this.UserInputText.Focus();
        }

        /// <summary>
        /// Inserts the given text into the user input text box
        /// </summary>
        /// <param name="value">value to insert</param>
        private void InsertTextValue(string value)
        {
            // Remember selection start
            var selectionStart = this.UserInputText.SelectionStart;

            // Set new text
            this.UserInputText.Text = this.UserInputText.Text.Insert(this.UserInputText.SelectionStart , value);

            // Restore the selection start to previous value plus the length of the value
            this.UserInputText.SelectionStart = selectionStart + value.Length;

            // Set selection length to zero
            this.UserInputText.SelectionLength = 0;
        }

        /// <summary>
        /// Deletes the character to the right of the selection start of the user input
        /// </summary>
        private void DeleteTextValue()
        {
            // if there is nothing to delete return
            if (this.UserInputText.Text.Length <= this.UserInputText.SelectionStart)
                return;

            // Remember selection start
            var selectionStart = this.UserInputText.SelectionStart;

            // Delete the character to the right of the selection
            this.UserInputText.Text = this.UserInputText.Text.Remove(this.UserInputText.SelectionStart, 1);

            // Restore the selection start
            this.UserInputText.SelectionStart = selectionStart;

            // Set selection length to zero
            this.UserInputText.SelectionLength = 0;
        }

        #endregion
    }
}
