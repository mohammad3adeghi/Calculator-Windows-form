
namespace WindowsFormsApp1
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ClearAll = new System.Windows.Forms.Button();
            this.Over = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Div = new System.Windows.Forms.Button();
            this.Multiple = new System.Windows.Forms.Button();
            this.Mines = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.Eqal = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
            this.Dot = new System.Windows.Forms.Button();
            this.Zero = new System.Windows.Forms.Button();
            this.Tow = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.Seven = new System.Windows.Forms.Button();
            this.calculate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 421);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Always On Top";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ClearAll
            // 
            this.ClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClearAll.Location = new System.Drawing.Point(16, 159);
            this.ClearAll.Name = "ClearAll";
            this.ClearAll.Size = new System.Drawing.Size(69, 50);
            this.ClearAll.TabIndex = 2;
            this.ClearAll.Text = "A C";
            this.ClearAll.UseVisualStyleBackColor = true;
            this.ClearAll.Click += new System.EventHandler(this.ClearAll_Click);
            // 
            // Over
            // 
            this.Over.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Over.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Over.Location = new System.Drawing.Point(153, 159);
            this.Over.Name = "Over";
            this.Over.Size = new System.Drawing.Size(78, 49);
            this.Over.TabIndex = 3;
            this.Over.Text = "%";
            this.Over.UseVisualStyleBackColor = true;
            this.Over.Click += new System.EventHandler(this.button3_Click);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Clear.Location = new System.Drawing.Point(83, 159);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(72, 50);
            this.Clear.TabIndex = 4;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.ClearAll_Click);
            // 
            // Div
            // 
            this.Div.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Div.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Div.Location = new System.Drawing.Point(228, 159);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(77, 49);
            this.Div.TabIndex = 5;
            this.Div.Text = "/";
            this.Div.UseVisualStyleBackColor = true;
            this.Div.Click += new System.EventHandler(this.button3_Click);
            // 
            // Multiple
            // 
            this.Multiple.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiple.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Multiple.Location = new System.Drawing.Point(228, 206);
            this.Multiple.Name = "Multiple";
            this.Multiple.Size = new System.Drawing.Size(77, 49);
            this.Multiple.TabIndex = 6;
            this.Multiple.Text = "*";
            this.Multiple.UseVisualStyleBackColor = true;
            this.Multiple.Click += new System.EventHandler(this.button3_Click);
            // 
            // Mines
            // 
            this.Mines.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mines.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Mines.Location = new System.Drawing.Point(228, 251);
            this.Mines.Name = "Mines";
            this.Mines.Size = new System.Drawing.Size(77, 49);
            this.Mines.TabIndex = 7;
            this.Mines.Text = "-";
            this.Mines.UseVisualStyleBackColor = true;
            this.Mines.Click += new System.EventHandler(this.button3_Click);
            // 
            // Plus
            // 
            this.Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Plus.Location = new System.Drawing.Point(228, 298);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(77, 49);
            this.Plus.TabIndex = 8;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.button3_Click);
            // 
            // Eqal
            // 
            this.Eqal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eqal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Eqal.Location = new System.Drawing.Point(228, 344);
            this.Eqal.Name = "Eqal";
            this.Eqal.Size = new System.Drawing.Size(77, 49);
            this.Eqal.TabIndex = 9;
            this.Eqal.Text = "=";
            this.Eqal.UseVisualStyleBackColor = true;
            this.Eqal.Click += new System.EventHandler(this.Eqal_Click);
            // 
            // Nine
            // 
            this.Nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nine.Location = new System.Drawing.Point(153, 206);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(78, 49);
            this.Nine.TabIndex = 10;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = true;
            this.Nine.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Six
            // 
            this.Six.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Six.Location = new System.Drawing.Point(153, 251);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(78, 49);
            this.Six.TabIndex = 11;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = true;
            this.Six.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Three
            // 
            this.Three.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Three.Location = new System.Drawing.Point(153, 298);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(78, 49);
            this.Three.TabIndex = 12;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = true;
            this.Three.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Dot
            // 
            this.Dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dot.Location = new System.Drawing.Point(153, 344);
            this.Dot.Name = "Dot";
            this.Dot.Size = new System.Drawing.Size(78, 49);
            this.Dot.TabIndex = 13;
            this.Dot.Text = ".";
            this.Dot.UseVisualStyleBackColor = true;
            this.Dot.Click += new System.EventHandler(this.Dot_Click);
            // 
            // Zero
            // 
            this.Zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zero.Location = new System.Drawing.Point(83, 344);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(72, 49);
            this.Zero.TabIndex = 17;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = true;
            this.Zero.Click += new System.EventHandler(this.Zero_Click);
            // 
            // Tow
            // 
            this.Tow.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tow.Location = new System.Drawing.Point(83, 298);
            this.Tow.Name = "Tow";
            this.Tow.Size = new System.Drawing.Size(72, 49);
            this.Tow.TabIndex = 16;
            this.Tow.Text = "2";
            this.Tow.UseVisualStyleBackColor = true;
            this.Tow.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Five
            // 
            this.Five.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Five.Location = new System.Drawing.Point(83, 251);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(72, 49);
            this.Five.TabIndex = 15;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = true;
            this.Five.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Eight
            // 
            this.Eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eight.Location = new System.Drawing.Point(83, 206);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(72, 49);
            this.Eight.TabIndex = 14;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = true;
            this.Eight.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(16, 344);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(69, 49);
            this.button17.TabIndex = 21;
            this.button17.Text = "x";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(16, 298);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(69, 49);
            this.Button1.TabIndex = 20;
            this.Button1.Text = "1";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Four
            // 
            this.Four.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Four.Location = new System.Drawing.Point(16, 251);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(69, 49);
            this.Four.TabIndex = 19;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = true;
            this.Four.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Seven
            // 
            this.Seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seven.Location = new System.Drawing.Point(16, 206);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(69, 49);
            this.Seven.TabIndex = 18;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = true;
            this.Seven.Click += new System.EventHandler(this.Button1_Click);
            // 
            // calculate
            // 
            this.calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate.Location = new System.Drawing.Point(16, 125);
            this.calculate.Multiline = true;
            this.calculate.Name = "calculate";
            this.calculate.ReadOnly = true;
            this.calculate.Size = new System.Drawing.Size(289, 37);
            this.calculate.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 450);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Four);
            this.Controls.Add(this.Seven);
            this.Controls.Add(this.Zero);
            this.Controls.Add(this.Tow);
            this.Controls.Add(this.Five);
            this.Controls.Add(this.Eight);
            this.Controls.Add(this.Dot);
            this.Controls.Add(this.Three);
            this.Controls.Add(this.Six);
            this.Controls.Add(this.Nine);
            this.Controls.Add(this.Eqal);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.Mines);
            this.Controls.Add(this.Multiple);
            this.Controls.Add(this.Div);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Over);
            this.Controls.Add(this.ClearAll);
            this.Controls.Add(this.checkBox1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button ClearAll;
        private System.Windows.Forms.Button Over;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Div;
        private System.Windows.Forms.Button Multiple;
        private System.Windows.Forms.Button Mines;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Eqal;
        private System.Windows.Forms.Button Nine;
        private System.Windows.Forms.Button Six;
        private System.Windows.Forms.Button Three;
        private System.Windows.Forms.Button Dot;
        private System.Windows.Forms.Button Zero;
        private System.Windows.Forms.Button Tow;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Eight;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.Button Seven;
        private System.Windows.Forms.TextBox calculate;
    }
}

