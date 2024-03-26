namespace MyType
{
    public partial class Form1 : Form
    {
        Fraction fraction_1;
        Fraction fraction_2;

        public Form1()
        {
            InitializeComponent();
            //��������� ���� �� �������� ������
            this.StartPosition = FormStartPosition.CenterScreen;

            //�������� ������ ��� �������� � �������
            cmbOperations.Enabled = false;


        }

        private void create_fraction1()
        {

            try
            {
                fraction_1 = new Fraction(int.Parse(txtNum1.Text), (int.Parse(txtDen1.Text)));
                fraction_1.normilize();
                txtFr1.Text = fraction_1.ToString();

                update();

            }
            catch (FormatException)
            {
                //MessageBox.Show("�������� ����", "������");
            }
            catch (OverflowException)
            {
                //MessageBox.Show("������� ������� �����", "������");
            }

        }
        private void create_fraction2()
        {

            try
            {
                fraction_2 = new Fraction(int.Parse(txtNum2.Text), (int.Parse(txtDen2.Text)));
                fraction_2.normilize();
                txtFr2.Text = fraction_2.ToString();

                update();
            }
            catch (FormatException)
            {
                //MessageBox.Show("�������� ����", "������");
            }
            catch (OverflowException)
            {
                //MessageBox.Show("������� ������� �����", "������");
            }

        }

        private void update()
        {
            if (isNullFraction(fraction_1) || isNullFraction(fraction_2))
            {
                setActiveBtn(false);
            }
            else
            {
                setActiveBtn(true);
            }
        }
        //����� �� �������� ������������� ������
        private bool isNullFraction(Fraction fr)
        {
            if (fr == null)
                return true;
            else
                return false;
        }
        //���������� ������
        private void setActiveBtn(bool bl)
        {
            if (bl)
            {
                cmbOperations.Enabled = true;
            }
            else
            {
                cmbOperations.Enabled = false;
            }
        }




        private void btnCleanNum1_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
        }

        private void btnCleanDen1_Click(object sender, EventArgs e)
        {
            txtDen1.Text = "";
        }

        private void btnCleanNum2_Click(object sender, EventArgs e)
        {
            txtNum2.Text = "";
        }

        private void btnCleanDen2_Click(object sender, EventArgs e)
        {
            txtDen2.Text = "";
        }

        private void btnSrav_Click(object sender, EventArgs e)
        {
            txtResult.Text = fraction_1 + fraction_1.sravn(fraction_2) + fraction_2;
            txtAction.Text = "���������";

        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            switch (cmbOperations.Text)
            {
                case "+":
                    Fraction res1 = fraction_1 + fraction_2;
                    txtResult.Text = res1.ToString();
                    txtAction.Text = "��������";
                    break;
                case "-":
                    Fraction res2 = fraction_1 - fraction_2;
                    txtResult.Text = res2.ToString();
                    txtAction.Text = "���������";
                    break;
                case "*":
                    Fraction res3 = fraction_1 * fraction_2;
                    txtResult.Text = res3.ToString();
                    txtAction.Text = "���������";
                    break;
                case "/":
                    Fraction res4 = fraction_1 / fraction_2;
                    txtResult.Text = res4.ToString();
                    txtAction.Text = "�������";
                    break;
                case "��������":
                    txtResult.Text = fraction_1 + fraction_1.sravn(fraction_2) + fraction_2;
                    txtAction.Text = "���������";
                    break;
                default:
                    txtAction.Text = "����������� ��������";
                    break;
            }
        }

        private void switchOper()
        {
            if ((!isNullFraction(fraction_1)) && (!isNullFraction(fraction_2)))
                switch (cmbOperations.Text)
                {
                    case "+":
                        Fraction res1 = fraction_1 + fraction_2;
                        txtResult.Text = res1.ToString();
                        txtAction.Text = "��������";
                        break;
                    case "-":
                        Fraction res2 = fraction_1 - fraction_2;
                        txtResult.Text = res2.ToString();
                        txtAction.Text = "���������";
                        break;
                    case "*":
                        Fraction res3 = fraction_1 * fraction_2;
                        txtResult.Text = res3.ToString();
                        txtAction.Text = "���������";
                        break;
                    case "/":
                        Fraction res4 = fraction_1 / fraction_2;
                        txtResult.Text = res4.ToString();
                        txtAction.Text = "�������";
                        break;
                    case "��������":
                        txtResult.Text = fraction_1 + fraction_1.sravn(fraction_2) + fraction_2;
                        txtAction.Text = "���������";
                        break;
                    default:
                        txtAction.Text = "����������� ��������";
                        break;
                }
        }
        ////////////////////////////////////////////////////////////////
        private void txtNum1_TextChanged(object sender, EventArgs e)
        {
            create_fraction1();
            if ((!isNullFraction(fraction_1)) && (!isNullFraction(fraction_2)))
            {
                txtFr1.Text = fraction_1.ToString();
            }
            switchOper();
        }

        private void txtDen1_TextChanged(object sender, EventArgs e)
        {
            create_fraction1();
            if ((!isNullFraction(fraction_1)) && (!isNullFraction(fraction_2)))
            {
                txtFr1.Text = fraction_1.ToString();
            }
            switchOper();
        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {
            create_fraction2();
            if ((!isNullFraction(fraction_1)) && (!isNullFraction(fraction_2)))
            {
                txtFr2.Text = fraction_2.ToString();
            }
            else
            {
                cleanOutput();
            }
            switchOper();
        }

        private void txtDen2_TextChanged(object sender, EventArgs e)
        {
            create_fraction2();
            if ((!isNullFraction(fraction_1)) && (!isNullFraction(fraction_2)))
            {
                txtFr2.Text = fraction_2.ToString();
            }
            else
            {
                cleanOutput();
            }
            switchOper();
        }

        private void cmbOperations_SelectedIndexChanged(object sender, EventArgs e)
        {
            switchOper();
        }
        private void cleanOutput()
        {
            if (isNullFraction(fraction_1))
            {
                txtFr1.Text = "";
            }
            else if (isNullFraction(fraction_2))
            {
                txtFr2.Text = "";
            }

            //    txtResult.Text = "";
            //txtFr1.Text = "";
            //txtFr2.Text = "";
            //txtAction.Text = "";
        }
        ////////////////////////////////////////////////////////////////
    }




    class Fraction //�����
    {
        private int numerator; //���������
        private int denominator; //�����������

        public int getNumerator()
        {
            return numerator;
        }
        public int getDenominator()
        {
            return denominator;
        }
        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
            normilize();
        }
        public static Fraction operator +(Fraction a, Fraction b)
        {
            int newNumerator = a.numerator * b.denominator + b.numerator * a.denominator;
            int newDenominator = a.denominator * b.denominator;
            return new Fraction(newNumerator, newDenominator);
        }
        public static Fraction operator -(Fraction a, Fraction b)
        {
            int newNumerator = a.numerator * b.denominator - b.numerator * a.denominator;
            int newDenominator = a.denominator * b.denominator;
            return new Fraction(newNumerator, newDenominator);
        }
        public static Fraction operator /(Fraction a, Fraction b)
        {
            int newNumerator = a.numerator * b.denominator;
            int newDenominator = a.denominator * b.numerator;
            return new Fraction(newNumerator, newDenominator);
        }
        public static Fraction operator *(Fraction a, Fraction b)
        {
            int newNumerator = a.numerator * b.numerator;
            int newDenominator = a.denominator * b.denominator;
            return new Fraction(newNumerator, newDenominator);
        }



        public override string ToString()
        {
            if (numerator == 0 || denominator == 0)
                return "0";
            else
                return $"{numerator}/{denominator}";
        }

        public void normilize()
        {
            //��� ������
            if (numerator < 0 && denominator < 0)
            {
                numerator = Math.Abs(numerator);
                denominator = Math.Abs(denominator);
            }
            //����� � �����������
            else if (denominator < 0)
            {
                denominator = Math.Abs(denominator);
                numerator = numerator * (-1);
            }
            //���������� ����������� � �����������
            int gcd = findMax(Math.Abs(numerator), Math.Abs(denominator));
            if (gcd > 1)
            {
                numerator /= gcd;
                denominator /= gcd;
            }
        }
        public int findMax(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        public bool isCorrectFraction()
        {
            if (denominator == 0 || numerator > denominator)
                return false;
            else
                return true;
        }
        public string sravn(Fraction fr2)
        {
            if (this.denominator == fr2.getNumerator()) //����������� ����������
            {
                int Num1 = this.numerator;
                int Num2 = fr2.getNumerator();
                if (Num1 > Num2)
                {
                    return ">";
                }
                else if (Num1 < Num2)
                {
                    return "<";
                }
                else
                    return "=";
            }
            else //����������� ������
            {
                //���������� �������� � ������ �����������
                int Den1 = this.denominator;
                int Den2 = fr2.getDenominator();

                int Num1 = this.numerator;
                int Num2 = fr2.getNumerator();

                Num1 = Num1 * Den2;
                Num2 = Num2 * Den1;

                Den1 = Den1 * Den2;
                Den2 = Den1;
                if (Num1 > Num2)
                {
                    return " > ";
                }
                else if (Num1 < Num2)
                {
                    return " < ";
                }
                else
                    return " = ";
            }
        }
    }
}
