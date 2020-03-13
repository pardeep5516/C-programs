public partial class_Default:System.web.UI.Page
{
    protected void Page_load(object sender, EventArgs e)
    {
        
    }
    protected void Button_Click(object sender, EventArgs e){
        Label1.Text = "Hello" + TextBox1.Text;
    }
}