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

                    }
                }

                return string.Empty;
            }
            catch(Exception ex)
            {
                return $"Invalid equation. {ex.Message}";
            }
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
