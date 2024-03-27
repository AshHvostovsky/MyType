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

            //�������� ����������� ��� �������� � �������
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
                txtFr1.Text = "";
                txtResult.Text = "";
                update();
                //MessageBox.Show("�������� ����", "������");
            }
            catch (OverflowException)
            {
                txtFr1.Text = "";
                txtResult.Text = "";
                update();
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
                txtFr2.Text = "";
                txtResult.Text = "";
                update();
                //MessageBox.Show("�������� ����", "������");
            }
            catch (OverflowException)
            {
                txtFr2.Text = "";
                txtResult.Text = "";
                update();
                //MessageBox.Show("������� ������� �����", "������");
            }

        }

        private void update()
        {
            if ((((!isNormalInput1()) || (!isNormalInput2())) || (isNullFraction(fraction_1) || isNullFraction(fraction_2)))) //���� ����� �� ����������, �� ��������� ��������
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



        private void switchOper()
        {
            if ((isNormalInput1() && isNormalInput2()) && (!isNullFraction(fraction_1)) && (!isNullFraction(fraction_2)))
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
        /*����� ������ ��� ������� ��������� ��������� �����*/
        private void txtNum1_TextChanged(object sender, EventArgs e)
        {
            create_fraction1();
            if (!isNullFraction(fraction_1) && isNormalInput1())
            {
                txtFr1.Text = fraction_1.ToString();

            }
            switchOper();

        }

        private void txtDen1_TextChanged(object sender, EventArgs e)
        {
            create_fraction1();
            if (!isNullFraction(fraction_1) && isNormalInput1())
            {
                txtFr1.Text = fraction_1.ToString();

            }
            switchOper();

        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {
            create_fraction2();
            if ((!isNullFraction(fraction_2)) && isNormalInput2())
            {
                txtFr2.Text = fraction_2.ToString();

            }
            switchOper();
        }

        private void txtDen2_TextChanged(object sender, EventArgs e)
        {
            create_fraction2();
            if (!isNullFraction(fraction_2) && isNormalInput2())
            {
                txtFr2.Text = fraction_2.ToString();

            }
            switchOper();
        }
        /*��������� �������*/

        //����� ������ �������� ��� �������

        private void cmbOperations_SelectedIndexChanged(object sender, EventArgs e)
        {
            switchOper();
        }
        //
        //
        //����� �� �������� ������������ ������ � ����� ����� 1
        private bool isNormalInput1()
        {
            try
            {
                int.Parse(txtNum1.Text);
                int.Parse(txtDen1.Text);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
            catch (OverflowException)
            {
                return false;
            }
        }
        //����� �� �������� ������������ ������ � ����� ����� 2
        private bool isNormalInput2()
        {
            try
            {
                int.Parse(txtNum2.Text);
                int.Parse(txtDen2.Text);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
            catch (OverflowException)
            {
                return false;
            }
        }
    }

}