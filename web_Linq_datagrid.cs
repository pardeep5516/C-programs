public partial class_Default:System.web.UI.Page{
    protected void Page_load(object sender, EventArgs e){
        List<Stud> student = new Stud.GEtStudData();
        var qwery = from f in student orderby f.fname select f;
        this.GridView.DataSource = qwery;
        GridView1.DataBind();
    }
}

//create a new cs file
using System.Collection.Generic;
public class Stud{
    public int id {get; set;}
    public String fname {get; set;}
    public String lname {get; set;}
    public static List<Stud> GEtStudData(){
        List<stud> list = new List<stud>();
        list.Add(new Stud{
            id = 1;
            fname = "alice";
            lname = "ray";
        });
        list.Add(new Stud{
            id = 2;
            fname = "alex";
            lname = "rani";
        });
        return list;
    }
}