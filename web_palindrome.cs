public partial class_Default:System.web.UI.Page
{
    protected void Page_load(object sender, EventArgs e)
    {
        
    }
    protected void Button_Click(object sender, EventArgs e){
        String s;
        s = TextBox1.ToString();
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        String s2 = new String(arr);
        if(s == s2){
            Label2.Text = "String is palindrome ";
        }else{
            Label2.Text = "String in Not palindrome";
        }
    }
}