namespace SimpleCalc
{
    public partial class Form1 : Form
    {
        int count = 0;
        int operateNum = 0; // 1: +, 2: -, 3: �~(*), 4: ��(/)
        long num1 = 0;
        long num2 = 0;
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

            // �X�y�[�X��؂�ŕ������A�Ō�̃g�[�N�����擾
            // ��: "124 + 0" �� tokens = ["124", "+", "0"]
            // �Ō�̃g�[�N���� tokens[tokens.Length - 1] = "0"
            string[] tokens = currentText.Split(' ');

            // ��1���Ɖ��Z�q�����͍ς݂ŁA��2����0�����͂���Ă���ꍇ
            if (tokens[tokens.Length - 1] == "0" && Formula.Text.Contains("+") || Formula.Text.Contains("-") || Formula.Text.Contains("�~") || Formula.Text.Contains("��"))
            {
                // ���݂̕�����̒������擾
                int length = currentText.Length;
                // �Ō��1�������폜���Ă��� number ��ǉ�
                // ��: "150 + 0" (length=7) �� Substring(0, 6) = "150 + "
                // ���̌� "1" ������ �� "150 + 1"
                string replacedText = currentText.Substring(0, length - 1) + number;
                // Label�ɔ��f
                Formula.Text = replacedText;
                return;
            }

            // Case 1: ���� "0" �̏�ԂŐV���� "0" ���������ꍇ
            if (currentText == "0"  && number == "0")
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

        // ���Z�{�^���̏���
        private void BtnAddition_Click(object sender, EventArgs e)
        {
            operateNum = 1;
            num1 = long.Parse(Formula.Text);
            count = 0;
            Formula.Text += " + ";
        }

        // ���Z�{�^���̏���
        private void BtnSubtraction_Click(object sender, EventArgs e)
        {
            operateNum = 2;
            num1 = long.Parse(Formula.Text);
            count = 0;
            Formula.Text += " - ";
        }

        // ��Z�{�^���̏���
        private void BtnMultiplication_Click(object sender, EventArgs e)
        {
            operateNum = 3;
            num1 = long.Parse(Formula.Text);
            count = 0;
            Formula.Text += " �~ ";
        }

        // ���Z�{�^���̏���
        private void BtnDivision_Click(object sender, EventArgs e)
        {
            operateNum = 4;
            num1 = long.Parse(Formula.Text);
            count = 0;
            Formula.Text += " �� ";
        }

        // �C�R�[���{�^���̏���
        private void BtnEqual_Click(object sender, EventArgs e)
        {   

            int operatorIndex = Formula.Text.IndexOfAny(new char[] { '+', '-', '�~', '��' });
            // ���Z�q���琔����2�����ڈȍ~���擾����
            num2 = long.Parse(Formula.Text.Substring(operatorIndex + 2));

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


