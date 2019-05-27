using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab14_Tim
{
    public partial class MainForm : Form
    {
        double[] StaticFruquencyENG = new double[26] 
        {   0.081, 0.016, 0.032, 0.036,
            0.123, 0.023, 0.016, 0.051,
            0.071, 0.001, 0.005, 0.040,
            0.022, 0.072, 0.079, 0.023,
            0.002, 0.060, 0.066, 0.096,
            0.031, 0.009, 0.020, 0.002,
            0.019,0.001};
        double[] StaticFruquencyRUS = new double[33]
        {   0.0801, 0.0159, 0.0454, 0.0170,//абвг
            0.0298, 0.0845, 0.0004, 0.0094,//деёж
            0.0165, 0.0735, 0.0121, 0.0349,//зийк
            0.0440,//л
            0.0321, 0.0670, 0.1097, 0.0281,//мноп
            0.0473, 0.0547, 0.0626, 0.0262, //рсту
            0.00260, 0.0097, 0.0048, 0.0144, 0.0073,//фхцч
            0.0036, 0.0004, 0.0190, 0.0174,//шщъы
            0.0032, 0.0640, 0.0201};//

        string AlphabetENG = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string AlphabetRUS = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        string AlphabetENGSmall = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        string AlphabetRUSSmall = "abcdefghijklmnopqrstuvwxyz";




        public MainForm()
        {
            InitializeComponent();
        }

        private string ProccesAsociationAlphabet(string encript_text,string Alphabet,double[] StaticFruquency)
        {
            SortedDictionary<char, double> AlphabetMap = new SortedDictionary<char, double>();
            double[] Frequency = new double[Alphabet.Length];
            int lenght_clear_text = 0;
            for (int i = 0; i < Alphabet.Length*2; i++)
            {
                AlphabetMap.Add(Alphabet[i], StaticFruquency[i]);
            }

            char[] DeCriptAlphabet = new char[Alphabet.Length];
            for (int i = 0; i < Alphabet.Length; i++)
            {
                Frequency[i] = 0;
            }
            foreach (char a in encript_text)//считаем кол-во символов без знаков пунктуации и пробела плюс частота
            {
                for (int i = 0; i < Alphabet.Length; i++)
                {
                    if (a == Alphabet[i])
                    {
                        lenght_clear_text++;
                        Frequency[i]++;
                    }
                }
            }
            for (int i = 0; i < Alphabet.Length; i++)
            {
                Frequency[i] = Frequency[i] / lenght_clear_text;
            }
            for (int k = 0; k < Alphabet.Length; k++)
            {
                double count = 1;
                int index = 0;
                for (int i = 0; i < Alphabet.Length; i++)
                {
                    double difference;
                    if (Frequency[k] > StaticFruquency[i])
                    {
                        difference = Frequency[k] - StaticFruquency[i];
                    }
                    else
                    {
                        difference = StaticFruquency[i] - Frequency[k];
                    }
                    if (count > difference)
                    {
                        count = difference;
                        index = i;
                    }
                }
                DeCriptAlphabet[k] = Alphabet[index];
            }
            string DeCriptAlphabetStr = new string(DeCriptAlphabet);
            string outstr = null;

            for (int i = 0; i < AlphabetENG.Length; i++)
            {
                outstr += "[ ";
                outstr += Alphabet[i];
                outstr = outstr + "][" + Frequency[i] + "]";
                outstr += "[ ";
                outstr += DeCriptAlphabet[i];
                outstr = outstr + "][" + AlphabetMap[DeCriptAlphabet[i]] + "]";
                outstr += "\r\n";
            }

            ShowSwapBox.Text = outstr;

            string open_text = null;
            foreach (var a in encript_text)
            {
                bool flag = false;
                for (int i = 0; i < Alphabet.Length; i++)
                {
                    if (a == Alphabet[i])
                    {
                        flag = true;
                        open_text = open_text + DeCriptAlphabet[i];
                    }
                }
                if (!flag)
                {
                    open_text = open_text + a;
                }
            }
            DecryptTextBox.Text = open_text;

            for (int i = 0; i < Alphabet.Length; i++)
            {
                double y = 0.0;
                int index=0;
                y = Frequency[i];
                for (int k = 0; k < Alphabet.Length; k++)
                {
                    if (Alphabet[k] == DeCriptAlphabet[i])
                    {
                        index = k;
                    }
                }
                string x = Convert.ToString(Alphabet[i]);
                GistogramChart.Series[0].Points.AddXY(x, y);
                GistogramChart.Series[1].Points.AddXY(x, StaticFruquency[index]);
            }
            return DeCriptAlphabetStr;
        }

        private void ProcessShifts(string Alphabet, string DeCriptAlphabet)
        {
            int[,] probability_of_shifts = new int[Alphabet.Length, 2];
            int[] Shifts = new int[Alphabet.Length];
            for (int i = 0; i < Alphabet.Length; i++)
            {
                int shift;
                int index = 0;
                for (int k = 0; k < Alphabet.Length; k++)
                {
                    if (DeCriptAlphabet[i] == Alphabet[k])
                    {
                        index = k;
                    }
                }
                shift = index - i;
                if ((shift) < 0)
                {
                    shift = (shift + Alphabet.Length) % Alphabet.Length;
                }
                Shifts[i] = shift;
            }
            int count_number = 0;
            for (int i = 0; i < Alphabet.Length; i++)
            {
                int index = 0;
                bool flag = false;
                for (int k = 0; k < count_number; k++)
                {
                    if (probability_of_shifts[k, 0] == Shifts[i])
                    {
                        flag = true;
                        index = k;

                    }
                }
                if (flag == false)
                {
                    probability_of_shifts[count_number, 0] = Shifts[i];
                    probability_of_shifts[count_number, 1]++;
                    count_number++;
                }
                else
                {
                    probability_of_shifts[index, 1]++;
                }
            }
            string outstr = null;
            for (int i = 0; i < count_number; i++)
            {
                outstr += "[ ";
                outstr += probability_of_shifts[i, 0] + "][" + probability_of_shifts[i, 1] + "]";
                outstr += "\r\n";
            }

            ProbabilityShiftsBox.Text = outstr;
        }

        private string ChooseAlphabet()
        {
            int count_eng_symbols=0;
            int count_rus_symbols=0;
            string encript_text = EncryptTextBox.Text;
            foreach (var a in encript_text)
            {
                for (int k = 0; k < AlphabetENG.Length; k++)
                {
                    if (a == AlphabetENG[k])
                    {
                        count_eng_symbols++;
                    }
                    if (a == AlphabetENGSmall[k])
                    {
                        count_eng_symbols++;
                    }
                }
                for (int k = 0; k < AlphabetRUS.Length; k++)
                {
                    if (a == AlphabetRUS[k])
                    {
                        count_rus_symbols++;
                    }
                    if (a == AlphabetRUSSmall[k])
                    {
                        count_eng_symbols++;
                    }
                }
            }
            if (count_eng_symbols > count_rus_symbols)
            {
                return "ENG";
            }
            else
            {
                return "RUS";
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (EncryptTextBox.Text != String.Empty)
            {
                MessageBox.Show("Форма для текста не пуста, при загрузке из файла, все данные из нее удалятся!");
            }


            OpenFileDialog File1 = new OpenFileDialog();
            if (File1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(File1.FileName);

                EncryptTextBox.Clear();
                EncryptTextBox.Paste(sr.ReadToEnd());
                sr.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double temp = 0;
            for (int i=0;i<AlphabetRUS.Length;i++)
            {
                temp += StaticFruquencyRUS[i];
            }
            MessageBox.Show(Convert.ToString(temp));
            string encript_text = EncryptTextBox.Text;
            string DeCriptAlphabet=null;
            if (ChooseAlphabet() == "RUS")
            {
                DeCriptAlphabet = ProccesAsociationAlphabet(encript_text, AlphabetRUS, StaticFruquencyRUS);
                ProcessShifts(AlphabetRUS,DeCriptAlphabet);
            }
            else
            {
                DeCriptAlphabet = ProccesAsociationAlphabet(encript_text, AlphabetENG, StaticFruquencyENG);
                ProcessShifts(AlphabetENG, DeCriptAlphabet);
            }
            
            KeyBox.Text = "Association";
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            EncryptTextBox.Clear();
            DecryptTextBox.Clear();
        }

        private void KeyBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string alphabet;
            if (ChooseAlphabet() == "ENG")
            {
                alphabet = AlphabetENG;
            }
            else
            {
                alphabet = AlphabetRUS;
            }
            string key_str = KeyBox.Text;
            int key = 0;
            string encript_text= EncryptTextBox.Text;
            string open_text = null;
            if (key_str != "Association")
            {
                key = Convert.ToInt32(key_str);
            }
            key = key % alphabet.Length;
            foreach ( var symbol in encript_text)
            {
                bool flag = false;
                int index = 0;
                for (int i=0;i< alphabet.Length;i++)
                {
                    if  (symbol== alphabet[i])
                    {
                        flag = true;
                        index = i + key;
                        index = index % alphabet.Length;
                    }
                }
                if (flag)
                {
                    open_text += alphabet[index];
                }
                else
                {
                    open_text += symbol;
                }
                DecryptTextBox.Text = open_text;
            }
        }
    }
}
