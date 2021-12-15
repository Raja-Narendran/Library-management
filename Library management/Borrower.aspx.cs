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
    public partial class Borrower : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=ITCLABJ66\\SQLEXPRESS;Initial Catalog=LibraryServer;Integrated Security=True");
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();

            string s = "insert into Borrowers values ( '" + TextBox1.Text + "','" + TextBox2.Text + "') ";

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

            string s = "Delete From Borrowers where BorrowID='"+TextBox1.Text+"';";

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

        protected void Button3_Click(object sender, EventArgs e)
        {

            con.Open();

            string s = "update Borrowers Set Borrowname= '"+TextBox4.Text+"' where BorrowId='"+TextBox3.Text+"';";

            cmd = new SqlCommand(s, con);

            cmd.CommandType = CommandType.Text;

            try

            {

                int result = cmd.ExecuteNonQuery();

                if (result > 0)

                {

                    Label2.Text = "Changed..!!";

                }

                else

                {

                    Label2.Text = "Failed To Changed ..!!";

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
            TextBox3.Text = "";
            TextBox4.Text = "";
        }
    }
}