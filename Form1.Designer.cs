namespace numeros_de_mayor_a_menor
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Num1TextBox = new TextBox();
            Num2TextBox = new TextBox();
            Num3TextBox = new TextBox();
            button1 = new Button();
            ResultLabel = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(83, 44);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(204, 38);
            label1.TabIndex = 0;
            label1.Text = "Primer número";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(73, 126);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(232, 38);
            label2.TabIndex = 1;
            label2.Text = "Segundo número";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(73, 200);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(197, 38);
            label3.TabIndex = 2;
            label3.Text = "Tercer número";
            label3.Click += label3_Click;
            // 
            // Num1TextBox
            // 
            Num1TextBox.Location = new Point(324, 44);
            Num1TextBox.Name = "Num1TextBox";
            Num1TextBox.Size = new Size(238, 45);
            Num1TextBox.TabIndex = 3;
            // 
            // Num2TextBox
            // 
            Num2TextBox.Location = new Point(324, 126);
            Num2TextBox.Name = "Num2TextBox";
            Num2TextBox.Size = new Size(238, 45);
            Num2TextBox.TabIndex = 4;
            // 
            // Num3TextBox
            // 
            Num3TextBox.Location = new Point(324, 200);
            Num3TextBox.Name = "Num3TextBox";
            Num3TextBox.Size = new Size(238, 45);
            Num3TextBox.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(248, 278);
            button1.Name = "button1";
            button1.Size = new Size(150, 49);
            button1.TabIndex = 6;
            button1.Text = "Ordernar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ResultLabel
            // 
            ResultLabel.AutoSize = true;
            ResultLabel.BackColor = SystemColors.Window;
            ResultLabel.BorderStyle = BorderStyle.Fixed3D;
            ResultLabel.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            ResultLabel.ForeColor = SystemColors.ControlText;
            ResultLabel.ImageAlign = ContentAlignment.TopRight;
            ResultLabel.Location = new Point(202, 366);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.Size = new Size(243, 40);
            ResultLabel.TabIndex = 7;
            ResultLabel.Text = "                            ";
            ResultLabel.TextAlign = ContentAlignment.MiddleCenter;
            ResultLabel.Click += ResultLabel_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 368);
            label4.Name = "label4";
            label4.Size = new Size(0, 38);
            label4.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(766, 461);
            Controls.Add(label4);
            Controls.Add(ResultLabel);
            Controls.Add(button1);
            Controls.Add(Num3TextBox);
            Controls.Add(Num2TextBox);
            Controls.Add(Num1TextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6, 8, 6, 8);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Num1TextBox;
        private TextBox Num2TextBox;
        private TextBox Num3TextBox;
        private Button button1;
        private Label ResultLabel;
        private Label label4;
    }
}