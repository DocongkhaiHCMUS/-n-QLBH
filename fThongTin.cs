﻿using System;

namespace DAQLBH_Devexpress
{
    public partial class fThongTin : DevExpress.XtraEditors.XtraForm
    {
        public fThongTin()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            Load += FThongTin_Load;
            btnKetThuc.Click += BtnDongY_Click;
            txtTenMonHoc.Text = "Lập Trình Ứng Dụng Quản Lý 1";
            txtTenDoAn.Text = "Ứng dụng Quản Lý Bán Hàng";
            txtMoiTruong.Text = "IDE Visual Studio 2019 , .NET Framework 4.7.2, DevExpress 19.2";
            txtGVHD.Text = "giáo viên Trần Văn Quý";
            txtTenNhom.Text = "Nhóm";
        }

        private void BtnDongY_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void FThongTin_Load(object sender, EventArgs e)
        {
        }
    }
}