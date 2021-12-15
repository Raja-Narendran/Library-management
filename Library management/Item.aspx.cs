using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Library_management
{
    public partial class Item : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=ITCLABJ66\\SQLEXPRESS;Initial Catalog=LibraryServer;Integrated Security=True");
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();

            string s = "update library_main Set stock = stock + '"+ TextBox2.Text +"' where BookID='" + TextBox1.Text + "';";

            cmd = new SqlCommand(s, con);

            cmd.CommandType = CommandType.Text;

            try

            {

                int result = cmd.ExecuteNonQuery();

                if (result > 0)

                {

                    Label1.Text = "Added..!!";

                }

                else

                {

                    Label1.Text = "Failed To add ..!!";

                }

            }

            catch (SqlException ex)

            {

                Label1.Text = ex.Message;

            }

            finally

            {

                con.Close();

            }
            TextBox1.Text = "";
            TextBox2.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            con.Open();

            string s = "update library_main Set stock = stock - '" + TextBox2.Text + "' where BookID='" + TextBox1.Text + "';";

            cmd = new SqlCommand(s, con);

            cmd.CommandType = CommandType.Text;

            try

            {

                int result = cmd.ExecuteNonQuery();

                if (result > 0)

                {

                    Label1.Text = "Removed..!!";

                }

                else

                {

                    Label1.Text = "Failed To Remove ..!!";

                }

            }

            catch (SqlException ex)

            {

                Label1.Text = ex.Message;

            }

            finally

            {

                con.Close();

            }
            TextBox1.Text = "";
            TextBox2.Text = "";
        }
    }
}