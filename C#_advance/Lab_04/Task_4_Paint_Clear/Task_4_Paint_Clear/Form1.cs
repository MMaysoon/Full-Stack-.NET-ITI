namespace Task_4_Paint_Clear
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics grx=CreateGraphics();

            if(e.Button== MouseButtons.Right)
            {
                grx.FillEllipse(Brushes.Red, e.X - 20, e.Y - 20, 40, 40);
            }
            else if (e.Button== MouseButtons.Left)
            {
                SolidBrush b = new SolidBrush(this.BackColor);
                grx.FillEllipse(b, e.X - 20, e.Y - 20, 40, 40);
            }
        }
    }
}
