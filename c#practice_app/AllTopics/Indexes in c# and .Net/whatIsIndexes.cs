using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Amol
{
    /*
        public partial class Indexes : System.Web.UI.Page
        {
            protected void page_load(object sender, EventArgs e) {
                Session["Session1"] = "Session 1 Data";
                Session["Session2"] = "Session 2 Data";

                Response.Write("Session Data" + Session[0].ToString());          // here is one way to access index as number  - Integral Index
                Response.Write("<br/>");
                Response.Write("Session Data" + Session["Session2"].ToString()); //  here is one way to access index as string - String Index
            }
        }
    */

    /*
       string CS= ConfigurationManager.ConnectionString["DBMS"].ConnectionString;
       using (SqlConnection con = new SqlCOnnection(CS))
    
    {
    
        SqlCommand cmd = new SqlCommand("Select * from Emlployee",con);
        con.open();
        SqlDataReader rdr= cmd.ExecuteReader();

        While(rdr.Read()){                                                        // Reading every row of table

               Response.write(rdr[0].ToString());
               Response.write(rdr["Name"].ToString());
           }
        
    }

     
     */
}
