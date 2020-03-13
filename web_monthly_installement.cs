public partial class_Default:System.web.UI.Page
{
    int rate, year, ammount, total, monthaly;
    protected void Page_load(object sender, EventArgs e)
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e){
        ammount = Convert.ToInt32(TextBox1.Text);
        year = Convert.ToInt32(DropDownList1.SelectedItem.value);
        if(year == 5){
            rate = Convert.ToInt32(ConfigurationManager.AppSetting["5y's"]);
        }else if(year == 10){
            rate = Convert.ToInt32(ConfigurationManager.AppSetting["10Y's"]);
        }else{
            rate = Convert.ToInt32(ConfigurationManager.AppSetting["15Y's"]);
        }
        total = ammount + (ammount * rate * year) / 100;
        if(year == 5){
            monthaly = total / 60;
        }else if(year == 10){
            monthaly = total / 120;
        }else{
            monthaly = total / 180;
        }
        Label3.Text = "Total Amount to be paid = " + total + "and monthaly installement is = " + monthaly; 
    }
}