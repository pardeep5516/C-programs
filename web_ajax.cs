public partial class_Default:System.web.UI.Page{
    protected void Page_load(object sender, EventArgs e){
        
    }
    protected void Button1_Click(object sender, EventArgs e){
        String t1 = DateTime.Now.toString();
        Label1.Text = "showing time from update panel" + t1;
        Label2.Text = "showing time from outside ipdate panel " + t1;
    }
    protected void Button2_Click(object sender, EventArgs e){
        String t1 = DateTime.Now.toString();
        Label1.Text = "showing time from update panel" + t1;
        Label2.Text = "showing time from outside ipdate panel " + t1;
    }
}