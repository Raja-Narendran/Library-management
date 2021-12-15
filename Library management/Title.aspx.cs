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
    public partial class Title : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=ITCLABJ66\\SQLEXPRESS;Initial Catalog=LibraryServer;Integrated Security=True");
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();

            string s = "insert into dbo.library_main(BookID,BooksName,stock) values('" + TxtID2.Text + "','" + Txtname1.Text + "'," + Txtstock3.Text+");";

            cmd = new SqlCommand(s, con);

            cmd.CommandType = CommandType.Text;

            try

            {

                int result = cmd.ExecuteNonQuery();

                if (result > 0)

                {

                    Label4.Text = "Added..!!";

                }

                else

                {

                    Label4.Text = "Failed To add ..!!";

                }

            }

            catch (SqlException ex)

            {

                Label4.Text = ex.Message;

            }

            finally

            {

                con.Close();

            }

            Txtname1.Text = "";

            TxtID2.Text = "";

            Txtstock3.Text = "";

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            con.Open();

            string s = ("delete from library_main where BookID='" + TxtBID3.Text + "';");

            cmd = new SqlCommand(s, con);

            cmd.CommandType = CommandType.Text;

            try

            {

                int result = cmd.ExecuteNonQuery();

                if (result > 0)

                {

                    Label5.Text = "Removed Successfully..!!";

                }

                else

                {

                    Label5.Text = "Failed To Remove ..!!";

                }

            }

            catch (SqlException ex)

            {

                Label5.Text = ex.Message;

            }

            finally

            {

                con.Close();

            }
            TxtBID3.Text = "";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            con.Open();

            string s = ("UPDATE library_main SET BooksName = '"+TextBox6.Text+"' WHERE BookID=" + TxtBod1.Text+";");

            cmd = new SqlCommand(s, con);

            cmd.CommandType = CommandType.Text;

            try

            {

                int result = cmd.ExecuteNonQuery();

                if (result > 0)

                {

                    Label6.Text = "Successfully Renamed..!!";

                }

                else

                {

                    Label6.Text = "Failed To Rename ..!!";

                }

            }

            catch (SqlException ex)

            {

                Label6.Text = ex.Message;

            }

            finally

            {

                con.Close();

            }
            TextBox6.Text = "";
            TxtBod1.Text = "";
        }
    }
}