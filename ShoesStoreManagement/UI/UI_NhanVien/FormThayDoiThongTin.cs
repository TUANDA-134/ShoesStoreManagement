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

namespace ShoesStoreManagement.UI.UI_NhanVien
{
    public partial class FormThayDoiThongTin : Form
    {

        public FormThayDoiThongTin()
        {
            InitializeComponent();
        }

        private void pbxAnhNhanVien_Click(object sender, EventArgs e)
        {

        }
        internal void ShowInfoStaff(DTO_NhanVien s)
        {
            rbtnNam.Checked = true;
            rbtnAdmin.Checked = true;
            if (s != null)
            {
                tbxHoVaTen.Text = s.StaffName;
                tbxCMND.Text = s.StaffCMND;
                if (s.Gender != true) 
                    rbtnNu.Checked = true;
                dtprNgaySinh.Value = s.StaffBirthday;
                tbxSDT.Text = s.StaffTelephoneNumber;
                tbxEmail.Text = s.StaffEmail;
                tbxDiaChi.Text = s.StaffAddress;
                if (s.StaffRole != "Admin") 
                    rbtnStaff.Checked = true;
                string path;
                try
                {
                    path = BLL_DuongDan.Instance.StaffImagePath() + s.StaffId + ".png";
                    pbxAnhNhanVien.Image = Image.FromFile(path);
                }
                catch (Exception e)
                {
                    //path = @"C:\Users\Leo\Desktop\DACNPM\StaffPhoto\Error.png";
                    //pbxAnhNhanVien.Image = Image.FromFile(path);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void btnThayDoi_Click(object sender, EventArgs e)
        {
            if(tbxSDT.Text != "" && tbxDiaChi.Text !="" && tbxEmail.Text != "")
            {
                Staff nV = new Staff();
                nV.staffName = tbxHoVaTen.Text;
                nV.staffCMND = tbxCMND.Text;
                nV.staffGender = rbtnNam.Checked ? true : false;
                nV.staffBirthday = dtprNgaySinh.Value;
                nV.staffTelephoneNumber = tbxSDT.Text;
                nV.staffEmail = tbxEmail.Text;
                nV.staffAddress = tbxDiaChi.Text;
                nV.staffRole = rbtnAdmin.Checked ? "Admin" : "Staff";
                BLL_NhanVien.Instance.UpdateStaff(nV);
                FormThongBao.Show("Thành công!!!");
                this.Close();

            }
            else
            {
                FormThongBao.Show("Vui lòng điền đủ thông tin vào ô còn thiếu");
            }
           
        }

        private void btnExitScreen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}