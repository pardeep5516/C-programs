public partial class_Default:System.web.UI.Page{
    public int empid;
    public string empname, city;
    protected void Page_load(object sender, EventArgs e){
        empid = 1;
        empname = "alice";
        city = "NY";
        this.DataBind();
    }
}
<asp:label Id="label" runat="server">
    empid = <% #empid %>
    empname = <% #empname %>
    city = <% #city %>
</asp:label>