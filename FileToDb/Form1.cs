using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace FileToDb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDbToFile_Click(object sender, EventArgs e)
        {
            string teamId="";
            string teamName = "";
            int id = 1;
           SqlConnection  connection = new SqlConnection(@"Server=DESKTOP-C0MLP28\SQLEXPRESS;Database=FileOpreation;Trusted_Connection=true;");
            connection.Open();
           SqlCommand   command = connection.CreateCommand();
            command.CommandText = "NameList";
            command.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = command.ExecuteReader();
            File.WriteAllText(@"C:\Users\Admin\Desktop\MyDbData.txt", string.Empty);
            while (reader.Read())
            {
               
                teamId = reader["Id"].ToString();
                 teamName = reader["Name"].ToString();
                if(txtLowerLimit.Text==""&&txtUpperLimit.Text=="")
                {
                    File.AppendAllText(@"C:\Users\Admin\Desktop\MyDbData.txt", id + "." + teamName + "\r\n");
                    return;
                }

               
              //  else if (Convert.ToInt32(txtLowerLimit.Text) <= Convert.ToInt32(teamId) && Convert.ToInt32(txtUpperLimit.Text) >= Convert.ToInt32(teamId))
                else{
                    File.AppendAllText(@"C:\Users\Admin\Desktop\MyDbData.txt", id + "." + teamName + "\r\n");
                }
                id++;
            }
           
            connection.Close();
          //  ofdbxDbOpreations.ShowDialog();
        }
    }
}
