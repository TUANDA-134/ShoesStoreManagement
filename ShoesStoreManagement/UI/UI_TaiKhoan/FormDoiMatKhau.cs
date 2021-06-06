using ShoesStoreManagement.BLL;
using ShoesStoreManagement.DTO;
using ShoesStoreManagement.UI.UI_ThongBao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoesStoreManagement.UI.UI_TaiKhoan
{
    public partial class FormDoiMatKhau : Form
    {
        public FormDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if(tbxUsername.Text == "")
            {
                FormThongBao.Show("Vui lòng nhập tên đăng nhập");
            }else if(tbxCurrentPassword.Text == "")
            {
                FormThongBao.Show("Vui lòng nhập mật khẩu hiện tại");
            }else if(tbxNewPassword.Text == "")
            {
                FormThongBao.Show("Vui lòng nhập mật khẩu mới");
            }else if(tbxNewPasswordVerification.Text == "")
            {
                FormThongBao.Show("Vui lòng xác thực mật khẩu");
            }
            else
            {
                DTO_ChangePasswordOfAccount cPOA = new DTO_ChangePasswordOfAccount();
                cPOA.Username = tbxUsername.Text;
                cPOA.CurrentPassword = tbxCurrentPassword.Text;
                cPOA.NewPassword = tbxNewPassword.Text;
                cPOA.NewPasswordVerification = tbxNewPasswordVerification.Text;
                if (cPOA.NewPassword != cPOA.NewPasswordVerification)
                {
                    FormThongBao.Show("Xác thực mật khẩu không chính xác");
                }
                else
                {
                    FormThongBao.Show(BLL_TaiKhoan.Instance.ChangePassword(cPOA));
                    tbxUsername.Text = "";
                    tbxCurrentPassword.Text = "";
                    tbxNewPassword.Text = "";
                    tbxNewPasswordVerification.Text = "";
                }
            }
        }

        private void btnExitScreen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
