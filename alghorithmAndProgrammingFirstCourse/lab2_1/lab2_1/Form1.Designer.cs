namespace lab2_1
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
            this.xValueTextBox = new System.Windows.Forms.TextBox();
            this.yValueTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.zValueTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите значение X:";
            // 
            // xValueTextBox
            // 
            this.xValueTextBox.Location = new System.Drawing.Point(395, 24);
            this.xValueTextBox.Name = "xValueTextBox";
            this.xValueTextBox.Size = new System.Drawing.Size(300, 55);
            this.xValueTextBox.TabIndex = 1;
            // 
            // yValueTextBox
            // 
            this.yValueTextBox.Location = new System.Drawing.Point(395, 94);
            this.yValueTextBox.Name = "yValueTextBox";
            this.yValueTextBox.Size = new System.Drawing.Size(300, 55);
            this.yValueTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(357, 48);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите значение Y:";
            // 
            // zValueTextBox
            // 
            this.zValueTextBox.Location = new System.Drawing.Point(395, 164);
            this.zValueTextBox.Name = "zValueTextBox";
            this.zValueTextBox.Size = new System.Drawing.Size(300, 55);
            this.zValueTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(358, 48);
            this.label3.TabIndex = 4;
            this.label3.Text = "Введите значение Z:";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(22, 300);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.resultTextBox.Size = new System.Drawing.Size(673, 365);
            this.resultTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(603, 48);
            this.label4.TabIndex = 7;
            this.label4.Text = "Результат выполнения программы:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(470, 707);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 69);
            this.button1.TabIndex = 8;
            this.button1.Text = "Выполнить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 825);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.zValueTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.yValueTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.xValueTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox xValueTextBox;
        private TextBox yValueTextBox;
        private Label label2;
        private TextBox zValueTextBox;
        private Label label3;
        private TextBox resultTextBox;
        private Label label4;
        private Button button1;
    }
}