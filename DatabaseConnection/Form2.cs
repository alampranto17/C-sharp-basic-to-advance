using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseConnection
{
    public partial class FormAdd : Form
    {
        public Form1 Form1 {  get; set; }

       

        

        DatabaseAccess access;

        public FormAdd()
        {
            InitializeComponent();
            access = new DatabaseAccess();
        }
        public FormAdd(Form1 form1) : this() 
        {
            this.Form1 = form1;
            
        }

        public FormAdd(Form1 form1,string id,string name,int price, int quantity) :this(form1)
        {
            this.textBoxId.Text= id;
            this.textBoxName.Text = name;
            this.textBoxQuantity.Text = quantity.ToString();
            this.textBoxPrice.Text = price.ToString();
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Visible = true;
           Form1.LoadData();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text != "")
            {
                string query = "UPDATE [dbo].[Items]SET [Name] = '"+ textBoxName.Text + "',[UnitPrices] ="+ Convert.ToInt64(textBoxPrice.Text) + ",[Quantiy] = "+ Convert.ToInt64(textBoxQuantity.Text) +" WHERE [Id]='" + textBoxId.Text + "'; ";
               int Count =access.ExecuteDMLQuery(query);

                if(Count==1)
                {
                    MessageBox.Show("Query run successfull", "Working");

                }
                else
                {
                    MessageBox.Show("Query run successfull", "Working");
                }




            }
            else
            {

                try
                {

                    string query = "INSERT INTO Items ([Id],[Name],[UnitPrices],[Quantiy])VALUES('" + textBoxId.Text + "','" + textBoxName.Text + "'," + Convert.ToInt64(textBoxPrice.Text) + " ," + Convert.ToInt64(textBoxQuantity.Text) + "); ";


                    access.ExecuteDMLQuery(query);

                    MessageBox.Show("Data inserted successfully.");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"An error occurred: {ex.Message}");
                }

            }

        }

        private void btnClaer_Click(object sender, EventArgs e)
        {
            textBoxId.Clear();
            textBoxName.Clear();
            textBoxPrice.Clear();
            textBoxQuantity.Clear();
        }
    }
}
