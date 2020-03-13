public partial class_Default:System.web.UI.Page{
    protected void Page_load(object sender, EventArgs e){
        Response.Write("No of users visited on site" + Application["useronline"]); 
    }
}

//Global.axas file
<%@ Application language="c#" %>
    <script runat="server">
        void Application_Start(object sender, EventArgs e){
            Application["useronline"] = 0;
        }
        void Application_End(object sender, EventArgs e){

        }
        void Application_Error(object sender, EventArgs e){

        }
        void Session_Start(object sender, EventArgs e){
            Application.Lock();
            Application["useronline"] = (int)Application["useronline"] + 1;
            Application.UnLock();
        }
        void Session_Start(object sender, EventArgs e){
           Application.Lock();
           Application["useronline"] = (int)Application["useronline"] - 1;
           Application.UnLock();
        }
    </script>