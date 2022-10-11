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
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        string sql, constr;
        int i;
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
