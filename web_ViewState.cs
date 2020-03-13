public partial class_Default:System.web.UI.Page
{
    int clicksCount;
    protected void Page_load(object sender, EventArgs e)
    {
        if(!postback){
            TextBox1.Tetx = "0";
        }
        
    }
    protected void Button1_Click(object sender, EventArgs e){
        if(ViewState["clicks"] != null){
            clicksCount = (int)ViewState["clicks"] + 1; 
         }
         TextBox1.Tetx = clicksCount.toString();
         ViewState["clicks"] = clicksCount;
    }
}