using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Net.Mail;using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Net.Mail;

public partial class Error : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Page.Title = "  Tours Error";



        if ((Exception)Application["TheException"] != null)
        {
            Exception caughtException = (Exception)Application["TheException"];
            SmtpClient sc = new SmtpClient("mailhost");
            MailMessage msg = new MailMessage();
            msg.To.Add("martin@ .ie");
            msg.From = new MailAddress("informationsystems@ .ie");
            msg.IsBodyHtml = true;
            msg.Subject = "Error: Setup Form";
            string erro = "";

            erro += AppDomain.CurrentDomain.BaseDirectory.ToString();

            if (caughtException.Message != null)
            {
                erro += " <br><br>Message: <br><br>" + caughtException.Message.ToString();
            }
            /*if (caughtException.InnerException.InnerException != null)
            {
                erro += " <br><br>InnerException: <br><br>" + caughtException.InnerException.InnerException.ToString();
            }*/
            if (caughtException.InnerException != null)
            {
                erro += " <br><br>InnerException: <br><br>" + caughtException.InnerException.ToString();
            }
            if (caughtException.StackTrace != null)
            {
                erro += " <br><br>StackTrace: <br><br>" + caughtException.StackTrace.ToString();
            }
            if (caughtException.Source != null)
            {
                erro += " <br><br>Source: <br><br>" + caughtException.Source.ToString();
            }
 
            erro += "<br><br>" + Server.MachineName.ToString();
            msg.Body = erro;
            sc.Send(msg);
        }
        else
        {
            SmtpClient sc = new SmtpClient("mailhost");
            MailMessage msg = new MailMessage();
            msg.To.Add("martin@ .ie");
            msg.From = new MailAddress("informationsystems@ .ie");
            msg.IsBodyHtml = true;
            msg.Subject = "Error: Unknown";
            string erro = "";
            msg.Body = "Some error happened on " + Server.MachineName.ToString();
            sc.Send(msg);
        }
    }
}
