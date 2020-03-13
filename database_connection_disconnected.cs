using System.Data.Odbc;
public partial class_Default:System.web.UI.Page
{
    OdbcConnection conn = new OdbcConnection();
    protected void Page_load(object sender, EventArgs e)
    {
        conn.ConnectionString = "Dns=Xtreme sample Database 2008";
        OdbcDataAdapter da = new OdbcDataAdapter(
            "select * from emp", conn
        );
        DataSet ds = new DataSet();
        da.Fill(ds);
        GridView1.DataSource = ds;
        GridView1.DataBind();
    }
}