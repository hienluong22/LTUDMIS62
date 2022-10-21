using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace LTUDMIS62
{
    public partial class FrmDMHH : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        DataTable com2dt = new DataTable();
        string sql, constr;
        int i;
        Boolean addnewflag = false;
        public FrmDMHH()
        {
            InitializeComponent();
        }

        private void FrmDMHH_Load(object sender, EventArgs e)
        {
         constr = "Data Source =.; Initial Catalog = QLBH; Integrated Security = True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = "select Manhom,MaHH,TenHH,Dvt,DGvnd,Sanxuat from tblDMHH order by MaHH";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            grdData.DataSource = dt;
            NapCT();
            sql = "select Manhom from tblDMNhom ";
            da = new SqlDataAdapter(sql, conn);
            com2dt.Clear();
            da.Fill(com2dt);
            txtMaNhom.DataSource = com2dt;
            txtMaNhom.DisplayMember = "MaNhom";

        }

        private void grdData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            grdData.CurrentCell = grdData[0, 0];
            NapCT();
        }

        private void btnPrv_Click(object sender, EventArgs e)
        {
            if(i>=1)
            {
                i = grdData.CurrentRow.Index;
                grdData.CurrentCell = grdData[0, i - 1];
            }
            else
                {
                i = grdData.RowCount;
                grdData.CurrentCell = grdData[0, i - 2];
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            i = grdData.CurrentRow.Index;
            if (i <= grdData.RowCount - 2)
            {
                grdData.CurrentCell = grdData[0, i + 1];
            }
            else
            {
                grdData.CurrentCell = grdData[0, 0];
            }
            NapCT();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            i = grdData.RowCount;
            grdData.CurrentCell = grdData[0, i - 2];
            NapCT();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comTenTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = "select Distinct " + comTenTruong.Text + " from tblDMHH";
            da = new SqlDataAdapter(sql, conn);
            comdt.Clear();
            da.Fill(comdt);
            comGiaTri.DataSource = comdt;
            comGiaTri.DisplayMember = comTenTruong.Text;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            sql = "select Manhom,MaHH,TenHH,Dvt,DGvnd,Sanxuat from tblDMHH "+
             " where " + comTenTruong.Text + "=N'" + comGiaTri.Text + "'";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grdData.DataSource = dt;
            grdData.Refresh();
           NapCT();
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            sql = "select Manhom,MaHH,TenHH,Dvt,DGvnd,Sanxuat from tblDMHH order by MaHH";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grdData.DataSource = dt;
            grdData.Refresh();
            NapCT();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi hiện thời?Y/N","Xác nhận" + 
                "yêu cầu",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2)==DialogResult.Yes)
            {
                sql = "Delete from tblDMHH where MaHH='" + txtMaHH.Text + "'";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                grdData.Rows.RemoveAt(grdData.CurrentRow.Index);
                NapCT();
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hãy thực hiện mọi sửa đổi mong muốn trên ô lưới," +
                "kết thúc bằng nút cập nhật", "Thông báo", MessageBoxButtons.OK);
            btnupdate.Enabled = true;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (addnewflag == false)
            {
                // Chỗ này là cập nhật sửa chữa
                for (i = 0; i < grdData.RowCount - 1; i++)
                {
                    txtMaNhom.Text = grdData.Rows[i].Cells["Manhom"].Value.ToString();
                    txtMaHH.Text = grdData.Rows[i].Cells["MaHH"].Value.ToString();
                    txtTenHH.Text = grdData.Rows[i].Cells["TenHH"].Value.ToString();
                    txtDVT.Text = grdData.Rows[i].Cells["Dvt"].Value.ToString();
                    txtDongia.Text = grdData.Rows[i].Cells["DGvnd"].Value.ToString();
                    txtNuocSX.Text = grdData.Rows[i].Cells["Sanxuat"].Value.ToString();
                    sql = "update tblDMHH set Dgvnd=" + txtDongia.Text + ","  +
                        "TenHH=N'" + txtTenHH.Text + "', Dvt=N'" + txtDVT.Text + "'," +
                        "Sanxuat=N'" + txtNuocSX.Text + "'where MaHH='" + txtMaHH.Text + "'";
                    cmd.Connection = conn;
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();

                }
            }
            else
            {
                //Chỗ này là cập nhật thêm mới
                addnewflag = false;
                sql = "insert into tblDMHH (MaNhom,MaHH,TenHH,Dvt,Dgvnd,Sanxuat)" +
                    " Values ('" + txtMaNhom.Text + "'," + txtMaHH.Text + ",N'" +
                    txtTenHH.Text + "',N'" + txtDVT.Text + "'," + txtDongia.Text + ",N'"
                    + txtNuocSX.Text + "')";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                grdData.Rows[i].Cells["Manhom"].Value = txtMaNhom.Text;
                grdData.Rows[i].Cells["MaHH"].Value = txtMaHH.Text;
                grdData.Rows[i].Cells["TenHH"].Value = txtTenHH.Text;
                grdData.Rows[i].Cells["Dvt"].Value = txtDVT.Text;
                grdData.Rows[i].Cells["DGvnd"].Value = txtDongia.Text;
                grdData.Rows[i].Cells["Sanxuat"].Value = txtNuocSX.Text;
            }
            btnupdate.Enabled = false;
        }

        private void btnaddnew_Click(object sender, EventArgs e)
        {
            sql = "select Manhom,MaHH,TenHH,Dvt,DGvnd,Sanxuat from tblDMHH order by MaHH";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            grdData.DataSource = dt;
            NapCT();

            grdData.CurrentCell = grdData[0, grdData.RowCount-1];
            NapCT();
            MessageBox.Show("Hãy nhập nội dung bản ghi mới, kết thúc bấm Cập nhật!");
            txtMaNhom.Focus();
            addnewflag = true;
            btnupdate.Enabled = true;
        }

        private void btnBC1_Click(object sender, EventArgs e)
        {
            rptDMHH rpt = new rptDMHH();
            DataTable rptData = new DataTable();
                sql = "Select MaHH, TenHH, Dvt, DGvnd, Sanxuat From tblDMHH where" +
                " Manhom='" + comGiaTri.Text + "'";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(rptData);
            rpt.SetDataSource(rptData);
            rpt.DataDefinition.FormulaFields["TenNhom"].Text = "'" + comGiaTri.Text + "'";
            frmPrvDNHH f = new frmPrvDNHH(rpt);
            f.Show();

        }

        private void NapCT()
        {
            i = grdData.CurrentRow.Index;
            txtMaNhom.Text = grdData.Rows[i].Cells["Manhom"].Value.ToString();
            txtMaHH.Text = grdData.Rows[i].Cells["MaHH"].Value.ToString();
            txtTenHH.Text = grdData.Rows[i].Cells["TenHH"].Value.ToString();
            txtDVT.Text = grdData.Rows[i].Cells["Dvt"].Value.ToString();
            txtDongia.Text = grdData.Rows[i].Cells["DGvnd"].Value.ToString();
            txtNuocSX.Text = grdData.Rows[i].Cells["Sanxuat"].Value.ToString();
        }
    }
}
