namespace WinFormsApp1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Word1.KeyDown += new KeyEventHandler(TextBox_KeyDown);
            Word2.KeyDown += new KeyEventHandler(TextBox_KeyDown);
            button1.KeyDown += new KeyEventHandler(TextBox_KeyDown);
            button2.KeyDown += new KeyEventHandler(TextBox_KeyDown);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                this.SelectNextControl((Control)sender, true, true, true, true);
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Up)
            {
                this.SelectNextControl((Control)sender, false, true, true, true);
                e.SuppressKeyPress = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Word1.Text = null;
            Word2.Text = null;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String slovo1, slovo2;
            slovo1 = Word1.Text;
            slovo2 = Word2.Text;
            Properties.Settings.Default.slovo1 = slovo1;
            Properties.Settings.Default.slovo2 = slovo2;
            Properties.Settings.Default.Save();
            if (Logic.Space(slovo1, slovo2))
            {
                var message = Logic.Check(slovo1, slovo2);
                label3.Text = message;
                label3.Visible = true;
            }
            else
            {
                return;
            }
        }
    }
    public class Logic
    {
        public static string Check(String word_1, String word_2)
        {
            if (word_1.Length == word_2.Length)
            {
                char[] cword1 = word_1.ToCharArray();
                char[] cword2 = word_2.ToCharArray();
                for (int i = 0; i < word_1.Length; i++)
                {
                    char s;
                    if (i % 2 != 0)
                    {
                        s = word_1[i];
                        cword1[i] = word_2[i];
                        cword2[i] = s;
                    }
                }
                word_1 = new string(cword1);
                word_2 = new string(cword2);
                return "Слово 1: " + word_1 + " Слово 2: " + word_2;
            }
            else
            {
                return "Слова разной длины";
            }
        }
        public static bool Space(String word1,String word2)
        {
            bool isWord1Valid = !string.IsNullOrWhiteSpace(word1) && word1.Split(' ').Length == 1;
            bool isWord2Valid = !string.IsNullOrWhiteSpace(word2) && word2.Split(' ').Length == 1;
            if(isWord1Valid && isWord2Valid)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
