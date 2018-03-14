namespace Calculator_MVP
{
    partial class View1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonNegation = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonPoint = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonNumberClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(76, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonNumberClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(136, 236);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(42, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonNumberClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 190);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(42, 40);
            this.button4.TabIndex = 5;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonNumberClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(76, 190);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(42, 40);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.buttonNumberClick);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(136, 190);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(42, 40);
            this.button6.TabIndex = 3;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.buttonNumberClick);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 144);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(42, 40);
            this.button7.TabIndex = 8;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.buttonNumberClick);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(76, 144);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(42, 40);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.buttonNumberClick);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(136, 144);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(42, 40);
            this.button9.TabIndex = 6;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.buttonNumberClick);
            // 
            // buttonNegation
            // 
            this.buttonNegation.Location = new System.Drawing.Point(12, 282);
            this.buttonNegation.Name = "buttonNegation";
            this.buttonNegation.Size = new System.Drawing.Size(42, 40);
            this.buttonNegation.TabIndex = 11;
            this.buttonNegation.Text = "±";
            this.buttonNegation.UseVisualStyleBackColor = true;
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(76, 282);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(42, 40);
            this.button0.TabIndex = 10;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            // 
            // buttonEqual
            // 
            this.buttonEqual.Location = new System.Drawing.Point(196, 236);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(42, 86);
            this.buttonEqual.TabIndex = 9;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = true;
            this.buttonEqual.Click += new System.EventHandler(this.buttonEqualClick);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Location = new System.Drawing.Point(196, 144);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(42, 40);
            this.buttonMultiply.TabIndex = 14;
            this.buttonMultiply.Text = "*";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.buttonEqualClick);
            // 
            // buttonDivide
            // 
            this.buttonDivide.Location = new System.Drawing.Point(196, 190);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(42, 40);
            this.buttonDivide.TabIndex = 13;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.buttonEqualClick);
            // 
            // buttonPoint
            // 
            this.buttonPoint.Location = new System.Drawing.Point(136, 282);
            this.buttonPoint.Name = "buttonPoint";
            this.buttonPoint.Size = new System.Drawing.Size(42, 40);
            this.buttonPoint.TabIndex = 15;
            this.buttonPoint.Text = ".";
            this.buttonPoint.UseVisualStyleBackColor = true;
            // 
            // buttonMinus
            // 
            this.buttonMinus.Location = new System.Drawing.Point(196, 98);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(42, 40);
            this.buttonMinus.TabIndex = 19;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonEqualClick);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(12, 98);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(106, 40);
            this.buttonCancel.TabIndex = 18;
            this.buttonCancel.Text = "C";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonPlus
            // 
            this.buttonPlus.Location = new System.Drawing.Point(136, 98);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(42, 40);
            this.buttonPlus.TabIndex = 16;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonEqualClick);
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox.Location = new System.Drawing.Point(12, 49);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(226, 26);
            this.textBox.TabIndex = 20;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelResult.Location = new System.Drawing.Point(18, 14);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 25);
            this.labelResult.TabIndex = 21;
            // 
            // View1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 340);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonPoint);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonNegation);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.buttonEqual);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "View1";
            this.Text = "View1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonNegation;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonPoint;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label labelResult;
    }
}