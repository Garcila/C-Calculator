namespace BasicCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserInputText = new System.Windows.Forms.TextBox();
            this.CalculationResultText = new System.Windows.Forms.Label();
            this.ButtonsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonZero = new System.Windows.Forms.Button();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonThree = new System.Windows.Forms.Button();
            this.buttonTwo = new System.Windows.Forms.Button();
            this.buttonOne = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonSix = new System.Windows.Forms.Button();
            this.buttonFive = new System.Windows.Forms.Button();
            this.buttonFour = new System.Windows.Forms.Button();
            this.buttonTimes = new System.Windows.Forms.Button();
            this.buttonNine = new System.Windows.Forms.Button();
            this.buttonEight = new System.Windows.Forms.Button();
            this.buttonSeven = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonCE = new System.Windows.Forms.Button();
            this.ButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserInputText
            // 
            this.UserInputText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserInputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserInputText.Location = new System.Drawing.Point(4, 5);
            this.UserInputText.Name = "UserInputText";
            this.UserInputText.Size = new System.Drawing.Size(312, 31);
            this.UserInputText.TabIndex = 0;
            // 
            // CalculationResultText
            // 
            this.CalculationResultText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CalculationResultText.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CalculationResultText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculationResultText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CalculationResultText.Location = new System.Drawing.Point(4, 40);
            this.CalculationResultText.Name = "CalculationResultText";
            this.CalculationResultText.Size = new System.Drawing.Size(312, 53);
            this.CalculationResultText.TabIndex = 1;
            this.CalculationResultText.Text = "please enter an equation and press enter or =";
            this.CalculationResultText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonsPanel.AutoSize = true;
            this.ButtonsPanel.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonsPanel.ColumnCount = 4;
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.Controls.Add(this.buttonZero, 0, 4);
            this.ButtonsPanel.Controls.Add(this.buttonEqual, 3, 4);
            this.ButtonsPanel.Controls.Add(this.buttonDot, 2, 4);
            this.ButtonsPanel.Controls.Add(this.buttonPlus, 3, 3);
            this.ButtonsPanel.Controls.Add(this.buttonThree, 2, 3);
            this.ButtonsPanel.Controls.Add(this.buttonTwo, 1, 3);
            this.ButtonsPanel.Controls.Add(this.buttonOne, 0, 3);
            this.ButtonsPanel.Controls.Add(this.buttonMinus, 3, 2);
            this.ButtonsPanel.Controls.Add(this.buttonSix, 2, 2);
            this.ButtonsPanel.Controls.Add(this.buttonFive, 1, 2);
            this.ButtonsPanel.Controls.Add(this.buttonFour, 0, 2);
            this.ButtonsPanel.Controls.Add(this.buttonTimes, 3, 1);
            this.ButtonsPanel.Controls.Add(this.buttonNine, 2, 1);
            this.ButtonsPanel.Controls.Add(this.buttonEight, 1, 1);
            this.ButtonsPanel.Controls.Add(this.buttonSeven, 0, 1);
            this.ButtonsPanel.Controls.Add(this.buttonDivide, 3, 0);
            this.ButtonsPanel.Controls.Add(this.buttonDelete, 2, 0);
            this.ButtonsPanel.Controls.Add(this.buttonCE, 0, 0);
            this.ButtonsPanel.Location = new System.Drawing.Point(4, 104);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.RowCount = 5;
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ButtonsPanel.Size = new System.Drawing.Size(315, 291);
            this.ButtonsPanel.TabIndex = 2;
            // 
            // buttonZero
            // 
            this.buttonZero.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonZero.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonsPanel.SetColumnSpan(this.buttonZero, 2);
            this.buttonZero.FlatAppearance.BorderSize = 0;
            this.buttonZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZero.Location = new System.Drawing.Point(0, 232);
            this.buttonZero.Margin = new System.Windows.Forms.Padding(0);
            this.buttonZero.Name = "buttonZero";
            this.buttonZero.Size = new System.Drawing.Size(156, 59);
            this.buttonZero.TabIndex = 20;
            this.buttonZero.Text = "0";
            this.buttonZero.UseCompatibleTextRendering = true;
            this.buttonZero.UseVisualStyleBackColor = false;
            this.buttonZero.Click += new System.EventHandler(this.buttonZero_Click);
            // 
            // buttonEqual
            // 
            this.buttonEqual.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEqual.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEqual.FlatAppearance.BorderSize = 0;
            this.buttonEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEqual.Location = new System.Drawing.Point(234, 232);
            this.buttonEqual.Margin = new System.Windows.Forms.Padding(0);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(81, 59);
            this.buttonEqual.TabIndex = 19;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseCompatibleTextRendering = true;
            this.buttonEqual.UseVisualStyleBackColor = false;
            this.buttonEqual.Click += new System.EventHandler(this.buttonEqual_Click);
            // 
            // buttonDot
            // 
            this.buttonDot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDot.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonDot.FlatAppearance.BorderSize = 0;
            this.buttonDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDot.Location = new System.Drawing.Point(156, 232);
            this.buttonDot.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(78, 59);
            this.buttonDot.TabIndex = 18;
            this.buttonDot.Text = ".";
            this.buttonDot.UseCompatibleTextRendering = true;
            this.buttonDot.UseVisualStyleBackColor = false;
            this.buttonDot.Click += new System.EventHandler(this.buttonDot_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPlus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonPlus.FlatAppearance.BorderSize = 0;
            this.buttonPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlus.Location = new System.Drawing.Point(234, 174);
            this.buttonPlus.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(81, 58);
            this.buttonPlus.TabIndex = 15;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseCompatibleTextRendering = true;
            this.buttonPlus.UseVisualStyleBackColor = false;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonThree
            // 
            this.buttonThree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonThree.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonThree.FlatAppearance.BorderSize = 0;
            this.buttonThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThree.Location = new System.Drawing.Point(156, 174);
            this.buttonThree.Margin = new System.Windows.Forms.Padding(0);
            this.buttonThree.Name = "buttonThree";
            this.buttonThree.Size = new System.Drawing.Size(78, 58);
            this.buttonThree.TabIndex = 14;
            this.buttonThree.Text = "3";
            this.buttonThree.UseCompatibleTextRendering = true;
            this.buttonThree.UseVisualStyleBackColor = false;
            this.buttonThree.Click += new System.EventHandler(this.buttonThree_Click);
            // 
            // buttonTwo
            // 
            this.buttonTwo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTwo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonTwo.FlatAppearance.BorderSize = 0;
            this.buttonTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTwo.Location = new System.Drawing.Point(78, 174);
            this.buttonTwo.Margin = new System.Windows.Forms.Padding(0);
            this.buttonTwo.Name = "buttonTwo";
            this.buttonTwo.Size = new System.Drawing.Size(78, 58);
            this.buttonTwo.TabIndex = 13;
            this.buttonTwo.Text = "2";
            this.buttonTwo.UseCompatibleTextRendering = true;
            this.buttonTwo.UseVisualStyleBackColor = false;
            this.buttonTwo.Click += new System.EventHandler(this.buttonTwo_Click);
            // 
            // buttonOne
            // 
            this.buttonOne.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOne.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonOne.FlatAppearance.BorderSize = 0;
            this.buttonOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOne.Location = new System.Drawing.Point(0, 174);
            this.buttonOne.Margin = new System.Windows.Forms.Padding(0);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Size = new System.Drawing.Size(78, 58);
            this.buttonOne.TabIndex = 12;
            this.buttonOne.Text = "1";
            this.buttonOne.UseCompatibleTextRendering = true;
            this.buttonOne.UseVisualStyleBackColor = false;
            this.buttonOne.Click += new System.EventHandler(this.buttonOne_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonMinus.FlatAppearance.BorderSize = 0;
            this.buttonMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinus.Location = new System.Drawing.Point(234, 116);
            this.buttonMinus.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(81, 58);
            this.buttonMinus.TabIndex = 11;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseCompatibleTextRendering = true;
            this.buttonMinus.UseVisualStyleBackColor = false;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // buttonSix
            // 
            this.buttonSix.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSix.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonSix.FlatAppearance.BorderSize = 0;
            this.buttonSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSix.Location = new System.Drawing.Point(156, 116);
            this.buttonSix.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSix.Name = "buttonSix";
            this.buttonSix.Size = new System.Drawing.Size(78, 58);
            this.buttonSix.TabIndex = 10;
            this.buttonSix.Text = "6";
            this.buttonSix.UseCompatibleTextRendering = true;
            this.buttonSix.UseVisualStyleBackColor = false;
            this.buttonSix.Click += new System.EventHandler(this.buttonSix_Click);
            // 
            // buttonFive
            // 
            this.buttonFive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFive.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonFive.FlatAppearance.BorderSize = 0;
            this.buttonFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFive.Location = new System.Drawing.Point(78, 116);
            this.buttonFive.Margin = new System.Windows.Forms.Padding(0);
            this.buttonFive.Name = "buttonFive";
            this.buttonFive.Size = new System.Drawing.Size(78, 58);
            this.buttonFive.TabIndex = 9;
            this.buttonFive.Text = "5";
            this.buttonFive.UseCompatibleTextRendering = true;
            this.buttonFive.UseVisualStyleBackColor = false;
            this.buttonFive.Click += new System.EventHandler(this.buttonFive_Click);
            // 
            // buttonFour
            // 
            this.buttonFour.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFour.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonFour.FlatAppearance.BorderSize = 0;
            this.buttonFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFour.Location = new System.Drawing.Point(0, 116);
            this.buttonFour.Margin = new System.Windows.Forms.Padding(0);
            this.buttonFour.Name = "buttonFour";
            this.buttonFour.Size = new System.Drawing.Size(78, 58);
            this.buttonFour.TabIndex = 8;
            this.buttonFour.Text = "4";
            this.buttonFour.UseCompatibleTextRendering = true;
            this.buttonFour.UseVisualStyleBackColor = false;
            this.buttonFour.Click += new System.EventHandler(this.buttonFour_Click);
            // 
            // buttonTimes
            // 
            this.buttonTimes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTimes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonTimes.FlatAppearance.BorderSize = 0;
            this.buttonTimes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTimes.Location = new System.Drawing.Point(234, 58);
            this.buttonTimes.Margin = new System.Windows.Forms.Padding(0);
            this.buttonTimes.Name = "buttonTimes";
            this.buttonTimes.Size = new System.Drawing.Size(81, 58);
            this.buttonTimes.TabIndex = 7;
            this.buttonTimes.Text = "x";
            this.buttonTimes.UseCompatibleTextRendering = true;
            this.buttonTimes.UseVisualStyleBackColor = false;
            this.buttonTimes.Click += new System.EventHandler(this.buttonTimes_Click);
            // 
            // buttonNine
            // 
            this.buttonNine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNine.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonNine.FlatAppearance.BorderSize = 0;
            this.buttonNine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNine.Location = new System.Drawing.Point(156, 58);
            this.buttonNine.Margin = new System.Windows.Forms.Padding(0);
            this.buttonNine.Name = "buttonNine";
            this.buttonNine.Size = new System.Drawing.Size(78, 58);
            this.buttonNine.TabIndex = 6;
            this.buttonNine.Text = "9";
            this.buttonNine.UseCompatibleTextRendering = true;
            this.buttonNine.UseVisualStyleBackColor = false;
            this.buttonNine.Click += new System.EventHandler(this.buttonNine_Click);
            // 
            // buttonEight
            // 
            this.buttonEight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEight.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEight.FlatAppearance.BorderSize = 0;
            this.buttonEight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEight.Location = new System.Drawing.Point(78, 58);
            this.buttonEight.Margin = new System.Windows.Forms.Padding(0);
            this.buttonEight.Name = "buttonEight";
            this.buttonEight.Size = new System.Drawing.Size(78, 58);
            this.buttonEight.TabIndex = 5;
            this.buttonEight.Text = "8";
            this.buttonEight.UseCompatibleTextRendering = true;
            this.buttonEight.UseVisualStyleBackColor = false;
            this.buttonEight.Click += new System.EventHandler(this.buttonEight_Click);
            // 
            // buttonSeven
            // 
            this.buttonSeven.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSeven.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonSeven.FlatAppearance.BorderSize = 0;
            this.buttonSeven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSeven.Location = new System.Drawing.Point(0, 58);
            this.buttonSeven.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSeven.Name = "buttonSeven";
            this.buttonSeven.Size = new System.Drawing.Size(78, 58);
            this.buttonSeven.TabIndex = 4;
            this.buttonSeven.Text = "7";
            this.buttonSeven.UseCompatibleTextRendering = true;
            this.buttonSeven.UseVisualStyleBackColor = false;
            this.buttonSeven.Click += new System.EventHandler(this.buttonSeven_Click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDivide.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonDivide.FlatAppearance.BorderSize = 0;
            this.buttonDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDivide.Location = new System.Drawing.Point(234, 0);
            this.buttonDivide.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(81, 58);
            this.buttonDivide.TabIndex = 3;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseCompatibleTextRendering = true;
            this.buttonDivide.UseVisualStyleBackColor = false;
            this.buttonDivide.Click += new System.EventHandler(this.buttonDivide_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Location = new System.Drawing.Point(156, 0);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(78, 58);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Del";
            this.buttonDelete.UseCompatibleTextRendering = true;
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonCE
            // 
            this.buttonCE.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonsPanel.SetColumnSpan(this.buttonCE, 2);
            this.buttonCE.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCE.FlatAppearance.BorderSize = 0;
            this.buttonCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCE.Location = new System.Drawing.Point(0, 0);
            this.buttonCE.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(156, 58);
            this.buttonCE.TabIndex = 0;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseCompatibleTextRendering = true;
            this.buttonCE.UseVisualStyleBackColor = false;
            this.buttonCE.Click += new System.EventHandler(this.buttonCE_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonEqual;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CancelButton = this.buttonCE;
            this.ClientSize = new System.Drawing.Size(324, 401);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.CalculationResultText);
            this.Controls.Add(this.UserInputText);
            this.MinimumSize = new System.Drawing.Size(340, 440);
            this.Name = "Form1";
            this.Text = "BasicCalculator";
            this.ButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserInputText;
        private System.Windows.Forms.Label CalculationResultText;
        private System.Windows.Forms.TableLayoutPanel ButtonsPanel;
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonThree;
        private System.Windows.Forms.Button buttonTwo;
        private System.Windows.Forms.Button buttonOne;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonSix;
        private System.Windows.Forms.Button buttonFive;
        private System.Windows.Forms.Button buttonFour;
        private System.Windows.Forms.Button buttonTimes;
        private System.Windows.Forms.Button buttonNine;
        private System.Windows.Forms.Button buttonEight;
        private System.Windows.Forms.Button buttonSeven;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonZero;
    }
}

