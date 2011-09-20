using System;
using System.Web;

namespace UnhandledExceptionWebApp
{
    public class Global : System.Web.HttpApplication
    {
        void Application_Error(object sender, EventArgs e)
        {
            Exception ex = Server.GetLastError();

            // The original error may have been wrapped in a HttpUnhandledException, 
            // so we need to log the details of the InnerException.
            ex = ex.InnerException ?? ex;

            try
            {
                // Log the error
                string errMsg = string.Empty;
                if (ex.Message != null) errMsg = "Message:" + ex.Message + "\r\n";
                if (ex.StackTrace != null) errMsg += "Stack Trace:" + ex.StackTrace;
                // * WRITE TO LOG * 
                
                Server.ClearError();
            }
            catch
            {
            }

            Response.Redirect("~/Error.aspx?err=" + ex.Message, false);
        }
    }
}
