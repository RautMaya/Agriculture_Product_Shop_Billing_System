using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgriSmart_Solutions.WindowsForm.Expence
{
    public partial class frm_Show_Bill_Image : Form
    {
        public frm_Show_Bill_Image()
        {
            InitializeComponent();
        }

        private void frm_Show_Bill_Image_Load(object sender, EventArgs e)
        {
            /// Shared_Class.Bind_Grid(dgv_Bill_Image, "Select Bill_Image From Expence_Details");
            Bind_Grid_Img("Select Exp_Id,Exp_Details From Expence_Details", dgv_Bill_Image);
        }

        void Bind_Grid_Img(String Query,DataGridView obj)
        {
            Connection.Con_Open();

            obj.DataSource = "";
            SqlDataAdapter SDA = new SqlDataAdapter(Query,Connection.DBCon);

            DataTable DT = new DataTable();

            SDA.Fill(DT);
            obj.DataSource = DT;

            Connection.Con_Close();
        }

        void View_Image(String Query,PictureBox pb)
        {
            Connection.Con_Open();

            SqlCommand Cmd = new SqlCommand(Query, Connection.DBCon);

            SqlDataAdapter DA = new SqlDataAdapter(Cmd);
            DataSet DS = new DataSet();

            DA.Fill(DS);

            if(DS.Tables[0].Rows.Count > 0)
            {
                MemoryStream ms = new MemoryStream((byte[])DS.Tables[0].Rows[0]["Bill_Image"]);

                pb.Image = new Bitmap(ms);
            }
            else
            {
                MessageBox.Show("Invalid Image Id!!!", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

            Connection.Con_Close();
        }

        private void dgv_Bill_Image_SelectionChanged(object sender, EventArgs e)
        {
            Int32 SelectedRowCount = dgv_Bill_Image.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if(SelectedRowCount == 1)
            {
                String value = dgv_Bill_Image.SelectedCells[0].RowIndex.ToString();

                int Index = Convert.ToInt32(value);

                int ID = Convert.ToInt32(dgv_Bill_Image.Rows[Index].Cells[0].Value);

                View_Image("Select Bill_Image From Expence_Details Where Exp_Id = " + ID + "", pb_Bill_Image);
            }
        }
    }
}
