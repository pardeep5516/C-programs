public partial class_Default:System.web.UI.Page
{
    protected void Page_load(object sender, EventArgs e)
    {
        
    }
    protected void ListBox1_SelectedIndexChange(object sender, EventArgs e){
        Label1.Text = "Your Selected Ice_creem flavour is " + ListBox.SelectedItem.ToString();
     }
}