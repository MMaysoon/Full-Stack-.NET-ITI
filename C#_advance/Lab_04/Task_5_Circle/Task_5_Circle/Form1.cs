namespace Task_5_Circle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics grx = e.Graphics;
            grx.FillEllipse(Brushes.Red, x, 80, 50, 50);
        }
        int x = 0;
        int direction = 1; //Left(-1), right(1)
        private void btn_start_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // move to dfine direction
            x += 5*direction;

            if (x + 50 >= this.ClientSize.Width) 
            {
                direction = -1; 
            }
            else if (x <= 0)
            {
                direction = 1; 
            }
            // callback event again
            this.Invalidate();
        }
    }
}
