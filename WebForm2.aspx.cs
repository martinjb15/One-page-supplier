using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace One_page_supplier
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string dbname = " _tours_ireland";
            if (RadioButtonList1.Text == "0")
            {
                dbname = " _tours_Scotland";
            }
            if (RadioButtonList1.Text == "1")
            {
                dbname = " _tours_ireland";
            }
            if (RadioButtonList1.Text == "2")
            {
                dbname = " _ireland";
            }
            string dbinstance = "";
            dbinstance = " -tourplan";
            Session.Add("dbname", dbname);
            Session.Add("dbinstance", dbinstance);



            if (!IsPostBack)
            {
                county(dbname, dbinstance);
                country(dbname, dbinstance);
                service(dbname, dbinstance);
            }
        }

        public void country(string dbname, string dbinstance)
        {
            string query = "";
            dbinstance = " -tourplan";
            string connetionString = "Server=" + dbinstance + ";Database=" + dbname + ";User ID=tpwebuser;Password= ";

            {
                SqlConnection cnn = new SqlConnection(connetionString);

                query = "select distinct CTR.DESCR from opt left join crm on opt.SUPPLIER = crm.CODE left join loc on opt.location = loc.code left join dst on dst.code = loc.dst_code left join ctr on dst.ctr = ctr.code order by CTR.DESCR";

                cnn.Open();

                SqlCommand queryCommand = new SqlCommand(query, cnn);
                SqlDataReader queryCommandReader = queryCommand.ExecuteReader();
                DataTable dataTable = new DataTable("AgentDetails");
                dataTable.Load(queryCommandReader);
                cnn.Close();

                int add = 1;

                foreach (DataRow dr in dataTable.Rows)
                {
                    DropDownList1.Items.Add(dr["DESCR"].ToString());
                    DropDownList1.Items[add].Value = dr["DESCR"].ToString();
                    add++;
                }
            }
        }

        public void county(string dbname, string dbinstance)
        {
            string query = "";
            dbinstance = " -tourplan";
            string connetionString = "Server=" + dbinstance + ";Database=" + dbname + ";User ID=tpwebuser;Password= ";

            {

                SqlConnection cnn = new SqlConnection(connetionString);

                query = "select distinct dst.DESCR from opt left join crm on opt.SUPPLIER = crm.CODE left join loc on opt.location = loc.code left join dst on dst.code = loc.dst_code left join ctr on dst.ctr = ctr.code where ctr.DESCR = '" +
                    DropDownList1.SelectedValue.ToString() + "' order by dst.DESCR";

                cnn.Open();

                SqlCommand queryCommand = new SqlCommand(query, cnn);
                SqlDataReader queryCommandReader = queryCommand.ExecuteReader();
                DataTable dataTable = new DataTable("AgentDetails");
                dataTable.Load(queryCommandReader);
                cnn.Close();

                int add = 1;
                DropDownList2.Items.Clear();
                DropDownList2.Items.Add("Please Select ......");
                DropDownList2.Items[0].Value = "ps";
                foreach (DataRow dr in dataTable.Rows)
                {
                    DropDownList2.Items.Add(dr["DESCR"].ToString());
                    DropDownList2.Items[add].Value = dr["DESCR"].ToString();
                    add++;
                }

            }

        }

        public void service(string dbname, string dbinstance)
        {
            {
                string query = "";
                dbinstance = " -tourplan";
                string connetionString = "Server=" + dbinstance + ";Database=" + dbname + ";User ID=tpwebuser;Password= ";


                SqlConnection cnn = new SqlConnection(connetionString);

                query = "select distinct opt.SERVICE from opt left join crm on opt.SUPPLIER = crm.CODE order by opt.SERVICE";

                cnn.Open();

                SqlCommand queryCommand = new SqlCommand(query, cnn);
                SqlDataReader queryCommandReader = queryCommand.ExecuteReader();
                DataTable dataTable = new DataTable("AgentDetails");
                dataTable.Load(queryCommandReader);
                cnn.Close();

                int add = 1;

                foreach (DataRow dr in dataTable.Rows)
                {
                    DropDownList3.Items.Add(dr["service"].ToString());
                    DropDownList3.Items[add].Value = dr["service"].ToString();
                    add++;
                }
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dbname = " _tours_ireland";
            if (RadioButtonList1.Text == "0")
            {
                dbname = " _tours_Scotland";
            }
            if (RadioButtonList1.Text == "1")
            {
                dbname = " _tours_ireland";
            }
            if (RadioButtonList1.Text == "2")
            {
                dbname = " _ireland";
            }
            string dbinstance = "";
            dbinstance = " -tourplan";


            county(dbname, dbinstance);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (DropDownList4.SelectedValue == "0")
            {
                searchNotes();
                GridView1.Visible = false;
                GridView2.Visible = true;
                GridView3.Visible = false;

            }
            if (DropDownList4.SelectedValue == "1")
            {
                searchDescription();
                GridView1.Visible = true;
                GridView2.Visible = false;
                GridView3.Visible = false;
            }
            if (DropDownList4.SelectedValue == "2")
            {
                searchComments();
                GridView1.Visible = false;
                GridView2.Visible = false;
                GridView3.Visible = true;
            }

        }
        public void searchDescription()
        {
            string[] search = TextBox1.Text.Split(' ');
            string query1 = "";
            for (int i = 0; i < search.Length; i++)
            {
                query1 += " and description like '%" + search[i] + "%' ";
            }


            string query2 = "";
            if (DropDownList3.SelectedIndex != 0)
            {
                query2 += " and service = '" + DropDownList3.SelectedItem.Text.ToString() + "' ";
            }

            string query3 = "";
            if (DropDownList2.SelectedIndex != 0)
            {
                query3 += " and locTable.DESCR = '" + DropDownList2.SelectedItem.Text.ToString() + "' ";
            }

            string query4 = "";
            if (DropDownList1.SelectedIndex != 0)
            {
                query4 += "locTable.country = '" + DropDownList1.SelectedItem.Text.ToString() + "' ";
            }


            string dbname = " _tours_ireland";
            if (RadioButtonList1.Text == "0")
            {
                dbname = " _tours_Scotland";
            }
            if (RadioButtonList1.Text == "1")
            {
                dbname = " _tours_ireland";
            }
            if (RadioButtonList1.Text == "2")
            {
                dbname = " _ireland";
            }
            string dbinstance = "";
            dbinstance = " -tourplan";

            string query = "";
            string connetionString = "Server=" + dbinstance + ";Database=" + dbname + ";User ID=tpwebuser;Password= ";


            SqlConnection cnn = new SqlConnection(connetionString);

            query = "select crm.CODE, crm.name, crm.ADDRESS1, locTable.DESCRIPTION from crm left join (select distinct dst.DESCR, ctr.DESCR as country, opt.service, opt.description, CRM.CODE from CRM left join OPT on opt.SUPPLIER = crm.CODE left join loc on opt.location = loc.code left join dst on dst.code = loc.dst_code left join ctr on dst.ctr = ctr.code) as locTable on locTable.CODE = CRM.CODE where " + query4 + query3 + query2 +
                query1;

            cnn.Open();

            SqlCommand queryCommand = new SqlCommand(query, cnn);
            SqlDataReader queryCommandReader = queryCommand.ExecuteReader();
            DataTable dataTable = new DataTable("AgentDetails");
            dataTable.Load(queryCommandReader);
            cnn.Close();
            dataTable.Columns["code"].MaxLength = 500;

            string url = "https://web. .ie/search/webform1.aspx/";
            string type = "?type=";
            string type2 = "&db=" + dbname;

            if (dataTable.Rows.Count > 0)
            {

                foreach (DataRow dr in dataTable.Rows)
                {
                    dr["code"] = @"<a href='" + url + type+ dr["code"] +type2 + @"'> " + dr["code"] + @"</a>";
                }
            }

            GridView1.DataSource = dataTable;
            GridView1.DataBind();
           
        }

        public void searchComments()
        {
            string[] search = TextBox1.Text.Split(' ');
            string query1 = "";
            for (int i = 0; i < search.Length; i++)
            {
                query1 += " and comment like '%" + search[i] + "%' ";
            }


            string query2 = "";
            if (DropDownList3.SelectedIndex != 0)
            {
                query2 += " and service = '" + DropDownList3.SelectedItem.Text.ToString() + "' ";
            }

            string query3 = "";
            if (DropDownList2.SelectedIndex != 0)
            {
                query3 += " and locTable.DESCR = '" + DropDownList2.SelectedItem.Text.ToString() + "' ";
            }

            string query4 = "";
            if (DropDownList1.SelectedIndex != 0)
            {
                query4 += "locTable.country = '" + DropDownList1.SelectedItem.Text.ToString() + "' ";
            }


            string dbname = " _tours_ireland";
            if (RadioButtonList1.Text == "0")
            {
                dbname = " _tours_Scotland";
            }
            if (RadioButtonList1.Text == "1")
            {
                dbname = " _tours_ireland";
            }
            if (RadioButtonList1.Text == "2")
            {
                dbname = " _ireland";
            }
            string dbinstance = "";
            dbinstance = " -tourplan";

            string query = "";
            string connetionString = "Server=" + dbinstance + ";Database=" + dbname + ";User ID=tpwebuser;Password= ";


            SqlConnection cnn = new SqlConnection(connetionString);

            query = "select crm.CODE, crm.name, crm.ADDRESS1, locTable.comment from crm left join (select distinct dst.DESCR, ctr.DESCR as country, opt.service, opt.comment, CRM.CODE from CRM left join OPT on opt.SUPPLIER = crm.CODE left join loc on opt.location = loc.code left join dst on dst.code = loc.dst_code left join ctr on dst.ctr = ctr.code) as locTable on locTable.CODE = CRM.CODE where " + query4 + query3 + query2 +
                query1;

            cnn.Open();

            SqlCommand queryCommand = new SqlCommand(query, cnn);
            SqlDataReader queryCommandReader = queryCommand.ExecuteReader();
            DataTable dataTable = new DataTable("AgentDetails");
            dataTable.Load(queryCommandReader);
            cnn.Close();
            dataTable.Columns["code"].MaxLength = 500;

            string url = "https://web. .ie/search/webform1.aspx/";
            string type = "?type=";
            string type2 = "&db=" + dbname;

            if (dataTable.Rows.Count > 0)
            {

                foreach (DataRow dr in dataTable.Rows)
                {
                    dr["code"] = @"<a href='" + url + type + dr["code"] + type2 + @"'> " + dr["code"] + @"</a>";
                }
            }

            GridView3.DataSource = dataTable;
            GridView3.DataBind();

        }

        public void searchNotes()
        {
            string[] search = TextBox1.Text.Split(' ');
            string query1 = "";
            for (int i = 0; i < search.Length; i++)
            {
                query1 += " and nts.MESSAGE_TEXT like '%" + search[i] + "%' ";
            }

            string service = "";
            string query2 = "";
            if (DropDownList3.SelectedIndex != 0)
            {
                service = "opt.service, ";
                query2 += " and service = '" + DropDownList3.SelectedItem.Text.ToString() + "' ";
            }


            string query3 = "";
            if (DropDownList2.SelectedIndex != 0)
            {
                query3 += " and locTable.DESCR = '" + DropDownList2.SelectedItem.Text.ToString() + "' ";
            }

            string query4 = "";
            if (DropDownList1.SelectedIndex != 0)
            {
                query4 += " and locTable.country = '" + DropDownList1.SelectedItem.Text.ToString() + "' ";
            }


            string dbname = " _tours_ireland";
            if (RadioButtonList1.Text == "0")
            {
                dbname = " _tours_Scotland";
            }
            if (RadioButtonList1.Text == "1")
            {
                dbname = " _tours_ireland";
            }
            if (RadioButtonList1.Text == "2")
            {
                dbname = " _ireland";
            }
            string dbinstance = "";
            dbinstance = " -tourplan";

            string query = "";
            string connetionString = "Server=" + dbinstance + ";Database=" + dbname + ";User ID=tpwebuser;Password= ";


            SqlConnection cnn = new SqlConnection(connetionString);

            query = "select crm.CODE, crm.name, crm.ADDRESS1, singeMessage.MESSAGE_TEXT from crm left join NTS on NTs.SUPPLIER_CODE = crm.CODE left join (select nts.SUPPLIER_CODE, nts.MESSAGE_TEXT, nts.NTS_ID  from NTS where nts.CATEGORY = 'SED' and nts.BHD_ID = 0) as singeMessage on singeMessage.nts_ID = NTS.NTS_ID and crm.code = singeMessage.SUPPLIER_CODE left join (select distinct dst.DESCR, ctr.DESCR as country, " + service + " CRM.CODE from CRM left join OPT on opt.SUPPLIER = crm.CODE left join loc on opt.location = loc.code left join dst on dst.code = loc.dst_code left join ctr on dst.ctr = ctr.code) as locTable on locTable.CODE = CRM.CODE where nts.CATEGORY = 'SED' and nts.BHD_ID = 0 " + query4 + query3 + query2 +
                query1;

            cnn.Open();

            SqlCommand queryCommand = new SqlCommand(query, cnn);
            SqlDataReader queryCommandReader = queryCommand.ExecuteReader();
            DataTable dataTable = new DataTable("AgentDetails");
            dataTable.Load(queryCommandReader);
            cnn.Close();

            dataTable.Columns["code"].MaxLength = 500;

            if (dataTable.Rows.Count > 0)
            {
                string url = "https://web. .ie/search/webform1.aspx/";
                string type = "?type=";
                string type2 = "&db=" + dbname;

                foreach (DataRow dr in dataTable.Rows)
                {                
                    dr["code"] = @"<a href='" + url + type+ dr["code"]+ type2 + @"'> " + dr["code"] + @"</a>";
                }
            }


            GridView2.DataSource = dataTable;
            GridView2.DataBind();
         

        }

        public string rtfreturn(string rtftext)
        {
            string normaltext = "";
            try
            {
                Process rtfapp = new Process();
                ProcessStartInfo pstart = new ProcessStartInfo();
                pstart.FileName = "RTFtoTextApp.exe";
                pstart.RedirectStandardOutput = true;
                pstart.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory + @"App_Data\";
                pstart.UseShellExecute = false;
                pstart.Arguments = @"""" + rtftext + @"""";
                pstart.FileName = AppDomain.CurrentDomain.BaseDirectory + @"App_Data\RTFtoTextApp.exe";
                rtfapp.StartInfo = pstart;
                rtfapp.Start();

                using (StreamReader output = rtfapp.StandardOutput)
                {
                    normaltext = output.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                normaltext = ex.InnerException.Message.ToString();
            }

            return normaltext;
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            searchDescription();
            GridView1.PageSize = 50;


        }
        
        protected void GridView2_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView2.PageIndex = e.NewPageIndex;
            searchNotes();
        }

        protected void GridView2_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "updating")
            {
                int index = Convert.ToInt32(e.CommandArgument);

                GridViewRow row = GridView2.Rows[index];
                GridView2.Rows[index].Cells[5].Text = rtfreturn(GridView2.Rows[index].Cells[5].Text.ToString().Trim());
                GridView2.Rows[index].Cells[5].Visible = true;
            }
        }

        protected void GridView2_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            int t =  e.Row.Cells.Count;
            try
            {
                e.Row.Cells[5].Visible = false;
            }
            catch(Exception cat)
            {
                string dog = cat.Message;     
            }

            }

        protected void GridView3_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView3.PageIndex = e.NewPageIndex;
            searchComments();
        }
    }
}