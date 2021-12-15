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

    public partial class Loginpage : System.Web.UI.Page

    {



        protected void Page_Load(object sender, EventArgs e)

        {



        }

        protected void Button1_Click(object sender, EventArgs e)

        {

            SqlConnection con = new SqlConnection("Data Source=ITCLABJ66\\SQLEXPRESS;Initial Catalog=LibraryServer;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("Select * from loginpage where lemail='" + TextBox2.Text + "' and lpassword='" + TextBox3.Text + "'", con);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            string dropvalue = DropDownList1.SelectedValue.ToString();

            if (dt.Rows.Count > 0)

            {

                for (int i = 0; i < dt.Rows.Count; i++)

                {

                    if (dt.Rows[i]["lBranch"].ToString() == dropvalue)

                    {

                        Response.Redirect("maintanance.aspx");

                    }

                    else

                    {

                        Response.Redirect("Reservation.aspx");

                    }

                }

            }

            else

            {

                Label6.Text = "Invalid mail or password";

            }

        }

    }

}

