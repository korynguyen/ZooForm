using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;


namespace Attraction
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string connection = "Server=team4zoodb.mysql.database.azure.com; Port=3306; Database=zoo; Uid=Team4@team4zoodb; Pwd=4thTeamRocks; SslMode=Preferred;";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            //Specify and connect to the DB
            using (MySqlConnection sqlConnection = new MySqlConnection(connection))
            {

                sqlConnection.Open();
                // Call the stored routine submitemployee (I custom created it inside mySQL) which will insert all the info from the webform. The parameter are in the comment below
                MySqlCommand sqlCmd = new MySqlCommand("submitattraction", sqlConnection);//(@s_ID, @s_FName, @s_MInitial, @s_LName, @s_StartDate, @s_Addr, @s_Phone, @s_Sex, @s_DOB)
                sqlCmd.CommandType = System.Data.CommandType.StoredProcedure; // specify the command "submit employee" above, which is a Stored Procedure/Routine
                sqlCmd.Parameters.AddWithValue("s_Name", Name.Text); // Get values entered from the textboxes into the respective variable
                sqlCmd.Parameters.AddWithValue("s_ManagerID", ManagerID.Text);
                sqlCmd.Parameters.AddWithValue("s_AnimalID", AnimalID.Text);
                sqlCmd.Parameters.AddWithValue("s_Price", Price.Text);
                sqlCmd.Parameters.AddWithValue("s_UpkeepCost", UpkeepCost.Text);
                


                sqlCmd.ExecuteNonQuery(); // execute query
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "Form Submitted" + "');", true); // pop up message when it is done submitting
                sqlConnection.Close();
            }
        }
    }
}