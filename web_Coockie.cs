public partial class_Default:System.web.UI.Page
{
    protected void Page_load(object sender, EventArgs e)
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e){
        HttpCookie cookie = new HttpCookie("user");
        cookie["language"] = TetxBox1.Text;
        cookie["country"] = TetxBox2.Text;
        Response.Cooke.Add(cookie);
        Response.Redirect("Default2.aspx");
    }
}
//Default2.aspx.cs file
public partial class_Default:System.web.UI.Page
{
    protected void Page_load(object sender, EventArgs e)
    {
        HttpCookie cookie = new Request.Cooke["user"];
        Label1.Text = cookie["language"];
        Label2.Text = cookie["country"];
        
    }
}