namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true)
            {
               ;
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;
                label1.Text = DateTime.Now.ToLongTimeString();
                timer1.Start();
            }
       else if(pictureBox2.Visible == true)
            {
                
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                label1.Text = DateTime.UtcNow.ToLongTimeString();
                timer1.Start();
            }
        
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {if(pictureBox2.Visible == true)
            {
                label1.Text = DateTime.Now.ToLongTimeString();
                timer1.Start();
            }
           else if(pictureBox1.Visible== true)
            {
                label1.Text = DateTime.UtcNow.ToLongTimeString();
                timer1.Start();

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox2.Visible == true)
            {
                label1.Text = DateTime.Now.ToLongTimeString();
                timer1.Start();
            }
            else if (pictureBox1.Visible == true)
            {
                label1.Text = DateTime.UtcNow.ToLongTimeString();
                timer1.Start();

            }

        }
    }
}