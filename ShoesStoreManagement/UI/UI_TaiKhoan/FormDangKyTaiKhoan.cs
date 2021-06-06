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
    public partial class FormDangKyTaiKhoan : Form
    {
        bool anh = false;
        public FormDangKyTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (tbxHoVaTen.Text == "")
            {
                FormThongBao.Show("Vui lòng nhập họ và tên!!! ");

            }
            else if (tbxCMND.Text == "")
            {
                FormThongBao.Show("Vui lòng nhập số chứng minh nhân dân!!!");
            }
            else if (!rbtnNam.Checked && !rbtnNu.Checked)
            {
                FormThongBao.Show("Vui lòng chọn giới tính!!!");
            }
            else if (tbxSDT.Text == "")
            {
                FormThongBao.Show("Vui lòng nhập số điện thoại!!!");
            }
            else if (tbxDiaChi.Text == "")
            {
                FormThongBao.Show("Vui lòng nhập địa chỉ!!!");
            }
            else if (tbxEmail.Text == "")
            {
                FormThongBao.Show("Vui lòng nhập email!!!");
            }
            else if (!rbtnAdmin.Checked && !rbtnStaff.Checked)
            {
                FormThongBao.Show("Vui lòng chọn chức vụ!!!");
            }
            else if (tbxUsername.Text == "")
            {
                FormThongBao.Show("Vui lòng nhập tên đăng nhập!!!");
            }
            else if (tbxPassword.Text == "")
            {
                FormThongBao.Show("Vui lòng nhập mật khẩu!!!");
            }
            else if (tbxPasswordVerification.Text == "")
            {
                FormThongBao.Show("Vui lòng xác thực mật khẩu!!!");
            }
            else if (tbxPasswordVerification.Text != tbxPassword.Text)
            {
                FormThongBao.Show("Xác thực mật khẩu không chính xác!!!");
            }
            else if (!anh)
            {
                FormThongBao.Show("Vui lòng thêm ảnh");
            }
            else
            {
                DTO_DangKyTaiKhoan DKTK = new DTO_DangKyTaiKhoan();
                DKTK.HoVaTen = tbxHoVaTen.Text;
                DKTK.CMND = tbxCMND.Text;
                DKTK.NgaySinh = dtprNgaySinh.Value;
                DKTK.Gender = rbtnNam.Checked ? true : false;
                //----

                DKTK.SDT = tbxSDT.Text;
                DKTK.DiaChi = tbxDiaChi.Text;
                DKTK.Email = tbxEmail.Text;
                //----

                DKTK.ChucVu = rbtnAdmin.Checked ? "Admin" : "Staff";
                DKTK.NgayBatDauLamViec = dtprNgayBatDau.Value;
                //----

                DKTK.MatKhau = tbxPassword.Text;
                DKTK.XacThucMatKhau = tbxPasswordVerification.Text;
                DKTK.TenDangNhap = tbxUsername.Text;
                FormThongBao.Show(BLL_TaiKhoan.Instance.SignUpNewAccount(DKTK, ofdg.FileName));
            }


        }

        private void btnExitScreen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemAnh_Click(object sender, EventArgs e)
        {
            ofdg.InitialDirectory = "E:";//Định đường dẫn khi mở cửa sổ tìm ảnh
            ofdg.FileName = "";// Tên ảnh
            ofdg.Filter = "Images(*.jpg)|*.jpg|PNG (*.png)|*.png|All files (*.*)|*.*";
            DialogResult result = ofdg.ShowDialog();
            if (result == DialogResult.OK)
            {
                // Lấy hình ảnh
                Image img = Image.FromFile(ofdg.FileName);
                FormThongBao.Show(ofdg.FileName);
                // Gán ảnh
                pbxAnh.Image = img;
                anh = true;
            }
        }
    }
}
