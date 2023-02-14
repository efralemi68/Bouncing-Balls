namespace Pelotas_Rebotan
{
    public partial class Form1 : Form
    {

        int ball1Speed, ball2SpeedX, ball2SpeedY, ball3SpeedY, ball3SpeedX, ball4SpeedX, ball4SpeedY ,ball5Speed;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();

            start_Bouncing();
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {

            ball1.Left+= ball1Speed;

            if (ball1.Bounds.IntersectsWith(limit1.Bounds) || ball1.Bounds.IntersectsWith(limit2.Bounds))
            {
                ball1Speed = -ball1Speed;

            }


            ball2.Left -= ball2SpeedX;
            ball2.Top -= ball2SpeedY;


            if (ball2.Top <0 || ball2.Top > 200) //inside frama
            {
                ball2SpeedY= -ball2SpeedY;

            }

            if (ball2.Left < 50 || ball2.Left > 500) //inside frame
            {
                ball2SpeedX = -ball2SpeedX;

            }

            ball3.Left -= ball3SpeedX;
            ball3.Top -= ball3SpeedY;


            if (ball3.Top < 0 || ball3.Top > 250) //inside frama
            {
                ball3SpeedY = -ball3SpeedY;

            }

            if (ball3.Left < 0 || ball3.Left > 500) //inside frame
            {
                ball3SpeedX = -ball3SpeedX;

            }



            ball4.Left -= ball4SpeedX;
            ball4.Top -= ball4SpeedY;


            if (ball4.Top < 0 || ball4.Top > 250) //inside frame
            {
                ball4SpeedY = -ball3SpeedY;

            }

            if (ball4.Left < 0 || ball4.Left > 500) //inside frame
            {
                ball4SpeedX = -ball4SpeedX;

            }




            ball5.Left += ball5Speed;

            if (ball5.Bounds.IntersectsWith(limit1.Bounds) || ball5.Bounds.IntersectsWith(limit2.Bounds))
            {
                ball5Speed = -ball5Speed;

            }


        }

        private void start_Bouncing()
        {
            ball1Speed = 1;

            ball2SpeedX = 1;
            ball2SpeedY = 1;

            ball3SpeedX = 2;
            ball3SpeedY = 2;
            
            ball4SpeedX = 2;
            ball4SpeedY = 2;
            
            ball5Speed = 1;

            timer1.Start();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}