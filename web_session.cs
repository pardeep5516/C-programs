public partial class_Default:System.web.UI.Page
{
    protected void Page_load(object sender, EventArgs e)
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e){
        Session["name"] = Convert.ToString(TextBox1.Text);
        Session["age"] = Convert.ToString(TextBox2.Text);
        Session["Address"] = Convert.ToString(TextBox3.Text);
        Session["Contatc_no"] = Convert.ToString(TextBox4.Text);
        if(RadioButton1.Checked == true){
            Session["Gender"] = Convert.ToString(RadioButton1.Text);
        }
        else{
            Session["Gender"] = Convert.ToString(RadioButton2.Text);
        }
        Response.Redirect("Default2.aspx");
    }
}
//Default2.aspx.cs file
public partial class_Default:System.web.UI.Page
{
    protected void Page_load(object sender, EventArgs e)
    {
        Label1.Text = Convert.ToString(Session["name"]);
        Label2.Text = Convert.ToString(Session["age"]);
        Label3.Text = Convert.ToString(Session["Address"]);
        Label4.Text = Convert.ToString(Session["Contatc_no"]);
        Label5.Text = Convert.ToString(Session["Gender"]);
    }
}
