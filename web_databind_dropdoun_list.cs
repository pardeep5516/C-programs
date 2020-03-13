using System.Collection;
public partial class_Default:System.web.UI.Page{
    protected void Page_load(object sender, EventArgs e){
        ArrayList fruits = new ArrayList();
        fruits.Add("mango");
        fruits.Add("Grapes");
        fruits.Add("Banana");
        fruits.Add("Apple");
        DropDownList1.Datasource = fruits;
        DropDownList.DataBind();
    }
    protected void DropDownList1_SelectesIndex(object sender, EventArgs e){
        Label1.Text = "I like " + DropDownList1.SelectedValue.toString();
     }
}