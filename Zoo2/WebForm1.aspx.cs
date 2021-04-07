using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace Zoo2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string connection = "Server=team4zoodb.mysql.database.azure.com; Port=3306; Database=zoo; Uid=Team4@team4zoodb; Pwd=4thTeamRocks; SslMode=Preferred;";
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {          
           using(MySqlConnection sqlConnection = new MySqlConnection(connection))
            {
                sqlConnection.Open();
                MySqlCommand sqlCmd = new MySqlCommand("submitemployee", sqlConnection);//(@s_ID, @s_FName, @s_MInitial, @s_LName, @s_StartDate, @s_Addr, @s_Phone, @s_Sex, @s_DOB)
                sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("s_ID", TextBox1.Text);
                sqlCmd.Parameters.AddWithValue("s_FName", TextBox4.Text);
                sqlCmd.Parameters.AddWithValue("s_MInitial", TextBox5.Text);
                sqlCmd.Parameters.AddWithValue("s_LName", TextBox6.Text);
                sqlCmd.Parameters.AddWithValue("s_StartDate", TextBox2.Text);
                sqlCmd.Parameters.AddWithValue("s_Addr", TextBox3.Text);
                sqlCmd.Parameters.AddWithValue("s_Phone", TextBox7.Text);
                sqlCmd.Parameters.AddWithValue("s_Sex", TextBox8.Text);
                sqlCmd.Parameters.AddWithValue("s_DOB", TextBox9.Text);
                sqlCmd.ExecuteNonQuery();
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Form Submitted" + "');", true); 
                sqlConnection.Close();
            }
        }
    }
}