namespace WinFormsApp1
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
            button3 = new Button();
            button4 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            button19 = new Button();
            button20 = new Button();
            button21 = new Button();
            button22 = new Button();
            button23 = new Button();
            button24 = new Button();
            result = new TextBox();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(-1, 80);
            button3.Name = "button3";
            button3.Size = new Size(75, 54);
            button3.TabIndex = 2;
            button3.Text = "C";
            button3.UseVisualStyleBackColor = true;
            button3.Click += ClearButton_Click;
            // 
            // button4
            // 
            button4.Location = new Point(161, 80);
            button4.Name = "button4";
            button4.Size = new Size(75, 54);
            button4.TabIndex = 3;
            button4.Text = "⌫";
            button4.UseVisualStyleBackColor = true;
            button4.Click += DeleteButton_Click;
            // 
            // button7
            // 
            button7.Location = new Point(80, 80);
            button7.Name = "button7";
            button7.Size = new Size(75, 54);
            button7.TabIndex = 5;
            button7.Text = "√x";
            button7.UseVisualStyleBackColor = true;
            button7.Click += SqrtButton_Click;
            // 
            // button8
            // 
            button8.Location = new Point(242, 80);
            button8.Name = "button8";
            button8.Size = new Size(75, 54);
            button8.TabIndex = 4;
            button8.Text = "÷";
            button8.UseVisualStyleBackColor = true;
            button8.Click += DivisionButton_Click;
            // 
            // button9
            // 
            button9.Location = new Point(-1, 140);
            button9.Name = "button9";
            button9.Size = new Size(75, 54);
            button9.TabIndex = 11;
            button9.Text = "7";
            button9.UseVisualStyleBackColor = true;
            button9.Click += NumButton_Click;
            // 
            // button10
            // 
            button10.Location = new Point(80, 140);
            button10.Name = "button10";
            button10.Size = new Size(75, 54);
            button10.TabIndex = 10;
            button10.Text = "8";
            button10.UseVisualStyleBackColor = true;
            button10.Click += NumButton_Click;
            // 
            // button11
            // 
            button11.Location = new Point(161, 140);
            button11.Name = "button11";
            button11.Size = new Size(75, 54);
            button11.TabIndex = 9;
            button11.Text = "9";
            button11.UseVisualStyleBackColor = true;
            button11.Click += NumButton_Click;
            // 
            // button12
            // 
            button12.Location = new Point(242, 140);
            button12.Name = "button12";
            button12.Size = new Size(75, 54);
            button12.TabIndex = 8;
            button12.Text = "×";
            button12.UseVisualStyleBackColor = true;
            button12.Click += MultiplyButton_Click;
            // 
            // button13
            // 
            button13.Location = new Point(-1, 200);
            button13.Name = "button13";
            button13.Size = new Size(75, 54);
            button13.TabIndex = 15;
            button13.Text = "4";
            button13.UseVisualStyleBackColor = true;
            button13.Click += NumButton_Click;
            // 
            // button14
            // 
            button14.Location = new Point(80, 200);
            button14.Name = "button14";
            button14.Size = new Size(75, 54);
            button14.TabIndex = 14;
            button14.Text = "5";
            button14.UseVisualStyleBackColor = true;
            button14.Click += NumButton_Click;
            // 
            // button15
            // 
            button15.Location = new Point(161, 200);
            button15.Name = "button15";
            button15.Size = new Size(75, 54);
            button15.TabIndex = 13;
            button15.Text = "6";
            button15.UseVisualStyleBackColor = true;
            button15.Click += NumButton_Click;
            // 
            // button16
            // 
            button16.Location = new Point(242, 200);
            button16.Name = "button16";
            button16.Size = new Size(75, 54);
            button16.TabIndex = 12;
            button16.Text = "-";
            button16.UseVisualStyleBackColor = true;
            button16.Click += MinusButton_Click;
            // 
            // button17
            // 
            button17.Location = new Point(-1, 260);
            button17.Name = "button17";
            button17.Size = new Size(75, 54);
            button17.TabIndex = 19;
            button17.Text = "1";
            button17.UseVisualStyleBackColor = true;
            button17.Click += NumButton_Click;
            // 
            // button18
            // 
            button18.Location = new Point(80, 260);
            button18.Name = "button18";
            button18.Size = new Size(75, 54);
            button18.TabIndex = 18;
            button18.Text = "2";
            button18.UseVisualStyleBackColor = true;
            button18.Click += NumButton_Click;
            // 
            // button19
            // 
            button19.Location = new Point(161, 260);
            button19.Name = "button19";
            button19.Size = new Size(75, 54);
            button19.TabIndex = 17;
            button19.Text = "3";
            button19.UseVisualStyleBackColor = true;
            button19.Click += NumButton_Click;
            // 
            // button20
            // 
            button20.Location = new Point(242, 260);
            button20.Name = "button20";
            button20.Size = new Size(75, 54);
            button20.TabIndex = 16;
            button20.Text = "+";
            button20.UseVisualStyleBackColor = true;
            button20.Click += PlusButton_Click;
            // 
            // button21
            // 
            button21.Location = new Point(-1, 320);
            button21.Name = "button21";
            button21.Size = new Size(75, 54);
            button21.TabIndex = 23;
            button21.Text = "+/-";
            button21.UseVisualStyleBackColor = true;
            button21.Click += ModuleButton_Click;
            // 
            // button22
            // 
            button22.Location = new Point(80, 320);
            button22.Name = "button22";
            button22.Size = new Size(75, 54);
            button22.TabIndex = 22;
            button22.Text = "0";
            button22.UseVisualStyleBackColor = true;
            button22.Click += NumButton_Click;
            // 
            // button23
            // 
            button23.Location = new Point(161, 320);
            button23.Name = "button23";
            button23.Size = new Size(75, 54);
            button23.TabIndex = 21;
            button23.Text = ".";
            button23.UseVisualStyleBackColor = true;
            button23.Click += NumButton_Click;
            // 
            // button24
            // 
            button24.Location = new Point(242, 320);
            button24.Name = "button24";
            button24.Size = new Size(75, 54);
            button24.TabIndex = 20;
            button24.Text = "=";
            button24.UseVisualStyleBackColor = true;
            button24.Click += EqualsButton_Click;
            // 
            // result
            // 
            result.Enabled = false;
            result.Location = new Point(12, 32);
            result.Name = "result";
            result.Size = new Size(294, 27);
            result.TabIndex = 24;
            result.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 376);
            Controls.Add(result);
            Controls.Add(button21);
            Controls.Add(button22);
            Controls.Add(button23);
            Controls.Add(button24);
            Controls.Add(button17);
            Controls.Add(button18);
            Controls.Add(button19);
            Controls.Add(button20);
            Controls.Add(button13);
            Controls.Add(button14);
            Controls.Add(button15);
            Controls.Add(button16);
            Controls.Add(button9);
            Controls.Add(button10);
            Controls.Add(button11);
            Controls.Add(button12);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button4);
            Controls.Add(button3);
            Name = "Form1";
            Text = "Калькулятор";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button3;
        private Button button4;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button19;
        private Button button20;
        private Button button21;
        private Button button22;
        private Button button23;
        private Button button24;
        private TextBox result;
    }
}