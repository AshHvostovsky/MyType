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
            btnCreate1 = new Button();
            btnCreate2 = new Button();
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
            btnSum = new Button();
            btnMinus = new Button();
            btnUmn = new Button();
            btnDel = new Button();
            btnCleanNum1 = new Button();
            btnCleanDen1 = new Button();
            btnCleanNum2 = new Button();
            btnCleanDen2 = new Button();
            btnSrav = new Button();
            txtAction = new Label();
            SuspendLayout();
            // 
            // btnCreate1
            // 
            btnCreate1.Location = new Point(109, 100);
            btnCreate1.Name = "btnCreate1";
            btnCreate1.Size = new Size(75, 23);
            btnCreate1.TabIndex = 0;
            btnCreate1.Text = "Создать";
            btnCreate1.UseVisualStyleBackColor = true;
            btnCreate1.Click += btnCreate1_Click;
            // 
            // btnCreate2
            // 
            btnCreate2.Location = new Point(109, 198);
            btnCreate2.Name = "btnCreate2";
            btnCreate2.Size = new Size(75, 23);
            btnCreate2.TabIndex = 1;
            btnCreate2.Text = "Создать";
            btnCreate2.UseVisualStyleBackColor = true;
            btnCreate2.Click += btnCreate2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 45);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 2;
            label1.Text = "Числитель";
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(95, 42);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(100, 23);
            txtNum1.TabIndex = 3;
            // 
            // txtDen1
            // 
            txtDen1.Location = new Point(95, 71);
            txtDen1.Name = "txtDen1";
            txtDen1.Size = new Size(100, 23);
            txtDen1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 5;
            label2.Text = "Знаменатель";
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(95, 140);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(100, 23);
            txtNum2.TabIndex = 6;
            // 
            // txtDen2
            // 
            txtDen2.Location = new Point(95, 169);
            txtDen2.Name = "txtDen2";
            txtDen2.Size = new Size(100, 23);
            txtDen2.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 143);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 8;
            label3.Text = "Числитель";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 172);
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
            // btnSum
            // 
            btnSum.Location = new Point(320, 45);
            btnSum.Name = "btnSum";
            btnSum.Size = new Size(143, 23);
            btnSum.TabIndex = 18;
            btnSum.Text = "Сложить дроби";
            btnSum.UseVisualStyleBackColor = true;
            btnSum.Click += btnSum_Click;
            // 
            // btnMinus
            // 
            btnMinus.Location = new Point(320, 77);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(143, 23);
            btnMinus.TabIndex = 19;
            btnMinus.Text = "Вычесть из 1 дроби 2";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnUmn
            // 
            btnUmn.Location = new Point(320, 106);
            btnUmn.Name = "btnUmn";
            btnUmn.Size = new Size(143, 23);
            btnUmn.TabIndex = 20;
            btnUmn.Text = "Умножить 1 дробь на 2";
            btnUmn.UseVisualStyleBackColor = true;
            btnUmn.Click += bntUmn_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(320, 135);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(142, 23);
            btnDel.TabIndex = 21;
            btnDel.Text = "Разделить 1 дробь на 2";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnCleanNum1
            // 
            btnCleanNum1.Location = new Point(201, 42);
            btnCleanNum1.Name = "btnCleanNum1";
            btnCleanNum1.Size = new Size(75, 23);
            btnCleanNum1.TabIndex = 22;
            btnCleanNum1.Text = "Очистить";
            btnCleanNum1.UseVisualStyleBackColor = true;
            btnCleanNum1.Click += btnCleanNum1_Click;
            // 
            // btnCleanDen1
            // 
            btnCleanDen1.Location = new Point(201, 71);
            btnCleanDen1.Name = "btnCleanDen1";
            btnCleanDen1.Size = new Size(75, 23);
            btnCleanDen1.TabIndex = 23;
            btnCleanDen1.Text = "Очистить";
            btnCleanDen1.UseVisualStyleBackColor = true;
            btnCleanDen1.Click += btnCleanDen1_Click;
            // 
            // btnCleanNum2
            // 
            btnCleanNum2.Location = new Point(201, 143);
            btnCleanNum2.Name = "btnCleanNum2";
            btnCleanNum2.Size = new Size(75, 23);
            btnCleanNum2.TabIndex = 24;
            btnCleanNum2.Text = "Очистить";
            btnCleanNum2.UseVisualStyleBackColor = true;
            btnCleanNum2.Click += btnCleanNum2_Click;
            // 
            // btnCleanDen2
            // 
            btnCleanDen2.Location = new Point(201, 172);
            btnCleanDen2.Name = "btnCleanDen2";
            btnCleanDen2.Size = new Size(75, 23);
            btnCleanDen2.TabIndex = 25;
            btnCleanDen2.Text = "Очистить";
            btnCleanDen2.UseVisualStyleBackColor = true;
            btnCleanDen2.Click += btnCleanDen2_Click;
            // 
            // btnSrav
            // 
            btnSrav.Location = new Point(320, 164);
            btnSrav.Name = "btnSrav";
            btnSrav.Size = new Size(142, 23);
            btnSrav.TabIndex = 26;
            btnSrav.Text = "Сравнить дроби";
            btnSrav.UseVisualStyleBackColor = true;
            btnSrav.Click += btnSrav_Click;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 450);
            Controls.Add(txtAction);
            Controls.Add(btnSrav);
            Controls.Add(btnCleanDen2);
            Controls.Add(btnCleanNum2);
            Controls.Add(btnCleanDen1);
            Controls.Add(btnCleanNum1);
            Controls.Add(btnDel);
            Controls.Add(btnUmn);
            Controls.Add(btnMinus);
            Controls.Add(btnSum);
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
            Controls.Add(btnCreate2);
            Controls.Add(btnCreate1);
            Name = "Form1";
            Text = "Калькулятор дробей";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreate1;
        private Button btnCreate2;
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
        private Button btnSum;
        private Button btnMinus;
        private Button btnUmn;
        private Button btnDel;
        private Button btnCleanNum1;
        private Button btnCleanDen1;
        private Button btnCleanNum2;
        private Button btnCleanDen2;
        private Button btnSrav;
        private Label txtAction;
    }
}
