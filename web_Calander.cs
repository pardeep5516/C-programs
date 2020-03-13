public partial class_Default:System.web.UI.Page
{
    protected void Page_load(object sender, EventArgs e)
    {
        
    }
    protected void Calender1_Selection(object sender, EventArgs e){
        TextBox1.Text = Calender1.TodaysDate.toString();
        TextBox2.Text = Calender1.TodaysDate.toString();
    }
}