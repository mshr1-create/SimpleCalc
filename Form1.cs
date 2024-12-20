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

        // 数字ボタンを押下したときの共通処理メソッド
        int count = 0;
        int operateNum = 0; // 1: +, 2: -, 3: ×(*), 4: ÷(/)
        int num1 = 0;
        int num2 = 0;
        private void AppendNumberToFormula(object sender, EventArgs e)
        {
            // 入力された文字数をチェック
            if (count >= 10)
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
            Formula.Text += " × ";
        }

        private void BtnDivision_Click(object sender, EventArgs e)
        {
            operateNum = 4;
            num1 = int.Parse(Formula.Text);
            count = 0;
            Formula.Text += " ÷ ";
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {   

            int operatorIndex = Formula.Text.IndexOfAny(new char[] { '+', '-', '×', '÷' });
            // 演算子から数えて2文字目以降を取得する
            num2 = int.Parse(Formula.Text.Substring(operatorIndex + 2));

            // case1: 加算
            if (operateNum == 1)
            {
                Result.Text = (num1 + num2).ToString();
            }

            // case2: 減算
            if (operateNum == 2)
            {
                Result.Text = (num1 - num2).ToString();
            }

            // case3: 乗算
            if (operateNum == 3)
            {
                Result.Text = (num1 * num2).ToString();
            }

            // case4: 除算
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


