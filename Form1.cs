using System.Drawing.Drawing2D;

namespace GraphicClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = this.CreateGraphics();

            SolidBrush s = new SolidBrush(Color.Orange);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        Bitmap bmp;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                string path = op.FileName;
                bmp = new Bitmap(op.FileName);
                pictureBox2.Image = bmp;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            if (sv.ShowDialog() == DialogResult.OK)
            {
                string path = sv.FileName;
                bmp.Save(path);
                MessageBox.Show("Image save", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Graphics gr = Graphics.FromImage(bmp);
            LinearGradientBrush linear = new LinearGradientBrush(
                new Point(0, 0), new Point(bmp.Width, 0), Color.FromArgb(50, 225, 128, 172), Color.FromArgb(50, 52, 58, 178));
            gr.FillRectangle(linear, 0, 0, bmp.Width, bmp.Height);
            pictureBox2.Image = bmp;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Graphics gr = Graphics.FromImage(bmp);
            LinearGradientBrush linear = new LinearGradientBrush(
                new Point(0, 0), new Point(bmp.Width, 0), Color.FromArgb(50, 139, 0, 139), Color.FromArgb(50, 25, 25, 112));
            gr.FillRectangle(linear, 0, 0, bmp.Width, bmp.Height);
            pictureBox2.Image = bmp;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Graphics gr = Graphics.FromImage(bmp);
            LinearGradientBrush linear = new LinearGradientBrush(
                new Point(0, 0), new Point(bmp.Width, 0), Color.FromArgb(50, 0, 255, 255), Color.FromArgb(50, 0, 0, 255));
            gr.FillRectangle(linear, 0, 0, bmp.Width, bmp.Height);
            pictureBox2.Image = bmp;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Graphics gr = Graphics.FromImage(bmp);
            LinearGradientBrush linear = new LinearGradientBrush(
                new Point(0, 0), new Point(bmp.Width, 0), Color.FromArgb(50, 255, 255, 255), Color.FromArgb(50, 255, 215, 0));
            gr.FillRectangle(linear, 0, 0, bmp.Width, bmp.Height);
            pictureBox2.Image = bmp;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Graphics gr = Graphics.FromImage(bmp);
            LinearGradientBrush linear = new LinearGradientBrush(
                new Point(0, 0), new Point(bmp.Width, 0), Color.FromArgb(50, 144, 238, 144), Color.FromArgb(50, 0, 100, 0));
            gr.FillRectangle(linear, 0, 0, bmp.Width, bmp.Height);
            pictureBox2.Image = bmp;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Graphics gr = Graphics.FromImage(bmp);
            LinearGradientBrush linear = new LinearGradientBrush(
                new Point(0, 0), new Point(bmp.Width, 0), Color.FromArgb(50, 140, 128, 172), Color.FromArgb(50, 255, 70, 0));
            gr.FillRectangle(linear, 0, 0, bmp.Width, bmp.Height);
            pictureBox2.Image = bmp;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Graphics gr = Graphics.FromImage(bmp);
            LinearGradientBrush linear = new LinearGradientBrush(
                new Point(0, 0), new Point(bmp.Width, 0), Color.FromArgb(50, 225, 140, 0), Color.FromArgb(50, 255, 255, 0));
            gr.FillRectangle(linear, 0, 0, bmp.Width, bmp.Height);
            pictureBox2.Image = bmp;
        }
    }
}