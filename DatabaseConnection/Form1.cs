using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseConnection
{
    public partial class Form1 : Form
    {
        DatabaseAccess access = new DatabaseAccess();
        DataSet ds=new DataSet();
        public Form1()
        {
            InitializeComponent();
            dgvProductDatatable.ClearSelection();
            access = new DatabaseAccess();
            LoadData();
            show();

        }

        public void LoadData()
        {
            try
            {
                
                string query = "SELECT *  FROM [Products].[dbo].[Items];"; 
                 ds = access.ExecuteQuery(query);
                dgvProductDatatable.AutoGenerateColumns = true;
               
                dgvProductDatatable.DataSource = ds.Tables[0];

               


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

     
        public void show()
        {
            lbSum.Text = "Sum of Prices : " ;
        }

        

        public void Form1_Load(object sender, EventArgs e)
        {
            dgvProductDatatable.ClearSelection();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            var quentity = Convert.ToDouble(dgvProductDatatable.CurrentRow.Cells[2].Value);
            var Price = Convert.ToDouble(dgvProductDatatable.CurrentRow.Cells[3].Value);
            var total = quentity * Price;
            lbSum.Text = total.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //UserControl1 userControl1 = new UserControl1();
            //this.Controls.Add(userControl1);
            //userControl1.Visible = true;
            new FormAdd(this).Visible=true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                dgvProductDatatable.ClearSelection();
              
           
                    int rowIndex = dgvProductDatatable.CurrentCell.RowIndex;
                    if (rowIndex >= 0)
                    {
                        string id = dgvProductDatatable.Rows[rowIndex].Cells[0].Value.ToString();
                        string name = dgvProductDatatable.Rows[rowIndex].Cells[1].Value.ToString();
                        int  quantity = Convert.ToInt32(dgvProductDatatable.Rows[rowIndex].Cells[2].Value);
                        int  price = Convert.ToInt32(dgvProductDatatable.Rows[rowIndex].Cells[3].Value);
                   DialogResult result= MessageBox.Show($"Show information ID : {id} ,Name : {name},Quentity : {quantity}, Price : {price}","is it Confirm? ",MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        new FormAdd(this, id, name, quantity, price).Visible=true;
                         
                    }
                    
                       
                    }
                
            }catch(Exception ex ) {
                MessageBox.Show("Stock Quantity should be a numerical value"+ ex.Message,"", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }
            
        }
    }
}
