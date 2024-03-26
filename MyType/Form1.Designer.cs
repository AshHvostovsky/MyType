namespace MyType
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
            txtNum1 = new TextBox();
            txtDen1 = new TextBox();
            label2 = new Label();
            txtNum2 = new TextBox();
            txtDen2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtResult = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtFr1 = new TextBox();
            txtFr2 = new TextBox();
            btnCleanNum1 = new Button();
            btnCleanDen1 = new Button();
            btnCleanNum2 = new Button();
            btnCleanDen2 = new Button();
            txtAction = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            cmbOperations = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 59);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 2;
            label1.Text = "Числитель";
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(99, 56);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(100, 23);
            txtNum1.TabIndex = 3;
            txtNum1.TextChanged += txtNum1_TextChanged;
            // 
            // txtDen1
            // 
            txtDen1.Location = new Point(99, 85);
            txtDen1.Name = "txtDen1";
            txtDen1.Size = new Size(100, 23);
            txtDen1.TabIndex = 4;
            txtDen1.TextChanged += txtDen1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 88);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 5;
            label2.Text = "Знаменатель";
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(99, 154);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(100, 23);
            txtNum2.TabIndex = 6;
            txtNum2.TextChanged += txtNum2_TextChanged;
            // 
            // txtDen2
            // 
            txtDen2.Location = new Point(99, 183);
            txtDen2.Name = "txtDen2";
            txtDen2.Size = new Size(100, 23);
            txtDen2.TabIndex = 7;
            txtDen2.TextChanged += txtDen2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 157);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 8;
            label3.Text = "Числитель";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 186);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 9;
            label4.Text = "Знаменатель";
            // 
            // txtResult
            // 
            txtResult.Location = new Point(649, 119);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(100, 23);
            txtResult.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(583, 122);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 12;
            label5.Text = "Результат";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(592, 40);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 14;
            label6.Text = "Дробь 1";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(592, 85);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 15;
            label7.Text = "Дробь 2";
            // 
            // txtFr1
            // 
            txtFr1.Location = new Point(649, 37);
            txtFr1.Name = "txtFr1";
            txtFr1.ReadOnly = true;
            txtFr1.Size = new Size(100, 23);
            txtFr1.TabIndex = 16;
            // 
            // txtFr2
            // 
            txtFr2.Location = new Point(649, 81);
            txtFr2.Name = "txtFr2";
            txtFr2.ReadOnly = true;
            txtFr2.Size = new Size(100, 23);
            txtFr2.TabIndex = 17;
            // 
            // btnCleanNum1
            // 
            btnCleanNum1.Location = new Point(205, 56);
            btnCleanNum1.Name = "btnCleanNum1";
            btnCleanNum1.Size = new Size(75, 23);
            btnCleanNum1.TabIndex = 22;
            btnCleanNum1.Text = "Очистить";
            btnCleanNum1.UseVisualStyleBackColor = true;
            btnCleanNum1.Click += btnCleanNum1_Click;
            // 
            // btnCleanDen1
            // 
            btnCleanDen1.Location = new Point(205, 85);
            btnCleanDen1.Name = "btnCleanDen1";
            btnCleanDen1.Size = new Size(75, 23);
            btnCleanDen1.TabIndex = 23;
            btnCleanDen1.Text = "Очистить";
            btnCleanDen1.UseVisualStyleBackColor = true;
            btnCleanDen1.Click += btnCleanDen1_Click;
            // 
            // btnCleanNum2
            // 
            btnCleanNum2.Location = new Point(205, 153);
            btnCleanNum2.Name = "btnCleanNum2";
            btnCleanNum2.Size = new Size(75, 23);
            btnCleanNum2.TabIndex = 24;
            btnCleanNum2.Text = "Очистить";
            btnCleanNum2.UseVisualStyleBackColor = true;
            btnCleanNum2.Click += btnCleanNum2_Click;
            // 
            // btnCleanDen2
            // 
            btnCleanDen2.Location = new Point(205, 182);
            btnCleanDen2.Name = "btnCleanDen2";
            btnCleanDen2.Size = new Size(75, 23);
            btnCleanDen2.TabIndex = 25;
            btnCleanDen2.Text = "Очистить";
            btnCleanDen2.UseVisualStyleBackColor = true;
            btnCleanDen2.Click += btnCleanDen2_Click;
            // 
            // txtAction
            // 
            txtAction.AutoSize = true;
            txtAction.Location = new Point(668, 63);
            txtAction.Name = "txtAction";
            txtAction.Size = new Size(0, 15);
            txtAction.TabIndex = 27;
            txtAction.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F);
            label8.Location = new Point(84, 9);
            label8.Name = "label8";
            label8.Size = new Size(123, 25);
            label8.TabIndex = 28;
            label8.Text = "Ввод дробей";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14F);
            label9.Location = new Point(348, 9);
            label9.Name = "label9";
            label9.Size = new Size(94, 25);
            label9.TabIndex = 29;
            label9.Text = "Действия";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14F);
            label10.Location = new Point(668, 9);
            label10.Name = "label10";
            label10.Size = new Size(67, 25);
            label10.TabIndex = 30;
            label10.Text = "Вывод";
            // 
            // cmbOperations
            // 
            cmbOperations.FormattingEnabled = true;
            cmbOperations.Items.AddRange(new object[] { "+", "-", "*", "/", "Сравнить" });
            cmbOperations.Location = new Point(334, 42);
            cmbOperations.Name = "cmbOperations";
            cmbOperations.Size = new Size(121, 23);
            cmbOperations.TabIndex = 31;
            cmbOperations.Text = "+";
            cmbOperations.SelectedIndexChanged += cmbOperations_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1020, 251);
            Controls.Add(cmbOperations);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtAction);
            Controls.Add(btnCleanDen2);
            Controls.Add(btnCleanNum2);
            Controls.Add(btnCleanDen1);
            Controls.Add(btnCleanNum1);
            Controls.Add(txtFr2);
            Controls.Add(txtFr1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtResult);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtDen2);
            Controls.Add(txtNum2);
            Controls.Add(label2);
            Controls.Add(txtDen1);
            Controls.Add(txtNum1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Калькулятор дробей";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtNum1;
        private TextBox txtDen1;
        private Label label2;
        private TextBox txtNum2;
        private TextBox txtDen2;
        private Label label3;
        private Label label4;
        private TextBox txtResult;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtFr1;
        private TextBox txtFr2;
        private Button btnCleanNum1;
        private Button btnCleanDen1;
        private Button btnCleanNum2;
        private Button btnCleanDen2;
        private Label txtAction;
        private Label label8;
        private Label label9;
        private Label label10;
        private ComboBox cmbOperations;
    }
}
