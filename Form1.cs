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
            Formula.Text = "0";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        // �����{�^�������������Ƃ��̋��ʏ������\�b�h
        private void AppendNumberToFormula(object sender, EventArgs e)
        {
            int length = Formula.Text.Length;

            if (length >= 10)
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
        }

        private void BtnSeven_Click(object sender, EventArgs e)
        {

        }
    }
}
