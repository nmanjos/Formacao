namespace Calculator
{
    partial class Calculador
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
            this.History = new System.Windows.Forms.Label();
            this.Numeric = new System.Windows.Forms.Label();
            this.Undo = new System.Windows.Forms.Button();
            this.SignalShift = new System.Windows.Forms.Button();
            this.Redo = new System.Windows.Forms.Button();
            this.ClearBt = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Num2 = new System.Windows.Forms.Button();
            this.Num3 = new System.Windows.Forms.Button();
            this.Num1 = new System.Windows.Forms.Button();
            this.Subtract = new System.Windows.Forms.Button();
            this.Num5 = new System.Windows.Forms.Button();
            this.Num6 = new System.Windows.Forms.Button();
            this.Num4 = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Num8 = new System.Windows.Forms.Button();
            this.Num9 = new System.Windows.Forms.Button();
            this.Num7 = new System.Windows.Forms.Button();
            this.Devide = new System.Windows.Forms.Button();
            this.Fraction = new System.Windows.Forms.Button();
            this.ClearValBt = new System.Windows.Forms.Button();
            this.Num0 = new System.Windows.Forms.Button();
            this.EqualBt = new System.Windows.Forms.Button();
            this.ONOFF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // History
            // 
            this.History.BackColor = System.Drawing.Color.White;
            this.History.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.History.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.History.Location = new System.Drawing.Point(0, 0);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(374, 25);
            this.History.TabIndex = 0;
            this.History.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.History.Click += new System.EventHandler(this.History_Click);
            // 
            // Numeric
            // 
            this.Numeric.BackColor = System.Drawing.Color.White;
            this.Numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Numeric.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numeric.Location = new System.Drawing.Point(0, 25);
            this.Numeric.Name = "Numeric";
            this.Numeric.Size = new System.Drawing.Size(374, 37);
            this.Numeric.TabIndex = 1;
            this.Numeric.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Numeric.Click += new System.EventHandler(this.Numeric_Click);
            // 
            // Undo
            // 
            this.Undo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Undo.Location = new System.Drawing.Point(5, 64);
            this.Undo.Name = "Undo";
            this.Undo.Size = new System.Drawing.Size(65, 59);
            this.Undo.TabIndex = 2;
            this.Undo.TabStop = false;
            this.Undo.Text = "Undo";
            this.Undo.UseVisualStyleBackColor = true;
            this.Undo.Click += new System.EventHandler(this.Undo_Click);
            // 
            // SignalShift
            // 
            this.SignalShift.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignalShift.Location = new System.Drawing.Point(147, 324);
            this.SignalShift.Name = "SignalShift";
            this.SignalShift.Size = new System.Drawing.Size(65, 59);
            this.SignalShift.TabIndex = 3;
            this.SignalShift.TabStop = false;
            this.SignalShift.Text = "+/-";
            this.SignalShift.UseVisualStyleBackColor = true;
            this.SignalShift.Click += new System.EventHandler(this.SignalShift_Click);
            // 
            // Redo
            // 
            this.Redo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Redo.Location = new System.Drawing.Point(76, 64);
            this.Redo.Name = "Redo";
            this.Redo.Size = new System.Drawing.Size(65, 59);
            this.Redo.TabIndex = 4;
            this.Redo.TabStop = false;
            this.Redo.Text = "Redo";
            this.Redo.UseVisualStyleBackColor = true;
            this.Redo.Click += new System.EventHandler(this.Redo_Click);
            // 
            // ClearBt
            // 
            this.ClearBt.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBt.Location = new System.Drawing.Point(218, 64);
            this.ClearBt.Name = "ClearBt";
            this.ClearBt.Size = new System.Drawing.Size(65, 59);
            this.ClearBt.TabIndex = 5;
            this.ClearBt.TabStop = false;
            this.ClearBt.Text = "C";
            this.ClearBt.UseVisualStyleBackColor = true;
            this.ClearBt.Click += new System.EventHandler(this.ClearBt_Click);
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(218, 129);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(65, 59);
            this.Add.TabIndex = 9;
            this.Add.TabStop = false;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Num2
            // 
            this.Num2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num2.Location = new System.Drawing.Point(76, 129);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(65, 59);
            this.Num2.TabIndex = 8;
            this.Num2.TabStop = false;
            this.Num2.Text = "2";
            this.Num2.UseVisualStyleBackColor = true;
            this.Num2.Click += new System.EventHandler(this.Num1_Click);
            // 
            // Num3
            // 
            this.Num3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num3.Location = new System.Drawing.Point(147, 129);
            this.Num3.Name = "Num3";
            this.Num3.Size = new System.Drawing.Size(65, 59);
            this.Num3.TabIndex = 7;
            this.Num3.TabStop = false;
            this.Num3.Text = "3";
            this.Num3.UseVisualStyleBackColor = true;
            this.Num3.Click += new System.EventHandler(this.Num1_Click);
            // 
            // Num1
            // 
            this.Num1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num1.Location = new System.Drawing.Point(5, 129);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(65, 59);
            this.Num1.TabIndex = 6;
            this.Num1.TabStop = false;
            this.Num1.Text = "1";
            this.Num1.UseVisualStyleBackColor = true;
            this.Num1.Click += new System.EventHandler(this.Num1_Click);
            // 
            // Subtract
            // 
            this.Subtract.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtract.Location = new System.Drawing.Point(218, 194);
            this.Subtract.Name = "Subtract";
            this.Subtract.Size = new System.Drawing.Size(65, 59);
            this.Subtract.TabIndex = 13;
            this.Subtract.TabStop = false;
            this.Subtract.Text = "-";
            this.Subtract.UseVisualStyleBackColor = true;
            this.Subtract.Click += new System.EventHandler(this.Add_Click);
            // 
            // Num5
            // 
            this.Num5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num5.Location = new System.Drawing.Point(76, 194);
            this.Num5.Name = "Num5";
            this.Num5.Size = new System.Drawing.Size(65, 59);
            this.Num5.TabIndex = 12;
            this.Num5.TabStop = false;
            this.Num5.Text = "5";
            this.Num5.UseVisualStyleBackColor = true;
            this.Num5.Click += new System.EventHandler(this.Num1_Click);
            // 
            // Num6
            // 
            this.Num6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num6.Location = new System.Drawing.Point(147, 194);
            this.Num6.Name = "Num6";
            this.Num6.Size = new System.Drawing.Size(65, 59);
            this.Num6.TabIndex = 11;
            this.Num6.TabStop = false;
            this.Num6.Text = "6";
            this.Num6.UseVisualStyleBackColor = true;
            this.Num6.Click += new System.EventHandler(this.Num1_Click);
            // 
            // Num4
            // 
            this.Num4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num4.Location = new System.Drawing.Point(5, 194);
            this.Num4.Name = "Num4";
            this.Num4.Size = new System.Drawing.Size(65, 59);
            this.Num4.TabIndex = 10;
            this.Num4.TabStop = false;
            this.Num4.Text = "4";
            this.Num4.UseVisualStyleBackColor = true;
            this.Num4.Click += new System.EventHandler(this.Num1_Click);
            // 
            // Multiply
            // 
            this.Multiply.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiply.Location = new System.Drawing.Point(218, 259);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(65, 59);
            this.Multiply.TabIndex = 17;
            this.Multiply.TabStop = false;
            this.Multiply.Text = "X";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.Add_Click);
            // 
            // Num8
            // 
            this.Num8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num8.Location = new System.Drawing.Point(76, 259);
            this.Num8.Name = "Num8";
            this.Num8.Size = new System.Drawing.Size(65, 59);
            this.Num8.TabIndex = 16;
            this.Num8.TabStop = false;
            this.Num8.Text = "8";
            this.Num8.UseVisualStyleBackColor = true;
            this.Num8.Click += new System.EventHandler(this.Num1_Click);
            // 
            // Num9
            // 
            this.Num9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num9.Location = new System.Drawing.Point(147, 259);
            this.Num9.Name = "Num9";
            this.Num9.Size = new System.Drawing.Size(65, 59);
            this.Num9.TabIndex = 15;
            this.Num9.TabStop = false;
            this.Num9.Text = "9";
            this.Num9.UseVisualStyleBackColor = true;
            this.Num9.Click += new System.EventHandler(this.Num1_Click);
            // 
            // Num7
            // 
            this.Num7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num7.Location = new System.Drawing.Point(5, 259);
            this.Num7.Name = "Num7";
            this.Num7.Size = new System.Drawing.Size(65, 59);
            this.Num7.TabIndex = 14;
            this.Num7.TabStop = false;
            this.Num7.Text = "7";
            this.Num7.UseVisualStyleBackColor = true;
            this.Num7.Click += new System.EventHandler(this.Num1_Click);
            // 
            // Devide
            // 
            this.Devide.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Devide.Location = new System.Drawing.Point(218, 324);
            this.Devide.Name = "Devide";
            this.Devide.Size = new System.Drawing.Size(65, 59);
            this.Devide.TabIndex = 21;
            this.Devide.TabStop = false;
            this.Devide.Text = "/";
            this.Devide.UseVisualStyleBackColor = true;
            this.Devide.Click += new System.EventHandler(this.Add_Click);
            // 
            // Fraction
            // 
            this.Fraction.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fraction.Location = new System.Drawing.Point(76, 324);
            this.Fraction.Name = "Fraction";
            this.Fraction.Size = new System.Drawing.Size(65, 59);
            this.Fraction.TabIndex = 20;
            this.Fraction.TabStop = false;
            this.Fraction.Text = ".";
            this.Fraction.UseVisualStyleBackColor = true;
            this.Fraction.Click += new System.EventHandler(this.Fraction_Click);
            // 
            // ClearValBt
            // 
            this.ClearValBt.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearValBt.Location = new System.Drawing.Point(147, 64);
            this.ClearValBt.Name = "ClearValBt";
            this.ClearValBt.Size = new System.Drawing.Size(65, 59);
            this.ClearValBt.TabIndex = 19;
            this.ClearValBt.TabStop = false;
            this.ClearValBt.Text = "CE";
            this.ClearValBt.UseVisualStyleBackColor = true;
            this.ClearValBt.Click += new System.EventHandler(this.ClearValBt_Click);
            // 
            // Num0
            // 
            this.Num0.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num0.Location = new System.Drawing.Point(5, 324);
            this.Num0.Name = "Num0";
            this.Num0.Size = new System.Drawing.Size(65, 59);
            this.Num0.TabIndex = 18;
            this.Num0.TabStop = false;
            this.Num0.Text = "0";
            this.Num0.UseVisualStyleBackColor = true;
            this.Num0.Click += new System.EventHandler(this.Num1_Click);
            // 
            // EqualBt
            // 
            this.EqualBt.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqualBt.Location = new System.Drawing.Point(289, 64);
            this.EqualBt.Name = "EqualBt";
            this.EqualBt.Size = new System.Drawing.Size(79, 189);
            this.EqualBt.TabIndex = 22;
            this.EqualBt.TabStop = false;
            this.EqualBt.Text = "=";
            this.EqualBt.UseVisualStyleBackColor = true;
            this.EqualBt.Click += new System.EventHandler(this.EqualBt_Click);
            // 
            // ONOFF
            // 
            this.ONOFF.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ONOFF.Location = new System.Drawing.Point(289, 259);
            this.ONOFF.Name = "ONOFF";
            this.ONOFF.Size = new System.Drawing.Size(79, 124);
            this.ONOFF.TabIndex = 23;
            this.ONOFF.TabStop = false;
            this.ONOFF.Text = " ON   OFF";
            this.ONOFF.UseVisualStyleBackColor = true;
            this.ONOFF.Click += new System.EventHandler(this.ONOFF_Click);
            // 
            // Calculador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(374, 384);
            this.Controls.Add(this.ONOFF);
            this.Controls.Add(this.EqualBt);
            this.Controls.Add(this.Devide);
            this.Controls.Add(this.Fraction);
            this.Controls.Add(this.ClearValBt);
            this.Controls.Add(this.Num0);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Num8);
            this.Controls.Add(this.Num9);
            this.Controls.Add(this.Num7);
            this.Controls.Add(this.Subtract);
            this.Controls.Add(this.Num5);
            this.Controls.Add(this.Num6);
            this.Controls.Add(this.Num4);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.Num3);
            this.Controls.Add(this.Num1);
            this.Controls.Add(this.ClearBt);
            this.Controls.Add(this.Redo);
            this.Controls.Add(this.SignalShift);
            this.Controls.Add(this.Undo);
            this.Controls.Add(this.Numeric);
            this.Controls.Add(this.History);
            this.KeyPreview = true;
            this.Name = "Calculador";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Calculador_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label History;
        private System.Windows.Forms.Label Numeric;
        private System.Windows.Forms.Button Undo;
        private System.Windows.Forms.Button SignalShift;
        private System.Windows.Forms.Button Redo;
        private System.Windows.Forms.Button ClearBt;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Num2;
        private System.Windows.Forms.Button Num3;
        private System.Windows.Forms.Button Num1;
        private System.Windows.Forms.Button Subtract;
        private System.Windows.Forms.Button Num5;
        private System.Windows.Forms.Button Num6;
        private System.Windows.Forms.Button Num4;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Num8;
        private System.Windows.Forms.Button Num9;
        private System.Windows.Forms.Button Num7;
        private System.Windows.Forms.Button Devide;
        private System.Windows.Forms.Button Fraction;
        private System.Windows.Forms.Button ClearValBt;
        private System.Windows.Forms.Button Num0;
        private System.Windows.Forms.Button EqualBt;
        private System.Windows.Forms.Button ONOFF;
    }
}

