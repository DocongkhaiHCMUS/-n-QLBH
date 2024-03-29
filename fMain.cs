﻿using DAQLBH_Devexpress.DanhMuc;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Windows.Forms;

namespace DAQLBH_Devexpress
{
    public partial class fMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public fMain()
        {
            InitializeComponent();
            Load += FMain_Load;
            btnKhuVuc.ItemClick += BtnKhuVuc_ItemClick;
            timer1.Tick += Timer1_Tick;
            timer1.Start();
            FormClosing += FMain_FormClosing;
        }

        private void FMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn thoát ứng dụng ?", "CẢNH BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                e.Cancel = true;
            }
            else
                e.Cancel=false;
        }

        private void BtnKhuVuc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(fKhuVuc));
            if(frm!= null)
            {
                frm.Activate();
            }
            else 
            {
                fKhuVuc kv = new fKhuVuc();
                kv.MdiParent = this;
                kv.Show();
            }
        }

        private Form KiemTraTonTai(Type type)
        {
            foreach(var f in this.MdiChildren)
            {
                if(f.GetType() == type)
                {
                    return f;
                }
            }
            return null;
        }

        private void FMain_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            txtDate.Border = BorderStyles.Style3D;
            txtTime.Border = BorderStyles.Style3D;
            txtDate.Caption = DateTime.Today.ToString("dd/MM/yyyy");
            txtTime.Caption = DateTime.Now.ToString("HH:mm:ss");
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            txtTime.Caption = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(fKhachHang));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                fKhachHang kh = new fKhachHang();
                kh.MdiParent = this;
                kh.Show();
            }
        }

        private void btnNhaPhanPhoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(fNhaCC));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                fNhaCC ncc = new fNhaCC();
                ncc.MdiParent = this;
                ncc.Show();
            }
        }

        private void btnKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(fKhoHang));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                fKhoHang kho = new fKhoHang();
                kho.MdiParent = this;
                kho.Show();
            }
        }

        private void btnDonViTinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(fDonViTinh));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                fDonViTinh dvt = new fDonViTinh();
                dvt.MdiParent = this;
                dvt.Show();
            }
        }

        private void btnNhomHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(fNhomHang));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                fNhomHang nhomHang = new fNhomHang();
                nhomHang.MdiParent = this;
                nhomHang.Show();
            }
        }

        private void btnHangHoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(fHangHoa));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                fHangHoa hangHoa = new fHangHoa();
                hangHoa.MdiParent = this;
                hangHoa.Show();
            }
        }

        private void btnTyGia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(fTiGia));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                fTiGia tiGia = new fTiGia();
                tiGia.MdiParent = this;
                tiGia.Show();
            }
        }

        private void btnBoPhan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(fBoPhan));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                fBoPhan boPhan = new fBoPhan();
                boPhan.MdiParent = this;
                boPhan.Show();
            }
        }

        private void btnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(fNhanVien));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                fNhanVien nhanVien = new fNhanVien();
                nhanVien.MdiParent = this;
                nhanVien.Show();
            }
        }
    }
}
