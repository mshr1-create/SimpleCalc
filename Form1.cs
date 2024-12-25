using System.Drawing.Text;

namespace SimpleCalc
{
    public partial class FormSimpleCalc : Form
    {
        int count = 0;
        int operateNum = 0; // 1: +, 2: -, 3: �~(*), 4: ��(/)
        long num1 = 0;
        long num2 = 0;
        public FormSimpleCalc()
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
            if (tokens[tokens.Length - 1] == "0" && (Formula.Text.Contains("+") || Formula.Text.Contains("-") || Formula.Text.Contains("�~") || Formula.Text.Contains("��")))
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

        private void SetOperator(int opNum, string opSymbol)
        {
            int operatorIndex = Formula.Text.IndexOfAny(new char[] { '+', '-', '�~', '��' });

            // ��2�����󗓂ŉ��Z�q�����łɂ���ꍇ �� ���Z�q�Ƃ��̑O��̃X�y�[�X���폜
            if (operatorIndex != -1 && (Formula.Text.Substring(operatorIndex + 2).Equals(""))
                && (Formula.Text.Contains("+") || Formula.Text.Contains("-")
                || Formula.Text.Contains("�~") || Formula.Text.Contains("��")))
            {
                int startIndex = Math.Max(0, operatorIndex - 1);
                Formula.Text = Formula.Text.Remove(startIndex, 3).TrimEnd();
                Result.Text = "";
                count = 0;
            }

            operateNum = opNum;

            if (!string.IsNullOrEmpty(Formula.Text))
            {
                num1 = long.Parse(Formula.Text);
            }

            count = 0;
            Formula.Text += opSymbol;

        }

            // ���Z�{�^���̏���
            private void BtnAddition_Click(object sender, EventArgs e)
            {
                SetOperator(1, " + ");
            }



            // ���Z�{�^���̏���
            private void BtnSubtraction_Click(object sender, EventArgs e)
            {
                SetOperator(2, " - ");
            }

            // ��Z�{�^���̏���
            private void BtnMultiplication_Click(object sender, EventArgs e)
            {
                SetOperator(3, " �~ ");
            }

            // ���Z�{�^���̏���
            private void BtnDivision_Click(object sender, EventArgs e)
            {
                SetOperator(4, " �� ");
            }

            // �C�R�[���{�^���̏���
        private void BtnEqual_Click(object sender, EventArgs e)
        {
            int operatorIndex = Formula.Text.IndexOfAny(new char[] { '+', '-', '�~', '��' });
            // ���Z�q���琔����2�����ڈȍ~���擾����
            if (Formula.Text.Substring(operatorIndex + 2).Equals(""))
            {
                return;
            }
            else
            {
                num2 = long.Parse(Formula.Text.Substring(operatorIndex + 2));
            }


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
                    Result.Text = "0�Ŋ��邱�Ƃ͂ł��܂���";
                    BtnZero.Enabled = false;
                    BtnOne.Enabled = false;
                    BtnTwo.Enabled = false;
                    BtnThree.Enabled = false;
                    BtnFour.Enabled = false;
                    BtnFive.Enabled = false;
                    BtnSix.Enabled = false;
                    BtnSeven.Enabled = false;
                    BtnEight.Enabled = false;
                    BtnNine.Enabled = false;
                    BtnClearEntry.Enabled = false;
                    return;
                }
                Result.Text = (num1 / num2).ToString();
            }

            // �C�R�[���{�^����������A0�`9�̃{�^���������ł��Ȃ��悤�ɂ���
            BtnZero.Enabled = false;
            BtnOne.Enabled = false;
            BtnTwo.Enabled = false;
            BtnThree.Enabled = false;
            BtnFour.Enabled = false;
            BtnFive.Enabled = false;
            BtnSix.Enabled = false;
            BtnSeven.Enabled = false;
            BtnEight.Enabled = false;
            BtnNine.Enabled = false;
            BtnClearEntry.Enabled = false;
        }

        private void BtnClearEntry_Click(object sender, EventArgs e)
        {
            int operatorIndex = Formula.Text.IndexOfAny(new char[] { '+', '-', '�~', '��' });
            // ���Z�q��T��
            if (operatorIndex == -1)
            {
                // ���Z�q��������Ȃ��ꍇ�A�S�ăN���A
                Formula.Text = "";
                Result.Text = "";
                count = 0;
            }
            // ���Z�q�܂œ��͂���Ă���ꍇ�A�O��̋󔒂��܂߂ĉ��Z�q���폜
            else if (Formula.Text.Substring(operatorIndex + 2).Equals(""))
            {
                // ��2�������͂���Ă��Ȃ� => ���Z�q�ƑO��X�y�[�X���폜
                // ���S�Ƀ`�F�b�N (operatorIndex > 0)
                int startIndex = Math.Max(0, operatorIndex - 1);
                // Remove�� [startIndex] ���� [count] �������폜����
                Formula.Text = Formula.Text.Remove(startIndex, 3).TrimEnd();
                Result.Text = "";
                count = 0;
            }
            else
            {
                // ���Z�q�����������ꍇ�A���Z�q�ȍ~���폜
                Formula.Text = Formula.Text.Substring(0, operatorIndex + 2);
                Result.Text = "";
                count = 0;
            }
        }

        private void BtnAllClear_Click(object sender, EventArgs e)
        {
            //  AC�{�^����������A��1���Ɖ��Z�q�A��2���A�v�Z���ʂ����ׂč폜�B0�`9�̃{�^���������ł���悤�ɂ���
            Formula.Text = "";
            Result.Text = "";
            count = 0;
            BtnZero.Enabled = true;
            BtnOne.Enabled = true;
            BtnTwo.Enabled = true;
            BtnThree.Enabled = true;
            BtnFour.Enabled = true;
            BtnFive.Enabled = true;
            BtnSix.Enabled = true;
            BtnSeven.Enabled = true;
            BtnEight.Enabled = true;
            BtnNine.Enabled = true;
            BtnClearEntry.Enabled = true;
        }
    }
}


