﻿
namespace ShoesStoreManagement.UI.UI_SanPham
{
    partial class FormThemSanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pdbMain = new ShoesStoreManagement.UI.UI_SanPham.PanelDoubleBuffered();
            this.pnlMau = new ShoesStoreManagement.UI.UI_SanPham.PanelDoubleBuffered();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThemMau = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlMoTa = new System.Windows.Forms.Panel();
            this.lblMaGiay1 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.cbbMaGiay = new System.Windows.Forms.ComboBox();
            this.rtbMoTa = new System.Windows.Forms.RichTextBox();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.pnlTopLeft = new System.Windows.Forms.Panel();
            this.tbxHang = new System.Windows.Forms.TextBox();
            this.tbxMaGiay = new System.Windows.Forms.TextBox();
            this.tbxGia = new System.Windows.Forms.TextBox();
            this.tbxTenGiay = new System.Windows.Forms.TextBox();
            this.lblMaGiay = new System.Windows.Forms.Label();
            this.lblHang = new System.Windows.Forms.Label();
            this.cbbLoaiGiay = new System.Windows.Forms.ComboBox();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblLoaiGiay = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.btnThemTuGiayCoSan = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.pdbMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlMoTa.SuspendLayout();
            this.pnlTopLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // pdbMain
            // 
            this.pdbMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.pdbMain.Controls.Add(this.pnlMau);
            this.pdbMain.Controls.Add(this.panel1);
            this.pdbMain.Controls.Add(this.pnlTop);
            this.pdbMain.Controls.Add(this.pnlRight);
            this.pdbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdbMain.Location = new System.Drawing.Point(0, 0);
            this.pdbMain.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pdbMain.Name = "pdbMain";
            this.pdbMain.Size = new System.Drawing.Size(2010, 1215);
            this.pdbMain.TabIndex = 1;
            // 
            // pnlMau
            // 
            this.pnlMau.AutoScroll = true;
            this.pnlMau.AutoSize = true;
            this.pnlMau.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMau.Location = new System.Drawing.Point(0, 552);
            this.pnlMau.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlMau.Name = "pnlMau";
            this.pnlMau.Size = new System.Drawing.Size(1712, 572);
            this.pnlMau.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThemMau);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 1124);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1712, 91);
            this.panel1.TabIndex = 5;
            // 
            // btnThemMau
            // 
            this.btnThemMau.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThemMau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnThemMau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThemMau.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemMau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMau.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThemMau.Location = new System.Drawing.Point(0, 0);
            this.btnThemMau.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnThemMau.Name = "btnThemMau";
            this.btnThemMau.Size = new System.Drawing.Size(1712, 91);
            this.btnThemMau.TabIndex = 21;
            this.btnThemMau.Text = "Thêm màu";
            this.btnThemMau.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemMau.UseVisualStyleBackColor = false;
            this.btnThemMau.Click += new System.EventHandler(this.btnThemMau_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.pnlMoTa);
            this.pnlTop.Controls.Add(this.pnlTopLeft);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1712, 552);
            this.pnlTop.TabIndex = 0;
            // 
            // pnlMoTa
            // 
            this.pnlMoTa.AutoSize = true;
            this.pnlMoTa.Controls.Add(this.lblMaGiay1);
            this.pnlMoTa.Controls.Add(this.btnLuu);
            this.pnlMoTa.Controls.Add(this.cbbMaGiay);
            this.pnlMoTa.Controls.Add(this.rtbMoTa);
            this.pnlMoTa.Controls.Add(this.lblMoTa);
            this.pnlMoTa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMoTa.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMoTa.Location = new System.Drawing.Point(816, 0);
            this.pnlMoTa.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlMoTa.Name = "pnlMoTa";
            this.pnlMoTa.Size = new System.Drawing.Size(894, 550);
            this.pnlMoTa.TabIndex = 19;
            // 
            // lblMaGiay1
            // 
            this.lblMaGiay1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaGiay1.AutoSize = true;
            this.lblMaGiay1.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaGiay1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblMaGiay1.Location = new System.Drawing.Point(42, 318);
            this.lblMaGiay1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMaGiay1.Name = "lblMaGiay1";
            this.lblMaGiay1.Size = new System.Drawing.Size(134, 38);
            this.lblMaGiay1.TabIndex = 24;
            this.lblMaGiay1.Text = "Mã giày";
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLuu.Location = new System.Drawing.Point(422, 442);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(222, 76);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // cbbMaGiay
            // 
            this.cbbMaGiay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbMaGiay.BackColor = System.Drawing.Color.White;
            this.cbbMaGiay.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaGiay.FormattingEnabled = true;
            this.cbbMaGiay.Location = new System.Drawing.Point(242, 318);
            this.cbbMaGiay.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbbMaGiay.Name = "cbbMaGiay";
            this.cbbMaGiay.Size = new System.Drawing.Size(596, 98);
            this.cbbMaGiay.TabIndex = 22;
            this.cbbMaGiay.SelectedIndexChanged += new System.EventHandler(this.cbbMaGiay_SelectedIndexChanged);
            this.cbbMaGiay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbMaGiay_KeyPress);
            // 
            // rtbMoTa
            // 
            this.rtbMoTa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbMoTa.AutoWordSelection = true;
            this.rtbMoTa.BackColor = System.Drawing.Color.White;
            this.rtbMoTa.Font = new System.Drawing.Font("Times New Roman", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbMoTa.Location = new System.Drawing.Point(242, 21);
            this.rtbMoTa.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rtbMoTa.Name = "rtbMoTa";
            this.rtbMoTa.Size = new System.Drawing.Size(596, 289);
            this.rtbMoTa.TabIndex = 4;
            this.rtbMoTa.Text = "";
            // 
            // lblMoTa
            // 
            this.lblMoTa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoTa.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblMoTa.Location = new System.Drawing.Point(42, 21);
            this.lblMoTa.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(103, 38);
            this.lblMoTa.TabIndex = 4;
            this.lblMoTa.Text = "Mô tả";
            // 
            // pnlTopLeft
            // 
            this.pnlTopLeft.Controls.Add(this.tbxHang);
            this.pnlTopLeft.Controls.Add(this.tbxMaGiay);
            this.pnlTopLeft.Controls.Add(this.tbxGia);
            this.pnlTopLeft.Controls.Add(this.tbxTenGiay);
            this.pnlTopLeft.Controls.Add(this.lblMaGiay);
            this.pnlTopLeft.Controls.Add(this.lblHang);
            this.pnlTopLeft.Controls.Add(this.cbbLoaiGiay);
            this.pnlTopLeft.Controls.Add(this.lblGia);
            this.pnlTopLeft.Controls.Add(this.lblTen);
            this.pnlTopLeft.Controls.Add(this.lblLoaiGiay);
            this.pnlTopLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTopLeft.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlTopLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlTopLeft.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlTopLeft.Name = "pnlTopLeft";
            this.pnlTopLeft.Size = new System.Drawing.Size(816, 550);
            this.pnlTopLeft.TabIndex = 18;
            // 
            // tbxHang
            // 
            this.tbxHang.BackColor = System.Drawing.Color.White;
            this.tbxHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxHang.Font = new System.Drawing.Font("Times New Roman", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxHang.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbxHang.Location = new System.Drawing.Point(268, 219);
            this.tbxHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxHang.Name = "tbxHang";
            this.tbxHang.Size = new System.Drawing.Size(506, 84);
            this.tbxHang.TabIndex = 2;
            this.tbxHang.TabStop = false;
            // 
            // tbxMaGiay
            // 
            this.tbxMaGiay.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxMaGiay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxMaGiay.Font = new System.Drawing.Font("Times New Roman", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMaGiay.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbxMaGiay.Location = new System.Drawing.Point(268, 21);
            this.tbxMaGiay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxMaGiay.Name = "tbxMaGiay";
            this.tbxMaGiay.ReadOnly = true;
            this.tbxMaGiay.Size = new System.Drawing.Size(506, 77);
            this.tbxMaGiay.TabIndex = 4;
            this.tbxMaGiay.TabStop = false;
            // 
            // tbxGia
            // 
            this.tbxGia.BackColor = System.Drawing.Color.White;
            this.tbxGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxGia.Font = new System.Drawing.Font("Times New Roman", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxGia.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbxGia.Location = new System.Drawing.Point(268, 318);
            this.tbxGia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxGia.Name = "tbxGia";
            this.tbxGia.Size = new System.Drawing.Size(506, 84);
            this.tbxGia.TabIndex = 3;
            this.tbxGia.TabStop = false;
            // 
            // tbxTenGiay
            // 
            this.tbxTenGiay.BackColor = System.Drawing.Color.White;
            this.tbxTenGiay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxTenGiay.Font = new System.Drawing.Font("Times New Roman", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTenGiay.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbxTenGiay.Location = new System.Drawing.Point(268, 120);
            this.tbxTenGiay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxTenGiay.Name = "tbxTenGiay";
            this.tbxTenGiay.Size = new System.Drawing.Size(506, 84);
            this.tbxTenGiay.TabIndex = 1;
            this.tbxTenGiay.TabStop = false;
            // 
            // lblMaGiay
            // 
            this.lblMaGiay.AutoSize = true;
            this.lblMaGiay.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaGiay.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblMaGiay.Location = new System.Drawing.Point(28, 21);
            this.lblMaGiay.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMaGiay.Name = "lblMaGiay";
            this.lblMaGiay.Size = new System.Drawing.Size(134, 38);
            this.lblMaGiay.TabIndex = 22;
            this.lblMaGiay.Text = "Mã giày";
            // 
            // lblHang
            // 
            this.lblHang.AutoSize = true;
            this.lblHang.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHang.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblHang.Location = new System.Drawing.Point(28, 219);
            this.lblHang.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHang.Name = "lblHang";
            this.lblHang.Size = new System.Drawing.Size(96, 38);
            this.lblHang.TabIndex = 2;
            this.lblHang.Text = "Hãng";
            // 
            // cbbLoaiGiay
            // 
            this.cbbLoaiGiay.BackColor = System.Drawing.Color.White;
            this.cbbLoaiGiay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoaiGiay.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLoaiGiay.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbbLoaiGiay.FormattingEnabled = true;
            this.cbbLoaiGiay.Location = new System.Drawing.Point(268, 418);
            this.cbbLoaiGiay.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbbLoaiGiay.Name = "cbbLoaiGiay";
            this.cbbLoaiGiay.Size = new System.Drawing.Size(506, 98);
            this.cbbLoaiGiay.TabIndex = 12;
            this.cbbLoaiGiay.SelectedIndexChanged += new System.EventHandler(this.CbbLoaiGiay_SelectedIndexChanged);
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGia.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblGia.Location = new System.Drawing.Point(28, 318);
            this.lblGia.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(69, 38);
            this.lblGia.TabIndex = 0;
            this.lblGia.Text = "Giá";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblTen.Location = new System.Drawing.Point(28, 120);
            this.lblTen.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(74, 38);
            this.lblTen.TabIndex = 6;
            this.lblTen.Text = "Tên";
            // 
            // lblLoaiGiay
            // 
            this.lblLoaiGiay.AutoSize = true;
            this.lblLoaiGiay.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiGiay.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblLoaiGiay.Location = new System.Drawing.Point(28, 418);
            this.lblLoaiGiay.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLoaiGiay.Name = "lblLoaiGiay";
            this.lblLoaiGiay.Size = new System.Drawing.Size(151, 38);
            this.lblLoaiGiay.TabIndex = 11;
            this.lblLoaiGiay.Text = "Loại giày";
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.pnlRight.Controls.Add(this.btnThemTuGiayCoSan);
            this.pnlRight.Controls.Add(this.btnXoa);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(1712, 0);
            this.pnlRight.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(298, 1215);
            this.pnlRight.TabIndex = 3;
            // 
            // btnThemTuGiayCoSan
            // 
            this.btnThemTuGiayCoSan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThemTuGiayCoSan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnThemTuGiayCoSan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThemTuGiayCoSan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemTuGiayCoSan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTuGiayCoSan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThemTuGiayCoSan.Location = new System.Drawing.Point(0, 136);
            this.btnThemTuGiayCoSan.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnThemTuGiayCoSan.Name = "btnThemTuGiayCoSan";
            this.btnThemTuGiayCoSan.Size = new System.Drawing.Size(298, 136);
            this.btnThemTuGiayCoSan.TabIndex = 22;
            this.btnThemTuGiayCoSan.Text = "Thêm màu từ giày có sẵn";
            this.btnThemTuGiayCoSan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemTuGiayCoSan.UseVisualStyleBackColor = false;
            this.btnThemTuGiayCoSan.Click += new System.EventHandler(this.btnThemTuGiayCoSan_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXoa.Location = new System.Drawing.Point(0, 0);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(298, 136);
            this.btnXoa.TabIndex = 23;
            this.btnXoa.Text = "Xóa trang";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // FormThemSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(2010, 1215);
            this.Controls.Add(this.pdbMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormThemSanPham";
            this.Text = "FormSanPham";
            this.MaximumSizeChanged += new System.EventHandler(this.FormSanPham_MaximumSizeChanged);
            this.pdbMain.ResumeLayout(false);
            this.pdbMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlMoTa.ResumeLayout(false);
            this.pnlMoTa.PerformLayout();
            this.pnlTopLeft.ResumeLayout(false);
            this.pnlTopLeft.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.RichTextBox rtbMoTa;
        private System.Windows.Forms.TextBox tbxTenGiay;
        private System.Windows.Forms.TextBox tbxGia;
        private System.Windows.Forms.TextBox tbxHang;
        private System.Windows.Forms.ComboBox cbbLoaiGiay;
        private System.Windows.Forms.Label lblLoaiGiay;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Label lblHang;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Panel pnlMoTa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Panel pnlTopLeft;
        private PanelDoubleBuffered pdbMain;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Button btnThemMau;
        private PanelDoubleBuffered pnlMau;
        private System.Windows.Forms.Button btnThemTuGiayCoSan;
        private System.Windows.Forms.ComboBox cbbMaGiay;
        private System.Windows.Forms.Label lblMaGiay1;
        private System.Windows.Forms.Label lblMaGiay;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox tbxMaGiay;
        private System.Windows.Forms.Panel panel1;
    }
}