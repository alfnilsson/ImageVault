namespace Toders.ImageVaultScriptWorkaround
{
    using System.Web;

    public class InsertMediaScriptHandler : IHttpHandler
    {
        public bool IsReusable
        {
            get { return true; }
        }

        public void ProcessRequest(HttpContext context)
        {
            context.Response.Clear();
            context.Response.ContentType = "text/plain; charset=utf-8";
            context.Response.Flush();
            context.Response.WriteFile(context.Server.MapPath("~/ImageVaultScriptWorkaround/insertmedia.min.js"));
            context.Response.End();
        }
    }
}
