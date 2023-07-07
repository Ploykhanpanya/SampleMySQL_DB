using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleMySQL_DB
{
    public partial class Form1 : Form
    {
        private MySqlConnection _connection;
    
    
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtEmployeeID.Text = this.txtEmployeeName.Text = this.txtEmployeeSal.Text
            = this.txtEmployeeAddr.Text = this.txtEmployeePhone.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this._connection = new MySqlConnection("server=localhost; uid=root; database=samplemysql;"
                ); //"server=localhost;uid=root;pwd=12345;database=test"

            try
            {
                this._connection.Open();
                this._connection.Clone();
                MessageBox.Show("Connection Successfull");
            }
            catch(Exception)
            {
                MessageBox.Show("Connection unsuccessfull");
            }
        }
    }
    
}
