using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Web.UI;

namespace One_page_supplier
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

                string type = Request.QueryString["type"];
                TextBox11.Text = type;
                string dbname = "";
                dbname = Request.QueryString["db"];

                if (dbname == " _tours_Scotland")
                {
                    RadioButtonList1.Text = "0";
                }
                if (dbname == " _tours_ireland")
                {
                    RadioButtonList1.Text = "1";
                }
                if (dbname == " _ireland")
                {
                    RadioButtonList1.Text = "2";
                }
                string dbinstance = "";
                dbinstance = " -tourplan";
                Session.Add("dbname", dbname);
                Session.Add("dbinstance", dbinstance);


                if (type != null)
                {
                    loaddetails(dbname, dbinstance);
                    bankDetails(dbname, dbinstance);
                    optionLines(dbname, dbinstance);
                    loadpolicies(dbname, dbinstance);
                    optionLines2(dbname, dbinstance);
                    iframe(dbname, dbinstance);
                    loadGallery();
                }
            }
        }

        public void bankDetails(string dbname, string dbinstance)
        {
            string connetionString = "Server=" + dbinstance + ";Database=" + dbname + ";User ID=tpwebuser;Password= ";

            SqlConnection cnn = new SqlConnection(connetionString);

            //run query connected to dropdownlist
            string query = "select crm.code, CRC.BRANCH, CRC.DEPARTMENT, CRC.ACCOUNT, crc.BANK, crc.BANK_BRANCH, crc.BANK_ACCOUNT, crc.ACCOUNT_NAME from crm left join crc on crc.CODE = crm.CODE where crm.code = '"
                + TextBox11.Text.ToString().Trim() +
                "' order by code";

            cnn.Open();

            SqlCommand queryCommand = new SqlCommand(query, cnn);
            SqlDataReader queryCommandReader = queryCommand.ExecuteReader();
            DataTable dataTable = new DataTable("AgentDetails");
            dataTable.Load(queryCommandReader);

            cnn.Close();

            // check the boxes in sql and if they are true tick the boxes
            foreach (DataRow dr in dataTable.Rows)
            {
                TextBox14.Text = dr["branch"].ToString().Trim();

                TextBox15.Text = dr["department"].ToString().Trim();

                TextBox16.Text = dr["account"].ToString().Trim();

                TextBox17.Text = dr["bank"].ToString().Trim();

                TextBox18.Text = dr["bank_branch"].ToString().Trim();

                TextBox19.Text = dr["bank_account"].ToString().Trim();
            }
        }

        public void englishDescription(string dbname, string dbinstance)
        {
            string connetionString = "Server=" + dbinstance + ";Database=" + dbname + ";User ID=tpwebuser;Password= ";

            SqlConnection cnn = new SqlConnection(connetionString);

            //run query connected to dropdownlist
            string query = "select crm.CODE, nts.MESSAGE_TEXT from crm left join nts on crm.CODE = nts.SUPPLIER_CODE where nts.CATEGORY = 'sed'and BSL_ID = 0 and crm.code = '"
                + TextBox11.Text.ToString().Trim() +
                "'";

            cnn.Open();

            SqlCommand queryCommand = new SqlCommand(query, cnn);
            SqlDataReader queryCommandReader = queryCommand.ExecuteReader();
            DataTable dataTable = new DataTable("AgentDetails");
            dataTable.Load(queryCommandReader);
            cnn.Close();

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow dr in dataTable.Rows)
                {
                    TextBox21.Text = rtfreturn(dr["MESSAGE_TEXT"].ToString().Trim());
                }
            }
            else
                TextBox21.Text = string.Empty;
        }

        public void FrenchDescription(string dbname, string dbinstance)
        {
            string connetionString = "Server=" + dbinstance + ";Database=" + dbname + ";User ID=tpwebuser;Password= ";

            SqlConnection cnn = new SqlConnection(connetionString);

            //run query connected to dropdownlist
            string query = "select crm.CODE, nts.MESSAGE_TEXT from crm left join nts on crm.CODE = nts.SUPPLIER_CODE where nts.CATEGORY = 'sfr'and BSL_ID = 0 and crm.code = '"
                + TextBox11.Text.ToString().Trim() +
                "'";

            cnn.Open();

            SqlCommand queryCommand = new SqlCommand(query, cnn);
            SqlDataReader queryCommandReader = queryCommand.ExecuteReader();
            DataTable dataTable = new DataTable("AgentDetails");
            dataTable.Load(queryCommandReader);
            cnn.Close();

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow dr in dataTable.Rows)
                {
                    TextBox23.Text = rtfreturn(dr["MESSAGE_TEXT"].ToString().Trim());
                }
            }
            else
                TextBox23.Text = string.Empty;
        }

        public void GermanDescription(string dbname, string dbinstance)
        {
            string connetionString = "Server=" + dbinstance + ";Database=" + dbname + ";User ID=tpwebuser;Password= ";

            SqlConnection cnn = new SqlConnection(connetionString);

            //run query connected to dropdownlist
            string query = "select crm.CODE, nts.MESSAGE_TEXT from crm left join nts on crm.CODE = nts.SUPPLIER_CODE where nts.CATEGORY = 'sge'and BSL_ID = 0 and crm.code = '"
                + TextBox11.Text.ToString().Trim() +
                "'";

            cnn.Open();

            SqlCommand queryCommand = new SqlCommand(query, cnn);
            SqlDataReader queryCommandReader = queryCommand.ExecuteReader();
            DataTable dataTable = new DataTable("AgentDetails");
            dataTable.Load(queryCommandReader);
            cnn.Close();

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow dr in dataTable.Rows)
                {
                    TextBox24.Text = rtfreturn(dr["MESSAGE_TEXT"].ToString().Trim());
                }
            }
            else
                TextBox24.Text = string.Empty;
        }

        public void ItalianDescription(string dbname, string dbinstance)
        {
            string connetionString = "Server=" + dbinstance + ";Database=" + dbname + ";User ID=tpwebuser;Password= ";

            SqlConnection cnn = new SqlConnection(connetionString);

            //run query connected to dropdownlist
            string query = "select crm.CODE, nts.MESSAGE_TEXT from crm left join nts on crm.CODE = nts.SUPPLIER_CODE where nts.CATEGORY = 'sit'and BSL_ID = 0 and crm.code = '"
                + TextBox11.Text.ToString().Trim() +
                "'";

            cnn.Open();

            SqlCommand queryCommand = new SqlCommand(query, cnn);
            SqlDataReader queryCommandReader = queryCommand.ExecuteReader();
            DataTable dataTable = new DataTable("AgentDetails");
            dataTable.Load(queryCommandReader);
            cnn.Close();

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow dr in dataTable.Rows)
                {
                    TextBox25.Text = rtfreturn(dr["MESSAGE_TEXT"].ToString().Trim());
                }
            }
            else
                TextBox25.Text = string.Empty;
        }

        public void loaddetails(string dbname, string dbinstance)
        {
            //create connection to database
            string connetionString = "Server=" + dbinstance + ";Database=" + dbname + ";User ID=tpwebuser;Password= ";

            SqlConnection cnn = new SqlConnection(connetionString);

            //run query connected to dropdownlist
            string query = "select distinct crm.address1, crm.address2, crm.address3, crm.name, crm.address4, crm.pcode, crm.code, crm.int_access FROM crm where crm.code ='" 
                + TextBox11.Text.ToString().Trim() + "' order by code";

            cnn.Open();

            SqlCommand queryCommand = new SqlCommand(query, cnn);
            SqlDataReader queryCommandReader = queryCommand.ExecuteReader();
            DataTable dataTable = new DataTable("AgentDetails");
            dataTable.Load(queryCommandReader);

            cnn.Close();

            // load data into textbox
            foreach (DataRow dr in dataTable.Rows)
            {
                TextBox5.Text = dr["name"].ToString();

                TextBox1.Text = dr["address1"].ToString().Trim();

                TextBox2.Text = dr["address2"].ToString().Trim();

                TextBox3.Text = dr["address3"].ToString().Trim();

                TextBox4.Text = (dr["address4"].ToString().Trim() + " " + dr["pcode"].ToString().Trim());
            }
        }

        public void loadpolicies(string dbname, string dbinstance)
        {
            string connetionString = "Server=" + dbinstance + ";Database=" + dbname + ";User ID=tpwebuser;Password= ";

            SqlConnection cnn = new SqlConnection(connetionString);

            //run query connected to dropdownlist
            string query = "select * from SOD left join crm on sod.SOD_ID = CRM.SOD_ID where crm.code = '"
                + TextBox11.Text.ToString().Trim() +
                "' order by code";

            cnn.Open();

            SqlCommand queryCommand = new SqlCommand(query, cnn);
            SqlDataReader queryCommandReader = queryCommand.ExecuteReader();
            DataTable dataTable = new DataTable("AgentDetails");
            dataTable.Load(queryCommandReader);

            cnn.Close();

            // check the boxes in sql and if they are true tick the boxes
            foreach (DataRow dr in dataTable.Rows)
            {
                if (Convert.ToBoolean(dr["start_mon"].ToString()) == true)
                    CheckBox1.Checked = true;
                else
                    CheckBox1.Checked = false;

                if (Convert.ToBoolean(dr["start_tue"].ToString()) == true)
                    CheckBox2.Checked = true;
                else
                    CheckBox2.Checked = false;

                if (Convert.ToBoolean(dr["start_wed"].ToString()) == true)
                    CheckBox3.Checked = true;
                else
                    CheckBox3.Checked = false;

                if (Convert.ToBoolean(dr["start_thu"].ToString()) == true)
                    CheckBox4.Checked = true;
                else
                    CheckBox4.Checked = false;

                if (Convert.ToBoolean(dr["start_fri"].ToString()) == true)
                    CheckBox5.Checked = true;
                else
                    CheckBox5.Checked = false;

                if (Convert.ToBoolean(dr["start_sat"].ToString()) == true)
                    CheckBox6.Checked = true;
                else
                    CheckBox6.Checked = false;

                if (Convert.ToBoolean(dr["start_sun"].ToString()) == true)
                    CheckBox7.Checked = true;
                else
                    CheckBox7.Checked = false;

                // Room Policies checkbox

                if (Convert.ToBoolean(dr["single_avail"].ToString()) == true)
                    CheckBox8.Checked = true;
                else
                    CheckBox8.Checked = false;

                if (Convert.ToBoolean(dr["twin_avail"].ToString()) == true)
                    CheckBox9.Checked = true;
                else
                    CheckBox9.Checked = false;

                if (Convert.ToBoolean(dr["double_avail"].ToString()) == true)
                    CheckBox10.Checked = true;
                else
                    CheckBox10.Checked = false;

                if (Convert.ToBoolean(dr["triple_avail"].ToString()) == true)
                    CheckBox11.Checked = true;
                else
                    CheckBox11.Checked = false;

                if (Convert.ToBoolean(dr["quad_avail"].ToString()) == true)
                    CheckBox12.Checked = true;
                else
                    CheckBox12.Checked = false;

                if (Convert.ToBoolean(dr["other_avail"].ToString()) == true)
                    CheckBox13.Checked = true;
                else
                    CheckBox13.Checked = false;
            }
        }

        public void optionLines(string dbname, string dbinstance)
        {
            string connetionString = "Server=" + dbinstance + ";Database=" + dbname + ";User ID=tpwebuser;Password= ";

            SqlConnection cnn = new SqlConnection(connetionString);


            string query = "select distinct crm.CODE,opt.SERVICE, opt.SUPPLIER, opt.CODE as 'option code', opt.DESCRIPTION, opd.SS as 'Single Room Cost' , opd.TW as 'Twin Room Cost',  opd.TR as 'Triple Room Cost', opd.QR as 'Quad Room Cost', opd.ADD_ADULT1 as 'Add adult', osr.DATE_FROM, OSR.DATE_TO from OPT left join CRM on CRM.CODE = opt.SUPPLIER left join osr on opt.OPT_ID = osr.OPT_ID left join opd on OSR.OSR_ID = opd.OSR_ID where crm.code = '"
                + TextBox11.Text.ToString().Trim() +
                "'and osr.DATE_FROM >= '2016-01-01' and opt.SERVICE = 'AC' order by osr.Date_from";

            cnn.Open();

            SqlCommand queryCommand = new SqlCommand(query, cnn);
            SqlDataReader queryCommandReader = queryCommand.ExecuteReader();
            DataTable dataTable = new DataTable("AgentDetails");
            dataTable.Load(queryCommandReader);
            cnn.Close();

            GridView1.DataSource = dataTable;
            GridView1.DataBind();
        }

        public void optionLines2(string dbname, string dbinstance)
        {
            string connetionString = "Server=" + dbinstance + ";Database=" + dbname + ";User ID=tpwebuser;Password= ";

            SqlConnection cnn = new SqlConnection(connetionString);


            string query = "select distinct crm.CODE,opt.SERVICE, opt.SUPPLIER, opt.CODE as 'option code', opt.DESCRIPTION from crm left join opt on crm.code = opt.SUPPLIER  where crm.code = '"
                + TextBox11.Text.ToString().Trim() +
                "'and opt.SERVICE != 'AC'";

            cnn.Open();

            SqlCommand queryCommand = new SqlCommand(query, cnn);
            SqlDataReader queryCommandReader = queryCommand.ExecuteReader();
            DataTable dataTable = new DataTable("AgentDetails");
            dataTable.Load(queryCommandReader);
            cnn.Close();

            GridView3.DataSource = dataTable;
            GridView3.DataBind();
        }

        // rtf conversion
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

        public void SpanishDescription(string dbname, string dbinstance)
        {
            string connetionString = "Server=" + dbinstance + ";Database=" + dbname + ";User ID=tpwebuser;Password= ";

            SqlConnection cnn = new SqlConnection(connetionString);

            string query = "select crm.CODE, nts.MESSAGE_TEXT from crm left join nts on crm.CODE = nts.SUPPLIER_CODE where nts.CATEGORY = 'SSP' and BSL_ID = 0 and crm.code = '"
                + TextBox11.Text.ToString().Trim() +
                "'";

            cnn.Open();

            SqlCommand queryCommand = new SqlCommand(query, cnn);
            SqlDataReader queryCommandReader = queryCommand.ExecuteReader();
            DataTable dataTable = new DataTable("AgentDetails");
            dataTable.Load(queryCommandReader);
            cnn.Close();

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow dr in dataTable.Rows)
                {
                    TextBox26.Text = rtfreturn(dr["MESSAGE_TEXT"].ToString().Trim());
                }
            }
            else
                TextBox26.Text = string.Empty;
        }





        protected void Button10_Click(object sender, EventArgs e)
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

            string dbinstance = " -tourplan";

            GridView1.DataSource = null;
            TextBox21.Text = string.Empty;
            TextBox23.Text = string.Empty;
            TextBox24.Text = string.Empty;
            TextBox25.Text = string.Empty;
            TextBox26.Text = string.Empty;

            loaddetails(dbname, dbinstance);
            bankDetails(dbname, dbinstance);
            optionLines(dbname, dbinstance);
            loadpolicies(dbname, dbinstance);
            optionLines2(dbname, dbinstance);
            iframe(dbname, dbinstance);
            loadGallery();



           

        }

        public void iframe(string dbname, string dbinstance)
        {
            string connetionString = "Server=" + dbinstance + ";Database=" + dbname + ";User ID=tpwebuser;Password= ";

            SqlConnection cnn = new SqlConnection(connetionString);

            string query = "select crm.CODE, nts.MESSAGE_TEXT from crm left join nts on crm.CODE = nts.SUPPLIER_CODE where nts.CATEGORY = 'GEO' and BSL_ID = 0 and crm.code = '"
                + TextBox11.Text.ToString().Trim() +
                "'";

            cnn.Open();

            SqlCommand queryCommand = new SqlCommand(query, cnn);
            SqlDataReader queryCommandReader = queryCommand.ExecuteReader();
            DataTable dataTable = new DataTable("AgentDetails");
            dataTable.Load(queryCommandReader);
            cnn.Close();

            if (dataTable.Rows.Count != 0)
            {
                string geo = dataTable.Rows[0]["MESSAGE_TEXT"].ToString().Trim();

                string url = "https://www.google.ie/maps?q=";
                string key = "&key=AIzaSyBUO7_n9t9Lvzaqv3beI7hFp2TWx_VffPc&output=embed";
                string combine = url + geo + key;
                //myiFrame.Controls.Add(new LiteralControl("<iframe src='" +combine+ "'></iframe><br />"));
                myiFrame.Src = combine;
            }
            if(dataTable.Rows.Count <= 0)
            {
                Label21.Visible = true;
                myiFrame.Visible = false;
            }
            else
            {
                Label21.Visible = false;
                myiFrame.Visible = true;
            }
        }



        protected void GridView1_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            string dbinstance = "";
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
            dbinstance = " -tourplan";
            optionLines(dbname, dbinstance);
        }

        protected void Button1_Click(object sender, EventArgs e)
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


            string dbinstance = " -tourplan";
            englishDescription(dbname, dbinstance);
            FrenchDescription(dbname, dbinstance);
            GermanDescription(dbname, dbinstance);
            ItalianDescription(dbname, dbinstance);
            SpanishDescription(dbname, dbinstance);

            TextBox21.Visible = true;
            TextBox23.Visible = true;
            TextBox24.Visible = true;
            TextBox25.Visible = true;
            TextBox26.Visible = true;
            LinkButton1.Visible = true;
            Button1.Visible = false;

            Label14.Visible = true;
            Label15.Visible = true;
            Label17.Visible = true;
            Label18.Visible = true;
            Label19.Visible = true;
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            TextBox21.Visible = false;
            TextBox26.Visible = false;
            TextBox23.Visible = false;
            TextBox24.Visible = false;
            TextBox25.Visible = false;
            LinkButton1.Visible = false;
            Button1.Visible = true;

            Label14.Visible = false;
            Label15.Visible = false;
            Label17.Visible = false;
            Label18.Visible = false;
            Label19.Visible = false;

        }

        public void loadGallery()
        {
            try
            {
                DataTable img = new DataTable();
                img.Columns.Add("imgs");
                DirectoryInfo di = new DirectoryInfo(@"// -ftp01/Public/Tourplan_Pictures/Supplier_" + TextBox11.Text.ToString().Trim());
                foreach (var fi in di.GetFiles())
                {
                    if (fi.Name.ToLower() != "thumbs.db")
                    {
                        img.Rows.Add(@"http:// -ftp01/Supplier_" + TextBox11.Text.ToString().Trim() + "/" + fi.Name);

                    }

                }
                GridView2.DataSource = img;
                GridView2.DataBind();
               
                   
               
            }
            catch(Exception ex)
            {
                GridView2.DataSource = null;
                GridView2.DataBind();
                string msg = ex.Message;
            }
        }
       

        protected void GridView3_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            string dbinstance = "";
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
            dbinstance = " -tourplan";
            GridView3.PageIndex = e.NewPageIndex;
            optionLines2(dbname, dbinstance);
            
            
        }   


    }
}