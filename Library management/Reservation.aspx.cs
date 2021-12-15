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
    public partial class Reservation : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=ITCLABJ66\\SQLEXPRESS;Initial Catalog=LibraryServer;Integrated Security=True");
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();

            string s = "insert into reservation (BorrowId, BookID) values ('" + TxtBo2.Text + "','" + TxtID1.Text + "') ";

            cmd = new SqlCommand(s, con);

            cmd.CommandType = CommandType.Text;

            try

            {

                int result = cmd.ExecuteNonQuery();

                if (result > 0)

                {

                    Label4.Text = "Made reservation..!!";

                }

                else

                {

                    Label4.Text = "Failed To Reserve ..!!";

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

            TxtID1.Text = "";

            TxtBo2.Text = "";

    }

        protected void Button3_Click(object sender, EventArgs e)
        {
            con.Open();

            string s = ("delete from reservation where BorrowId='"+TxtBo2.Text+"';");

            cmd = new SqlCommand(s, con);

            cmd.CommandType = CommandType.Text;

            try

            {

                int result = cmd.ExecuteNonQuery();

                if (result > 0)

                {

                    Label4.Text = "Reservation Canceled..!!";

                }

                else

                {

                    Label4.Text = "Failed To Cancel ..!!";

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

            TxtID1.Text = "";

            TxtBo2.Text = "";

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            con.Open();

            string s = "update reservation Set Lended=(Lended+1) where BookID='"+TxtBox6.Text+"' and BorrowId='"+ TxtBID4.Text+"';";

            cmd = new SqlCommand(s, con);

            cmd.CommandType = CommandType.Text;

            try

            {

                int result = cmd.ExecuteNonQuery();

                if (result > 0)

                {

                    Label5.Text = "Lended..!!";

                }

                else

                {

                    Label5.Text = "Failed To Lend ..!!";

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

            TxtBID4.Text = "";

            TxtBox6.Text = "";

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            con.Open();

            string s = "update reservation Set Lended=(Lended - 1) where BookID='" + TxtBox6.Text + "' and BorrowId='" + TxtBID4.Text + "';";

            cmd = new SqlCommand(s, con);

            cmd.CommandType = CommandType.Text;

            try

            {

                int result = cmd.ExecuteNonQuery();

                if (result > 0)

                {

                    Label5.Text = "Returned..!!";

                }

                else

                {

                    Label5.Text = "Failed To return ..!!";

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

            TxtBID4.Text = "";

            TxtBox6.Text = "";

        }
    }
}