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
            Color color = HexToColor相近(fontcolor);
            this.BackColor = color;
            this.TransparencyKey = color;


        }


        /// <summary>
        /// hex转换到color
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

        public Color HexToColor相近(string hex)
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
            string[] names = { "范叶彤","冯培哲","高梓硕","王梦瑶","张高端","郭宇函","焦婧瑶","郭爽","金郡","金子鑫","李科瑶","李铭炜","李牧瀚","李偌熙","李思豪","李欣","李欣怡","李旭功","李紫萱","林妙歌","林思彤","刘春妍","刘广博","刘佳博","刘家琛","刘明辉","刘思涵","刘雨杭","刘在拓","刘震睿","马玉恩","倪璇璇","史语畅","孙康砧","田子轩","王俊林","王茜涵","王尚","王诗萱","王一奥","薛诚远","薛广晟","闫文轩","苑佳怡","苑天许","张博宣","张寒","张家铭","张敬仑","张梦潇","张笑菡","张艺瑭","张云淇","张志腾","张子怡","赵一达"};
            Random random = new Random();
            int i = random.Next(0, 55);

        }

        string name = "";
        private void timer1_Tick(object sender, EventArgs e)
        {
            string[] names = {"刘雨杭","张高端","张云淇", "张志腾","张家铭","孙康砧","田子轩","刘明辉","刘思涵","刘在拓","李欣怡","李科瑶","李欣","范叶彤","冯培哲","高梓硕","王梦瑶","郭宇函","焦婧瑶","郭爽","金郡","金子鑫","李铭炜","李牧瀚","李偌熙","李思豪","李旭功","李紫萱","林妙歌","林思彤","刘春妍","刘广博","刘佳博","刘家琛","刘震睿","马玉恩","倪璇璇","史语畅","王俊林","王茜涵","王尚","王诗萱","王一奥","薛诚远","薛广晟","闫文轩","苑佳怡","张博宣","张寒","张敬仑","张梦潇","张笑菡","张艺瑭","张子怡","赵一达","苑天许"};
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