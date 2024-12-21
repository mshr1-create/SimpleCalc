namespace SimpleCalc
{
    public partial class Form1 : Form
    {
        int count = 0;
        int operateNum = 0; // 1: +, 2: -, 3: ×(*), 4: ÷(/)
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

        // 数字ボタンを押下したときの共通処理メソッド
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

            // スペース区切りで分割し、最後のトークンを取得
            // 例: "124 + 0" → tokens = ["124", "+", "0"]
            // 最後のトークンは tokens[tokens.Length - 1] = "0"
            string[] tokens = currentText.Split(' ');

            // 第1項と演算子が入力済みで、第2項に0が入力されている場合
            if (tokens[tokens.Length - 1] == "0" && Formula.Text.Contains("+") || Formula.Text.Contains("-") || Formula.Text.Contains("×") || Formula.Text.Contains("÷"))
            {
                // 現在の文字列の長さを取得
                int length = currentText.Length;
                // 最後の1文字を削除してから number を追加
                // 例: "150 + 0" (length=7) → Substring(0, 6) = "150 + "
                // その後 "1" を結合 → "150 + 1"
                string replacedText = currentText.Substring(0, length - 1) + number;
                // Labelに反映
                Formula.Text = replacedText;
                return;
            }

            // Case 1: 現在 "0" の状態で新たに "0" を押した場合
            if (currentText == "0"  && number == "0")
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

        // 加算ボタンの処理
        private void BtnAddition_Click(object sender, EventArgs e)
        {
            operateNum = 1;
            num1 = long.Parse(Formula.Text);
            count = 0;
            Formula.Text += " + ";
        }

        // 減算ボタンの処理
        private void BtnSubtraction_Click(object sender, EventArgs e)
        {
            operateNum = 2;
            num1 = long.Parse(Formula.Text);
            count = 0;
            Formula.Text += " - ";
        }

        // 乗算ボタンの処理
        private void BtnMultiplication_Click(object sender, EventArgs e)
        {
            operateNum = 3;
            num1 = long.Parse(Formula.Text);
            count = 0;
            Formula.Text += " × ";
        }

        // 除算ボタンの処理
        private void BtnDivision_Click(object sender, EventArgs e)
        {
            operateNum = 4;
            num1 = long.Parse(Formula.Text);
            count = 0;
            Formula.Text += " ÷ ";
        }

        // イコールボタンの処理
        private void BtnEqual_Click(object sender, EventArgs e)
        {   

            int operatorIndex = Formula.Text.IndexOfAny(new char[] { '+', '-', '×', '÷' });
            // 演算子から数えて2文字目以降を取得する
            num2 = long.Parse(Formula.Text.Substring(operatorIndex + 2));

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


