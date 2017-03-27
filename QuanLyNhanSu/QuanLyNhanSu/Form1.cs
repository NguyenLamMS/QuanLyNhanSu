using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class QuanLyNhanSu : Form
    {
      
        public QuanLyNhanSu()
        {
            InitializeComponent();          
            cpbLoad.Hide();
           
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblName.Hide();
            lblPass.Hide();
           
        }
      

        private void tblName_KeyUp(object sender, KeyEventArgs e)
        {
            lblNameHide.Hide();
            lblName.Show();         
            if (tblName.Text == "")
            {
                lblName.Hide();
                lblNameHide.Show();
            }
        }

        private void tblPass_KeyUp(object sender, KeyEventArgs e)
        {
            lblPassHide.Hide();
            lblPass.Show();
            if (tblPass.Text == "")
            {
                lblPassHide.Show();
                lblPass.Hide();
            }
        }

       

      

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPass.Checked == true)
            {
                tblPass.isPassword = false;
            }
            else
            {
                tblPass.isPassword = true;
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
           DialogResult Exit = MessageBox.Show("Bạn có muốn thoát không ", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(Exit == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {    
            cpbLoad.Show();
            System.Threading.Thread.Sleep(100);
            cpbLoad.Hide();
            MessageBox.Show("Đăng nhập thành công");          
        }

        private void fogetPass_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vui Lòng liên hệ với Admin để reset password", "Quên mật khẩu");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss ");
            lblTime1.Text = DateTime.Now.ToString("tt");
            Label time = new Label();
            time.Text = lblTime1.Text;
            if(time.Text == "SA")
            {
                lblHello.Text = "Chào buổi sáng ";
            }
            else
            {
                lblHello.Text = "Chào buổi chiều";
                lblHello.ForeColor = Color.Maroon;
                lblRelax.Text = "Nếu công việc khiến bạn mệt mỏi";
                lblRelax2.Text = "Âm nhạc sẽ giúp bạn thư giãn và làm việc hiệu quả hơn ";
            }
        }
    }
}
