using System;
using System.Drawing.Drawing2D;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace students
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string fontcolor = "FFFFFF";
            Color color = HexToColor���(fontcolor);
            this.BackColor = color;
            this.TransparencyKey = color;


        }


        /// <summary>
        /// hexת����color
        /// </summary>
        /// <param name="hex"></param>
        /// <returns></returns>
        public Color HexToColor(string hex)
        {
            byte br = byte.Parse(hex.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
            byte bg = byte.Parse(hex.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
            byte bb = byte.Parse(hex.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);


            Color c = Color.FromArgb(50, br, bg, bb);
            return c;
        }

        public Color HexToColor���(string hex)
        {
            int br = int.Parse(hex.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
            int bg = int.Parse(hex.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
            int bb = int.Parse(hex.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);


            if (br > 20)
            {

                br = br - 5;
            }

            if (bg > 20)
            {
                bg = bg - 5;
            }
            if (bb > 20)
            {
                bb = bb - 5;
            }

            // MessageBox.Show(br.ToString());
            Color c = Color.FromArgb(br, bg, bb);
            return c;
        }

        int count = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            timer1.Enabled = true;
            timer1.Start();
            timer2.Start();
            string[] names = { "��Ҷͮ","������","����˶","������","�Ÿ߶�","���","�����","��ˬ","��","������","�����","�����","�����","��ټ��","��˼��","����","������","����","������","�����","��˼ͮ","������","���㲩","���Ѳ�","�����","������","��˼��","���꺼","������","�����","�����","����","ʷ�ﳩ","�￵��","������","������","���纭","����","��ʫ��","��һ��","Ѧ��Զ","Ѧ����","������","Է����","Է����","�Ų���","�ź�","�ż���","�ž���","������","��Ц��","�����","�����","��־��","������","��һ��"};
            Random random = new Random();
            int i = random.Next(0, 55);

        }

        string name = "";
        private void timer1_Tick(object sender, EventArgs e)
        {
            string[] names = {"���꺼","�Ÿ߶�","�����", "��־��","�ż���","�￵��","������","������","��˼��","������","������","�����","����","��Ҷͮ","������","����˶","������","���","�����","��ˬ","��","������","�����","�����","��ټ��","��˼��","����","������","�����","��˼ͮ","������","���㲩","���Ѳ�","�����","�����","�����","����","ʷ�ﳩ","������","���纭","����","��ʫ��","��һ��","Ѧ��Զ","Ѧ����","������","Է����","�Ų���","�ź�","�ž���","������","��Ц��","�����","������","��һ��","Է����"};
            Random random = new Random();
            int i = random.Next(0, 58);
            this.label1.Text = names[i];
            

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer1.Stop();
            timer2.Stop();
        }



        private void label3_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }
    }
}