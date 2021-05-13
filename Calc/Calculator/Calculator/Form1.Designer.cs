
using System;

namespace simple_calc
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.Button_MPlus = new System.Windows.Forms.Button();
            this.Button_C = new System.Windows.Forms.Button();
            this.Button_MR = new System.Windows.Forms.Button();
            this.Button_MC = new System.Windows.Forms.Button();
            this.Button_MS = new System.Windows.Forms.Button();
            this.Button_8 = new System.Windows.Forms.Button();
            this.Button_9 = new System.Windows.Forms.Button();
            this.Button_Division = new System.Windows.Forms.Button();
            this.Button_Percent = new System.Windows.Forms.Button();
            this.Button_7 = new System.Windows.Forms.Button();
            this.Button_5 = new System.Windows.Forms.Button();
            this.Button_6 = new System.Windows.Forms.Button();
            this.Button_Multiplication = new System.Windows.Forms.Button();
            this.Button_SquareRoot = new System.Windows.Forms.Button();
            this.Button_4 = new System.Windows.Forms.Button();
            this.Button_2 = new System.Windows.Forms.Button();
            this.Button_3 = new System.Windows.Forms.Button();
            this.Button_Minus = new System.Windows.Forms.Button();
            this.Button_Equal = new System.Windows.Forms.Button();
            this.Button_1 = new System.Windows.Forms.Button();
            this.Button_Dot = new System.Windows.Forms.Button();
            this.Button_Plus = new System.Windows.Forms.Button();
            this.Button_0 = new System.Windows.Forms.Button();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.showCalculations = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(-275, -138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // Button_MPlus
            // 
            this.Button_MPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Button_MPlus.Location = new System.Drawing.Point(8, 98);
            this.Button_MPlus.Name = "Button_MPlus";
            this.Button_MPlus.Size = new System.Drawing.Size(45, 45);
            this.Button_MPlus.TabIndex = 1;
            this.Button_MPlus.Text = "M+";
            this.Button_MPlus.UseVisualStyleBackColor = true;
            this.Button_MPlus.Click += new System.EventHandler(this.buttonMR);
            // 
            // Button_C
            // 
            this.Button_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Button_C.Location = new System.Drawing.Point(212, 98);
            this.Button_C.Name = "Button_C";
            this.Button_C.Size = new System.Drawing.Size(45, 45);
            this.Button_C.TabIndex = 2;
            this.Button_C.Text = "C";
            this.Button_C.UseVisualStyleBackColor = true;
            this.Button_C.Click += new System.EventHandler(this.Button_C_Click);
            // 
            // Button_MR
            // 
            this.Button_MR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Button_MR.Location = new System.Drawing.Point(110, 98);
            this.Button_MR.Name = "Button_MR";
            this.Button_MR.Size = new System.Drawing.Size(45, 45);
            this.Button_MR.TabIndex = 3;
            this.Button_MR.Text = "MR";
            this.Button_MR.UseVisualStyleBackColor = true;
            this.Button_MR.Click += new System.EventHandler(this.buttonMR);
            // 
            // Button_MC
            // 
            this.Button_MC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Button_MC.Location = new System.Drawing.Point(161, 98);
            this.Button_MC.Name = "Button_MC";
            this.Button_MC.Size = new System.Drawing.Size(45, 45);
            this.Button_MC.TabIndex = 4;
            this.Button_MC.Text = "MC";
            this.Button_MC.UseVisualStyleBackColor = true;
            this.Button_MC.Click += new System.EventHandler(this.buttonMR);
            // 
            // Button_MS
            // 
            this.Button_MS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Button_MS.Location = new System.Drawing.Point(59, 98);
            this.Button_MS.Name = "Button_MS";
            this.Button_MS.Size = new System.Drawing.Size(45, 45);
            this.Button_MS.TabIndex = 5;
            this.Button_MS.Text = "MS";
            this.Button_MS.UseVisualStyleBackColor = true;
            this.Button_MS.Click += new System.EventHandler(this.buttonMR);
            // 
            // Button_8
            // 
            this.Button_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Button_8.Location = new System.Drawing.Point(59, 149);
            this.Button_8.Name = "Button_8";
            this.Button_8.Size = new System.Drawing.Size(45, 45);
            this.Button_8.TabIndex = 10;
            this.Button_8.Text = "8";
            this.Button_8.UseVisualStyleBackColor = true;
            this.Button_8.Click += new System.EventHandler(this.Button_Click);
            // 
            // Button_9
            // 
            this.Button_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Button_9.Location = new System.Drawing.Point(110, 149);
            this.Button_9.Name = "Button_9";
            this.Button_9.Size = new System.Drawing.Size(45, 45);
            this.Button_9.TabIndex = 9;
            this.Button_9.Text = "9";
            this.Button_9.UseVisualStyleBackColor = true;
            this.Button_9.Click += new System.EventHandler(this.Button_Click);
            // 
            // Button_Division
            // 
            this.Button_Division.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Button_Division.Location = new System.Drawing.Point(161, 149);
            this.Button_Division.Name = "Button_Division";
            this.Button_Division.Size = new System.Drawing.Size(45, 45);
            this.Button_Division.TabIndex = 8;
            this.Button_Division.Text = "/";
            this.Button_Division.UseVisualStyleBackColor = true;
            this.Button_Division.Click += new System.EventHandler(this.Operator_Click);
            // 
            // Button_Percent
            // 
            this.Button_Percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Button_Percent.Location = new System.Drawing.Point(212, 149);
            this.Button_Percent.Name = "Button_Percent";
            this.Button_Percent.Size = new System.Drawing.Size(45, 45);
            this.Button_Percent.TabIndex = 7;
            this.Button_Percent.Text = "%";
            this.Button_Percent.UseVisualStyleBackColor = true;
            this.Button_Percent.Click += new System.EventHandler(this.Operator_Click);
            // 
            // Button_7
            // 
            this.Button_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Button_7.Location = new System.Drawing.Point(8, 149);
            this.Button_7.Name = "Button_7";
            this.Button_7.Size = new System.Drawing.Size(45, 45);
            this.Button_7.TabIndex = 6;
            this.Button_7.Text = "7";
            this.Button_7.UseVisualStyleBackColor = true;
            this.Button_7.Click += new System.EventHandler(this.Button_Click);
            // 
            // Button_5
            // 
            this.Button_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Button_5.Location = new System.Drawing.Point(59, 200);
            this.Button_5.Name = "Button_5";
            this.Button_5.Size = new System.Drawing.Size(45, 45);
            this.Button_5.TabIndex = 15;
            this.Button_5.Text = "5";
            this.Button_5.UseVisualStyleBackColor = true;
            this.Button_5.Click += new System.EventHandler(this.Button_Click);
            // 
            // Button_6
            // 
            this.Button_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Button_6.Location = new System.Drawing.Point(110, 200);
            this.Button_6.Name = "Button_6";
            this.Button_6.Size = new System.Drawing.Size(45, 45);
            this.Button_6.TabIndex = 14;
            this.Button_6.Text = "6";
            this.Button_6.UseVisualStyleBackColor = true;
            this.Button_6.Click += new System.EventHandler(this.Button_Click);
            // 
            // Button_Multiplication
            // 
            this.Button_Multiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Button_Multiplication.Location = new System.Drawing.Point(161, 200);
            this.Button_Multiplication.Name = "Button_Multiplication";
            this.Button_Multiplication.Size = new System.Drawing.Size(45, 45);
            this.Button_Multiplication.TabIndex = 13;
            this.Button_Multiplication.Text = "*";
            this.Button_Multiplication.UseVisualStyleBackColor = true;
            this.Button_Multiplication.Click += new System.EventHandler(this.Operator_Click);
            // 
            // Button_SquareRoot
            // 
            this.Button_SquareRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Button_SquareRoot.Location = new System.Drawing.Point(212, 200);
            this.Button_SquareRoot.Name = "Button_SquareRoot";
            this.Button_SquareRoot.Size = new System.Drawing.Size(45, 45);
            this.Button_SquareRoot.TabIndex = 12;
            this.Button_SquareRoot.Text = "√";
            this.Button_SquareRoot.UseVisualStyleBackColor = true;
            this.Button_SquareRoot.Click += new System.EventHandler(this.Operator_Click);
            // 
            // Button_4
            // 
            this.Button_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Button_4.Location = new System.Drawing.Point(8, 200);
            this.Button_4.Name = "Button_4";
            this.Button_4.Size = new System.Drawing.Size(45, 45);
            this.Button_4.TabIndex = 11;
            this.Button_4.Text = "4";
            this.Button_4.UseVisualStyleBackColor = true;
            this.Button_4.Click += new System.EventHandler(this.Button_Click);
            // 
            // Button_2
            // 
            this.Button_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Button_2.Location = new System.Drawing.Point(59, 251);
            this.Button_2.Name = "Button_2";
            this.Button_2.Size = new System.Drawing.Size(45, 45);
            this.Button_2.TabIndex = 20;
            this.Button_2.Text = "2";
            this.Button_2.UseVisualStyleBackColor = true;
            this.Button_2.Click += new System.EventHandler(this.Button_Click);
            // 
            // Button_3
            // 
            this.Button_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Button_3.Location = new System.Drawing.Point(110, 251);
            this.Button_3.Name = "Button_3";
            this.Button_3.Size = new System.Drawing.Size(45, 45);
            this.Button_3.TabIndex = 19;
            this.Button_3.Text = "3";
            this.Button_3.UseVisualStyleBackColor = true;
            this.Button_3.Click += new System.EventHandler(this.Button_Click);
            // 
            // Button_Minus
            // 
            this.Button_Minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Button_Minus.Location = new System.Drawing.Point(161, 251);
            this.Button_Minus.Name = "Button_Minus";
            this.Button_Minus.Size = new System.Drawing.Size(45, 45);
            this.Button_Minus.TabIndex = 18;
            this.Button_Minus.Text = "-";
            this.Button_Minus.UseVisualStyleBackColor = true;
            this.Button_Minus.Click += new System.EventHandler(this.Operator_Click);
            // 
            // Button_Equal
            // 
            this.Button_Equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Button_Equal.Location = new System.Drawing.Point(212, 251);
            this.Button_Equal.Name = "Button_Equal";
            this.Button_Equal.Size = new System.Drawing.Size(45, 96);
            this.Button_Equal.TabIndex = 17;
            this.Button_Equal.Text = "=";
            this.Button_Equal.UseVisualStyleBackColor = true;
            this.Button_Equal.Click += new System.EventHandler(this.Button_Equal_Click);
            // 
            // Button_1
            // 
            this.Button_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Button_1.Location = new System.Drawing.Point(8, 251);
            this.Button_1.Name = "Button_1";
            this.Button_1.Size = new System.Drawing.Size(45, 45);
            this.Button_1.TabIndex = 16;
            this.Button_1.Text = "1";
            this.Button_1.UseVisualStyleBackColor = true;
            this.Button_1.Click += new System.EventHandler(this.Button_Click);
            // 
            // Button_Dot
            // 
            this.Button_Dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Button_Dot.Location = new System.Drawing.Point(110, 302);
            this.Button_Dot.Name = "Button_Dot";
            this.Button_Dot.Size = new System.Drawing.Size(45, 45);
            this.Button_Dot.TabIndex = 24;
            this.Button_Dot.Text = ".";
            this.Button_Dot.UseVisualStyleBackColor = true;
            this.Button_Dot.Click += new System.EventHandler(this.Button_Click);
            // 
            // Button_Plus
            // 
            this.Button_Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Button_Plus.Location = new System.Drawing.Point(161, 302);
            this.Button_Plus.Name = "Button_Plus";
            this.Button_Plus.Size = new System.Drawing.Size(45, 45);
            this.Button_Plus.TabIndex = 23;
            this.Button_Plus.Text = "+";
            this.Button_Plus.UseVisualStyleBackColor = true;
            this.Button_Plus.Click += new System.EventHandler(this.Operator_Click);
            // 
            // Button_0
            // 
            this.Button_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Button_0.Location = new System.Drawing.Point(8, 302);
            this.Button_0.Name = "Button_0";
            this.Button_0.Size = new System.Drawing.Size(96, 45);
            this.Button_0.TabIndex = 21;
            this.Button_0.Text = "0";
            this.Button_0.UseVisualStyleBackColor = true;
            this.Button_0.Click += new System.EventHandler(this.Button_Click);
            // 
            // textBox_Result
            // 
            this.textBox_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.textBox_Result.Location = new System.Drawing.Point(8, 48);
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.Size = new System.Drawing.Size(249, 44);
            this.textBox_Result.TabIndex = 26;
            this.textBox_Result.Text = "0";
            this.textBox_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // showCalculations
            // 
            this.showCalculations.AutoSize = true;
            this.showCalculations.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showCalculations.Location = new System.Drawing.Point(13, 13);
            this.showCalculations.Name = "showCalculations";
            this.showCalculations.Size = new System.Drawing.Size(0, 22);
            this.showCalculations.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 356);
            this.Controls.Add(this.showCalculations);
            this.Controls.Add(this.textBox_Result);
            this.Controls.Add(this.Button_Dot);
            this.Controls.Add(this.Button_Plus);
            this.Controls.Add(this.Button_0);
            this.Controls.Add(this.Button_2);
            this.Controls.Add(this.Button_3);
            this.Controls.Add(this.Button_Minus);
            this.Controls.Add(this.Button_Equal);
            this.Controls.Add(this.Button_1);
            this.Controls.Add(this.Button_5);
            this.Controls.Add(this.Button_6);
            this.Controls.Add(this.Button_Multiplication);
            this.Controls.Add(this.Button_SquareRoot);
            this.Controls.Add(this.Button_4);
            this.Controls.Add(this.Button_8);
            this.Controls.Add(this.Button_9);
            this.Controls.Add(this.Button_Division);
            this.Controls.Add(this.Button_Percent);
            this.Controls.Add(this.Button_7);
            this.Controls.Add(this.Button_MS);
            this.Controls.Add(this.Button_MC);
            this.Controls.Add(this.Button_MR);
            this.Controls.Add(this.Button_C);
            this.Controls.Add(this.Button_MPlus);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_MPlus;
        private System.Windows.Forms.Button Button_C;
        private System.Windows.Forms.Button Button_MR;
        private System.Windows.Forms.Button Button_MC;
        private System.Windows.Forms.Button Button_MS;
        private System.Windows.Forms.Button Button_8;
        private System.Windows.Forms.Button Button_9;
        private System.Windows.Forms.Button Button_Division;
        private System.Windows.Forms.Button Button_Percent;
        private System.Windows.Forms.Button Button_7;
        private System.Windows.Forms.Button Button_5;
        private System.Windows.Forms.Button Button_6;
        private System.Windows.Forms.Button Button_Multiplication;
        private System.Windows.Forms.Button Button_SquareRoot;
        private System.Windows.Forms.Button Button_4;
        private System.Windows.Forms.Button Button_2;
        private System.Windows.Forms.Button Button_3;
        private System.Windows.Forms.Button Button_Minus;
        private System.Windows.Forms.Button Button_Equal;
        private System.Windows.Forms.Button Button_1;
        private System.Windows.Forms.Button Button_Dot;
        private System.Windows.Forms.Button Button_Plus;
        private System.Windows.Forms.Button Button_0;
        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.Label showCalculations;
    }
}

