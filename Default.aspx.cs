using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;

namespace UnhandledExceptionWebApp
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnStackOverflow_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/StackOverflow.aspx", false);
        }

        protected void btnException_Click(object sender, EventArgs e)
        {
            // This will raise an exception, which we won't handle here
            throw (new Exception("Test Exception"));
        }

        protected void btnUnhandled_Click(object sender, EventArgs e)
        {
            // Queue the task.
            ThreadPool.QueueUserWorkItem(new WaitCallback(ThreadProc));

            // If you comment out the Sleep, the main thread exits before
            // the thread pool task runs.  The thread pool uses background
            // threads, which do not keep the application running.  (This
            // is a simple example of a race condition.)
            Thread.Sleep(1000);
        }

        // This thread procedure performs the task.
        static void ThreadProc(Object stateInfo) {
            throw (new Exception("Test Unhandled exception"));
        }
    }
}
