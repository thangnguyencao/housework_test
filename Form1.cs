namespace Housework1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button_VeSinhMayLanh.BackColor == Color.Cyan)
            {
                button_VeSinhMayLanh.BackColor = Color.MediumAquamarine;
            }
            else button_VeSinhMayLanh.BackColor = Color.Cyan;
            if (label_VeSinhMayLanh.Text == "0")
                label_VeSinhMayLanh.Text = "150.000";
            else label_VeSinhMayLanh.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button_DonDepNha.BackColor == Color.Cyan)
            {
                button_DonDepNha.BackColor = Color.MediumAquamarine;
            }
            else button_DonDepNha.BackColor = Color.Cyan;
            if (label_DonDepNha.Text == "0")
                label_DonDepNha.Text = "200.000";
            else label_DonDepNha.Text = "0";
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            panel1.Visible = false;
            
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            
            panel1.Visible = true;
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (button_Home.BackColor == Color.White)
            {
                button_Home.BackColor = Color.Gray;
                button_Payment.BackColor = Color.White;
            }
            else
            {
                button_Home.BackColor = Color.White;
                button_Payment.BackColor = Color.Gray;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (button_Payment.BackColor == Color.White)
            {
                button_Payment.BackColor = Color.Gray;
                button_Home.BackColor = Color.White;
            }
            else
            {
                button_Payment.BackColor = Color.White;
                button_Home.BackColor = Color.Gray;
            }
            int a = 0;

            if (button_GiatUi.BackColor == Color.Cyan)
                a += 100000;
            if (button_VeSinhMayLanh.BackColor == Color.Cyan)
                a += 150000;
            if (button_DonDepNha.BackColor == Color.Cyan)
                a += 200000;
            if (button_TongVeSinh.BackColor == Color.Cyan)
                a += 400000;
            if (button_NauAn.BackColor == Color.Cyan)
                a += 300000;
            if (button_DichVuKhac.BackColor == Color.Cyan)
                a += 500000;
            label_ThanhToan.Text = a.ToString("#,##0");
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button_GiatUi_Click(object sender, EventArgs e)
        {
            if (button_GiatUi.BackColor == Color.Cyan)
            {
                button_GiatUi.BackColor = Color.MediumAquamarine;
            }
            else button_GiatUi.BackColor = Color.Cyan;
            if (label_GiatUi.Text == "0")
                label_GiatUi.Text = "100.000";
            else label_GiatUi.Text = "0";
        }
    }
}