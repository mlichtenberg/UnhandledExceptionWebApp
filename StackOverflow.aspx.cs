using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UnhandledExceptionWebApp
{
    // Attribute doesn't seem to work as advertised
    [System.Security.SecurityCritical]
    public partial class StackOverflow : System.Web.UI.Page
    {
        // Attribute doesn't seem to work as advertised; the stack overflow is NOT caught before the process is terminated
        [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                this.Overflow(true);
            }
            catch (Exception ex)
            {
                Response.Redirect("~/Error.aspx?err=" + ex.Message, false);
            }
        }

        // Recursive function causes stack overflow
        private void Overflow(Boolean keepGoing)
        {
            if (keepGoing) this.Overflow(keepGoing);
        }
    }
}