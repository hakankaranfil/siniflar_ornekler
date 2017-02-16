using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DropDownList
{
    public partial class DropPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //using(NorthwindEntities1 db = new NorthwindEntities1())
            //{
            //    List<Category> catlist = db.Categories.ToList();

            //    foreach (var item in catlist)
            //    {
            //        DropDownList1.Items.Add(item.ToString());
            //    }
            //}
            using (NorthwindEntities1 db = new NorthwindEntities1())
            {
                List<Category> catlist = db.Categories.ToList();
                DropDownList1.DataSource = catlist;
                DropDownList1.DataTextField = "CategoryName";
                DropDownList1.DataValueField = "CategoryID";
                DropDownList1.DataBind();

            }
        }
    }
}