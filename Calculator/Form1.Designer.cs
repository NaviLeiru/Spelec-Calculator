namespace Calculator
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
            textBox1 = new TextBox();
            button07 = new Button();
            button08 = new Button();
            button09 = new Button();
            buttonDel = new Button();
            button04 = new Button();
            button05 = new Button();
            button06 = new Button();
            buttonadd = new Button();
            button01 = new Button();
            button02 = new Button();
            button03 = new Button();
            buttonsub = new Button();
            buttonDec = new Button();
            button00 = new Button();
            buttonDiv = new Button();
            buttonmul = new Button();
            buttonCLR = new Button();
            buttonttl = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ActiveCaption;
            textBox1.CharacterCasing = CharacterCasing.Lower;
            textBox1.Font = new Font("Arial Narrow", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(26, 36);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(580, 134);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button07
            // 
            button07.BackColor = Color.White;
            button07.Location = new Point(26, 197);
            button07.Name = "button07";
            button07.Size = new Size(140, 51);
            button07.TabIndex = 1;
            button07.Text = "7";
            button07.UseVisualStyleBackColor = false;
            button07.Click += button1_Click;
            // 
            // button08
            // 
            button08.Location = new Point(172, 197);
            button08.Name = "button08";
            button08.Size = new Size(140, 51);
            button08.TabIndex = 2;
            button08.Text = "8";
            button08.UseVisualStyleBackColor = true;
            button08.Click += button2_Click;
            // 
            // button09
            // 
            button09.Location = new Point(318, 197);
            button09.Name = "button09";
            button09.Size = new Size(140, 51);
            button09.TabIndex = 3;
            button09.Text = "9";
            button09.UseVisualStyleBackColor = true;
            button09.Click += button3_Click;
            // 
            // buttonDel
            // 
            buttonDel.Location = new Point(466, 197);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(140, 51);
            buttonDel.TabIndex = 4;
            buttonDel.Text = "DEL";
            buttonDel.UseVisualStyleBackColor = true;
            buttonDel.Click += button4_Click;
            // 
            // button04
            // 
            button04.Location = new Point(26, 272);
            button04.Name = "button04";
            button04.Size = new Size(140, 51);
            button04.TabIndex = 5;
            button04.Text = "4";
            button04.UseVisualStyleBackColor = true;
            button04.Click += button04_Click;
            // 
            // button05
            // 
            button05.Location = new Point(172, 272);
            button05.Name = "button05";
            button05.Size = new Size(140, 51);
            button05.TabIndex = 6;
            button05.Text = "5";
            button05.UseVisualStyleBackColor = true;
            button05.Click += button05_Click;
            // 
            // button06
            // 
            button06.Location = new Point(318, 272);
            button06.Name = "button06";
            button06.Size = new Size(140, 51);
            button06.TabIndex = 7;
            button06.Text = "6";
            button06.UseVisualStyleBackColor = true;
            button06.Click += button06_Click;
            // 
            // buttonadd
            // 
            buttonadd.Location = new Point(464, 272);
            buttonadd.Name = "buttonadd";
            buttonadd.Size = new Size(140, 51);
            buttonadd.TabIndex = 8;
            buttonadd.Text = "+";
            buttonadd.UseVisualStyleBackColor = true;
            buttonadd.Click += button8_Click;
            // 
            // button01
            // 
            button01.Location = new Point(26, 348);
            button01.Name = "button01";
            button01.Size = new Size(140, 51);
            button01.TabIndex = 9;
            button01.Text = "1";
            button01.UseVisualStyleBackColor = true;
            button01.Click += button9_Click;
            // 
            // button02
            // 
            button02.Location = new Point(172, 348);
            button02.Name = "button02";
            button02.Size = new Size(140, 51);
            button02.TabIndex = 10;
            button02.Text = "2";
            button02.UseVisualStyleBackColor = true;
            button02.Click += button02_Click;
            // 
            // button03
            // 
            button03.Location = new Point(318, 348);
            button03.Name = "button03";
            button03.Size = new Size(140, 51);
            button03.TabIndex = 11;
            button03.Text = "3";
            button03.UseVisualStyleBackColor = true;
            button03.Click += button11_Click;
            // 
            // buttonsub
            // 
            buttonsub.Location = new Point(466, 348);
            buttonsub.Name = "buttonsub";
            buttonsub.Size = new Size(140, 51);
            buttonsub.TabIndex = 12;
            buttonsub.Text = "-";
            buttonsub.UseVisualStyleBackColor = true;
            buttonsub.Click += buttonsub_Click_1;
            // 
            // buttonDec
            // 
            buttonDec.Location = new Point(26, 420);
            buttonDec.Name = "buttonDec";
            buttonDec.Size = new Size(140, 51);
            buttonDec.TabIndex = 13;
            buttonDec.Text = ".";
            buttonDec.UseVisualStyleBackColor = true;
            buttonDec.Click += button13_Click;
            // 
            // button00
            // 
            button00.Location = new Point(172, 420);
            button00.Name = "button00";
            button00.Size = new Size(140, 51);
            button00.TabIndex = 14;
            button00.Text = "0";
            button00.UseVisualStyleBackColor = true;
            button00.Click += button00_Click;
            // 
            // buttonDiv
            // 
            buttonDiv.Location = new Point(318, 420);
            buttonDiv.Name = "buttonDiv";
            buttonDiv.Size = new Size(140, 51);
            buttonDiv.TabIndex = 15;
            buttonDiv.Text = "/";
            buttonDiv.UseVisualStyleBackColor = true;
            buttonDiv.Click += button15_Click;
            // 
            // buttonmul
            // 
            buttonmul.Location = new Point(464, 420);
            buttonmul.Name = "buttonmul";
            buttonmul.Size = new Size(140, 51);
            buttonmul.TabIndex = 16;
            buttonmul.Text = "*";
            buttonmul.UseVisualStyleBackColor = true;
            buttonmul.Click += buttonmul_Click_1;
            // 
            // buttonCLR
            // 
            buttonCLR.Location = new Point(26, 493);
            buttonCLR.Name = "buttonCLR";
            buttonCLR.Size = new Size(286, 51);
            buttonCLR.TabIndex = 17;
            buttonCLR.Text = "CLEAR";
            buttonCLR.UseVisualStyleBackColor = true;
            buttonCLR.Click += button17_Click;
            // 
            // buttonttl
            // 
            buttonttl.Location = new Point(318, 493);
            buttonttl.Name = "buttonttl";
            buttonttl.Size = new Size(286, 51);
            buttonttl.TabIndex = 18;
            buttonttl.Text = "=";
            buttonttl.UseVisualStyleBackColor = true;
            buttonttl.Click += buttonttl_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(635, 568);
            Controls.Add(buttonttl);
            Controls.Add(buttonCLR);
            Controls.Add(buttonmul);
            Controls.Add(buttonDiv);
            Controls.Add(button00);
            Controls.Add(buttonDec);
            Controls.Add(buttonsub);
            Controls.Add(button03);
            Controls.Add(button02);
            Controls.Add(button01);
            Controls.Add(buttonadd);
            Controls.Add(button06);
            Controls.Add(button05);
            Controls.Add(button04);
            Controls.Add(buttonDel);
            Controls.Add(button09);
            Controls.Add(button08);
            Controls.Add(button07);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button07;
        private Button button08;
        private Button button09;
        private Button buttonDel;
        private Button button04;
        private Button button05;
        private Button button06;
        private Button buttonadd;
        private Button button01;
        private Button button02;
        private Button button03;
        private Button buttonsub;
        private Button buttonDec;
        private Button button00;
        private Button buttonDiv;
        private Button buttonmul;
        private Button buttonCLR;
        private Button buttonttl;
    }
}
