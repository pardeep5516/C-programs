using System.Data.Odbc;
public partial class_Default:System.web.UI.Page
{
    OdbcConnection conn = new OdbcConnection();
    OdbcCommand cmd = new OdbcCommand();

    protected void Page_load(object sender, EventArgs e)
    {
        conn.ConnectionString = "Dns=Xtreme sample Database 2008";
        conn.open();
        cmd.Connection = conn;
        cmd.Command.Text = "Select * from emp";
        OdbcDataReader dr = cmd.executeReader();
        GridView1.DataSource = dr;
        GridView1.DataBind();
    }
}