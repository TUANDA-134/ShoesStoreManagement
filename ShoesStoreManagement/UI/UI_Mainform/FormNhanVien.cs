using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShoesStoreManagement.BLL;
using ShoesStoreManagement.UI.UI_NhanVien;
using ShoesStoreManagement.DTO;
using ShoesStoreManagement.UI.UI_ThongBao;

namespace ShoesStoreManagement.UI
{
    public partial class FormNhanVien : Form
    {
        public delegate void delShow(DTO_NhanVien s);
        delShow dShowXem;
        delShow dShowThayDoi;
        private Form currentChildForm;
        FormXemTatCaNhanVien XTCNV = new FormXemTatCaNhanVien();
        public FormNhanVien()
        {
            InitializeComponent();
            OpenChildForm(XTCNV);
            if (BLL_Login.HienHanh() != null)
            {
                if (BLL_Login.HienHanh().ChucVu.ToLower().Equals("staff"))
                {
                    btnThayDoiThongTin.Enabled = false;
                }
            }
        }

        public void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            //childForm.Dock = DockStyle.Top;
            this.pnlHienThi.Controls.Add(childForm);
            this.pnlHienThi.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btnXemThongTin_Click(object sender, EventArgs e)
        {
            if (tbxTen.Text == "" || tbxSDT.Text == "")
            {
                FormThongBao.Show("Vui lòng điền đủ thông tin để xem thông tin");
            }
            else
            {
                FormXemThongTin XTTF = new FormXemThongTin();
                dShowXem = new delShow(XTTF.ShowInfoStaff);
                DTO_NhanVien s = BLL_NhanVien.Instance.GetNVByTenAndSDT(tbxTen.Text, tbxSDT.Text);
                if (s != null)
                {
                    dShowXem(s);
                    XTTF.ShowDialog();

                }
                else
                {
                    FormThongBao.Show("Không tìm thấy nhân viên!!!");
                }
            }

        }

        private void btnThayDoiThongTin_Click(object sender, EventArgs e)
        {
            if (tbxTen.Text == "" || tbxSDT.Text == "")
            {
                FormThongBao.Show("Vui lòng điền đủ thông tin để xem thông tin");
            }
            else
            {
                FormThayDoiThongTin TTTTF = new FormThayDoiThongTin();
                dShowThayDoi = new delShow(TTTTF.ShowInfoStaff);
                DTO_NhanVien s = BLL_NhanVien.Instance.GetNVByTenAndSDT(tbxTen.Text, tbxSDT.Text);
                if (s != null)
                {
                    dShowThayDoi(s);
                    TTTTF.ShowDialog();
                    FormXemTatCaNhanVien XTCNV2 = new FormXemTatCaNhanVien();
                    OpenChildForm(XTCNV2);


                }
                else
                {
                    FormThongBao.Show("Không tìm thấy nhân viên!!!");
                }
            }
        }
    }
}
