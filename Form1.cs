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

        // 数字ボタンを押下したときの共通処理メソッド
        private void AppendNumberToFormula(object sender, EventArgs e)
        {
            int length = Formula.Text.Length;

            if (length >= 10)
            {
                return;
            }


            string number = ((Button)sender).Text;
            // 現在の表示テキスト
            string currentText = Formula.Text;

            // Case 1: 現在 "0" の状態で新たに "0" を押した場合
            if (currentText == "0" && number == "0")
            {
                // そのまま "0" を表示（変化なし）
                Formula.Text = "0";
                return;
            }

            // Case 2: 現在 "0" の状態で、新たな数字（0以外）を押した場合
            if (currentText == "0" && number != "0")
            {
                // "0" を置き換えて新たな数字を表示
                Formula.Text = number;
                return;
            }

            // Case 3: 現在が "0" 以外の状態で、新たな数字を続けて押した場合
            // 前回の数字列の末尾に今回の数字を結合
            Formula.Text = currentText + number;
        }

        private void BtnSeven_Click(object sender, EventArgs e)
        {

        }
    }
}
