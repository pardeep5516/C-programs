using System.Threading;
public partial class_Default:System.web.UI.Page{
    protected void Page_load(object sender, EventArgs e){
        Label1.Text = DateTime.Now.toString();
    }
    protected void Button1_Click(object sender, EventArgs e){
        Thread.Sleep(1000);
        Response.Write("this page was generated and catche at " + DateTime.Now.toString);
    }
}

//defaulr.aspx file
<%@ OutputCatche Duration="50" VaryByParam = "none"%>