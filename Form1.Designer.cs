﻿namespace SimpleCalc
{
    partial class FormSimpleCalc
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Formula = new Label();
            Result = new Label();
            Equal = new Label();
            BtnSeven = new Button();
            BtnEight = new Button();
            BtnNine = new Button();
            BtnDivision = new Button();
            BtnFour = new Button();
            BtnFive = new Button();
            BtnSix = new Button();
            BtnMultiplication = new Button();
            BtnOne = new Button();
            BtnTwo = new Button();
            BtnThree = new Button();
            BtnSubtraction = new Button();
            BtnZero = new Button();
            BtnEqual = new Button();
            BtnAddition = new Button();
            BtnClearEntry = new Button();
            BtnAllClear = new Button();
            SuspendLayout();
            // 
            // Formula
            // 
            Formula.BorderStyle = BorderStyle.FixedSingle;
            Formula.Location = new Point(23, 20);
            Formula.Name = "Formula";
            Formula.Size = new Size(212, 41);
            Formula.TabIndex = 0;
            // 
            // Result
            // 
            Result.BorderStyle = BorderStyle.FixedSingle;
            Result.Location = new Point(23, 73);
            Result.Name = "Result";
            Result.Size = new Size(258, 53);
            Result.TabIndex = 0;
            // 
            // Equal
            // 
            Equal.BorderStyle = BorderStyle.FixedSingle;
            Equal.Font = new Font("Yu Gothic UI", 14F);
            Equal.Location = new Point(241, 20);
            Equal.Name = "Equal";
            Equal.Padding = new Padding(8, 5, 0, 0);
            Equal.Size = new Size(40, 41);
            Equal.TabIndex = 0;
            Equal.Text = "=";
            Equal.Click += label3_Click;
            // 
            // BtnSeven
            // 
            BtnSeven.Font = new Font("Yu Gothic UI", 12F);
            BtnSeven.Location = new Point(23, 144);
            BtnSeven.Name = "BtnSeven";
            BtnSeven.Size = new Size(60, 60);
            BtnSeven.TabIndex = 1;
            BtnSeven.Text = "7";
            BtnSeven.UseVisualStyleBackColor = true;
            BtnSeven.Click += AppendNumberToFormula;
            // 
            // BtnEight
            // 
            BtnEight.Font = new Font("Yu Gothic UI", 12F);
            BtnEight.Location = new Point(89, 144);
            BtnEight.Name = "BtnEight";
            BtnEight.Size = new Size(60, 60);
            BtnEight.TabIndex = 1;
            BtnEight.Text = "8";
            BtnEight.UseVisualStyleBackColor = true;
            BtnEight.Click += AppendNumberToFormula;
            // 
            // BtnNine
            // 
            BtnNine.Font = new Font("Yu Gothic UI", 12F);
            BtnNine.Location = new Point(155, 144);
            BtnNine.Name = "BtnNine";
            BtnNine.Size = new Size(60, 60);
            BtnNine.TabIndex = 1;
            BtnNine.Text = "9";
            BtnNine.UseVisualStyleBackColor = true;
            BtnNine.Click += AppendNumberToFormula;
            // 
            // BtnDivision
            // 
            BtnDivision.Font = new Font("Yu Gothic UI", 12F);
            BtnDivision.Location = new Point(221, 144);
            BtnDivision.Name = "BtnDivision";
            BtnDivision.Size = new Size(60, 60);
            BtnDivision.TabIndex = 1;
            BtnDivision.Text = "÷";
            BtnDivision.UseVisualStyleBackColor = true;
            BtnDivision.Click += BtnDivision_Click;
            // 
            // BtnFour
            // 
            BtnFour.Font = new Font("Yu Gothic UI", 12F);
            BtnFour.Location = new Point(23, 210);
            BtnFour.Name = "BtnFour";
            BtnFour.Size = new Size(60, 60);
            BtnFour.TabIndex = 1;
            BtnFour.Text = "4";
            BtnFour.UseVisualStyleBackColor = true;
            BtnFour.Click += AppendNumberToFormula;
            // 
            // BtnFive
            // 
            BtnFive.Font = new Font("Yu Gothic UI", 12F);
            BtnFive.Location = new Point(89, 210);
            BtnFive.Name = "BtnFive";
            BtnFive.Size = new Size(60, 60);
            BtnFive.TabIndex = 1;
            BtnFive.Text = "5";
            BtnFive.UseVisualStyleBackColor = true;
            BtnFive.Click += AppendNumberToFormula;
            // 
            // BtnSix
            // 
            BtnSix.Font = new Font("Yu Gothic UI", 12F);
            BtnSix.Location = new Point(155, 210);
            BtnSix.Name = "BtnSix";
            BtnSix.Size = new Size(60, 60);
            BtnSix.TabIndex = 1;
            BtnSix.Text = "6";
            BtnSix.UseVisualStyleBackColor = true;
            BtnSix.Click += AppendNumberToFormula;
            // 
            // BtnMultiplication
            // 
            BtnMultiplication.Font = new Font("Yu Gothic UI", 12F);
            BtnMultiplication.Location = new Point(221, 210);
            BtnMultiplication.Name = "BtnMultiplication";
            BtnMultiplication.Size = new Size(60, 60);
            BtnMultiplication.TabIndex = 1;
            BtnMultiplication.Text = "×";
            BtnMultiplication.UseVisualStyleBackColor = true;
            BtnMultiplication.Click += BtnMultiplication_Click;
            // 
            // BtnOne
            // 
            BtnOne.Font = new Font("Yu Gothic UI", 12F);
            BtnOne.Location = new Point(23, 276);
            BtnOne.Name = "BtnOne";
            BtnOne.Size = new Size(60, 60);
            BtnOne.TabIndex = 1;
            BtnOne.Text = "1";
            BtnOne.UseVisualStyleBackColor = true;
            BtnOne.Click += AppendNumberToFormula;
            // 
            // BtnTwo
            // 
            BtnTwo.Font = new Font("Yu Gothic UI", 12F);
            BtnTwo.Location = new Point(89, 276);
            BtnTwo.Name = "BtnTwo";
            BtnTwo.Size = new Size(60, 60);
            BtnTwo.TabIndex = 1;
            BtnTwo.Text = "2";
            BtnTwo.UseVisualStyleBackColor = true;
            BtnTwo.Click += AppendNumberToFormula;
            // 
            // BtnThree
            // 
            BtnThree.Font = new Font("Yu Gothic UI", 12F);
            BtnThree.Location = new Point(155, 276);
            BtnThree.Name = "BtnThree";
            BtnThree.Size = new Size(60, 60);
            BtnThree.TabIndex = 1;
            BtnThree.Text = "3";
            BtnThree.UseVisualStyleBackColor = true;
            BtnThree.Click += AppendNumberToFormula;
            // 
            // BtnSubtraction
            // 
            BtnSubtraction.Font = new Font("Yu Gothic UI", 12F);
            BtnSubtraction.Location = new Point(221, 276);
            BtnSubtraction.Name = "BtnSubtraction";
            BtnSubtraction.Size = new Size(60, 60);
            BtnSubtraction.TabIndex = 1;
            BtnSubtraction.Text = "-";
            BtnSubtraction.UseVisualStyleBackColor = true;
            BtnSubtraction.Click += BtnSubtraction_Click;
            // 
            // BtnZero
            // 
            BtnZero.Font = new Font("Yu Gothic UI", 12F);
            BtnZero.Location = new Point(23, 342);
            BtnZero.Name = "BtnZero";
            BtnZero.Size = new Size(126, 60);
            BtnZero.TabIndex = 1;
            BtnZero.Text = "0";
            BtnZero.UseVisualStyleBackColor = true;
            BtnZero.Click += AppendNumberToFormula;
            // 
            // BtnEqual
            // 
            BtnEqual.Font = new Font("Yu Gothic UI", 12F);
            BtnEqual.Location = new Point(155, 342);
            BtnEqual.Name = "BtnEqual";
            BtnEqual.Size = new Size(60, 60);
            BtnEqual.TabIndex = 1;
            BtnEqual.Text = "=";
            BtnEqual.UseVisualStyleBackColor = true;
            BtnEqual.Click += BtnEqual_Click;
            // 
            // BtnAddition
            // 
            BtnAddition.Font = new Font("Yu Gothic UI", 12F);
            BtnAddition.Location = new Point(221, 342);
            BtnAddition.Name = "BtnAddition";
            BtnAddition.Size = new Size(60, 60);
            BtnAddition.TabIndex = 1;
            BtnAddition.Text = "+";
            BtnAddition.UseVisualStyleBackColor = true;
            BtnAddition.Click += BtnAddition_Click;
            // 
            // BtnClearEntry
            // 
            BtnClearEntry.Font = new Font("Yu Gothic UI", 12F);
            BtnClearEntry.Location = new Point(23, 408);
            BtnClearEntry.Name = "BtnClearEntry";
            BtnClearEntry.Size = new Size(126, 60);
            BtnClearEntry.TabIndex = 1;
            BtnClearEntry.Text = "CE";
            BtnClearEntry.UseVisualStyleBackColor = true;
            BtnClearEntry.Click += BtnClearEntry_Click;
            // 
            // BtnAllClear
            // 
            BtnAllClear.Font = new Font("Yu Gothic UI", 12F);
            BtnAllClear.Location = new Point(155, 408);
            BtnAllClear.Name = "BtnAllClear";
            BtnAllClear.Size = new Size(126, 60);
            BtnAllClear.TabIndex = 1;
            BtnAllClear.Text = "AC";
            BtnAllClear.UseVisualStyleBackColor = true;
            BtnAllClear.Click += BtnAllClear_Click;
            // 
            // FormSimpleCalc
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(315, 489);
            Controls.Add(BtnAddition);
            Controls.Add(BtnEqual);
            Controls.Add(BtnSubtraction);
            Controls.Add(BtnThree);
            Controls.Add(BtnMultiplication);
            Controls.Add(BtnSix);
            Controls.Add(BtnTwo);
            Controls.Add(BtnDivision);
            Controls.Add(BtnAllClear);
            Controls.Add(BtnClearEntry);
            Controls.Add(BtnZero);
            Controls.Add(BtnFive);
            Controls.Add(BtnOne);
            Controls.Add(BtnNine);
            Controls.Add(BtnFour);
            Controls.Add(BtnEight);
            Controls.Add(BtnSeven);
            Controls.Add(Result);
            Controls.Add(Equal);
            Controls.Add(Formula);
            Name = "FormSimpleCalc";
            Text = "簡易電卓";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label Formula;
        private Label Result;
        private Label Equal;
        private Button BtnSeven;
        private Button BtnEight;
        private Button BtnNine;
        private Button BtnDivision;
        private Button BtnFour;
        private Button BtnFive;
        private Button BtnSix;
        private Button BtnMultiplication;
        private Button BtnOne;
        private Button BtnTwo;
        private Button BtnThree;
        private Button BtnSubtraction;
        private Button BtnZero;
        private Button BtnEqual;
        private Button BtnAddition;
        private Button BtnClearEntry;
        private Button BtnAllClear;
    }
}
