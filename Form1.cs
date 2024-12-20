namespace SimpleCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Formula.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        // �����{�^�������������Ƃ��̋��ʏ������\�b�h
        int count = 0;
        int operateNum = 0; // 1: +, 2: -, 3: �~(*), 4: ��(/)
        int num1 = 0;
        int num2 = 0;
        private void AppendNumberToFormula(object sender, EventArgs e)
        {
            // ���͂��ꂽ���������`�F�b�N
            if (count >= 10)
            {
                return;
            }

            string number = ((Button)sender).Text;
            // ���݂̕\���e�L�X�g
            string currentText = Formula.Text;

            // Case 1: ���� "0" �̏�ԂŐV���� "0" ���������ꍇ
            if (currentText == "0" && number == "0")
            {
                // ���̂܂� "0" ��\���i�ω��Ȃ��j
                Formula.Text = "0";
                return;
            }

            // Case 2: ���� "0" �̏�ԂŁA�V���Ȑ����i0�ȊO�j���������ꍇ
            if (currentText == "0" && number != "0")
            {
                // "0" ��u�������ĐV���Ȑ�����\��
                Formula.Text = number;
                return;
            }

            // Case 3: ���݂� "0" �ȊO�̏�ԂŁA�V���Ȑ����𑱂��ĉ������ꍇ
            // �O��̐�����̖����ɍ���̐���������
            Formula.Text = currentText + number;
            count++;
        }

        private void BtnSeven_Click(object sender, EventArgs e)
        {

        }

        private void BtnAddition_Click(object sender, EventArgs e)
        {
            operateNum = 1;
            num1 = int.Parse(Formula.Text);
            count = 0;
            Formula.Text += " + ";
        }

        private void BtnSubtraction_Click(object sender, EventArgs e)
        {
            operateNum = 2;
            num1 = int.Parse(Formula.Text);
            count = 0;
            Formula.Text += " - ";
        }

        private void BtnMultiplication_Click(object sender, EventArgs e)
        {
            operateNum = 3;
            num1 = int.Parse(Formula.Text);
            count = 0;
            Formula.Text += " �~ ";
        }

        private void BtnDivision_Click(object sender, EventArgs e)
        {
            operateNum = 4;
            num1 = int.Parse(Formula.Text);
            count = 0;
            Formula.Text += " �� ";
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {   

            int operatorIndex = Formula.Text.IndexOfAny(new char[] { '+', '-', '�~', '��' });
            // ���Z�q���琔����2�����ڈȍ~���擾����
            num2 = int.Parse(Formula.Text.Substring(operatorIndex + 2));

            // case1: ���Z
            if (operateNum == 1)
            {
                Result.Text = (num1 + num2).ToString();
            }

            // case2: ���Z
            if (operateNum == 2)
            {
                Result.Text = (num1 - num2).ToString();
            }

            // case3: ��Z
            if (operateNum == 3)
            {
                Result.Text = (num1 * num2).ToString();
            }

            // case4: ���Z
            if (operateNum == 4)
            {
                if (num2 == 0)
                {
                    return;
                }
                Result.Text = (num1 / num2).ToString();
            }
        }
    }
}


