using AtomSkillsWeb.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AtomSkillsWeb
{
    public partial class MainForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Manager.context.Statuses.Count()==0)
            {
                Statuses status1 = new Statuses
                {
                    Name = "Исполняется"
                };
                Manager.context.Statuses.Add(status1);
                Manager.context.SaveChanges();
                Statuses status2 = new Statuses
                {
                    Name = "Отменен"
                };
                Manager.context.Statuses.Add(status2);
                Manager.context.SaveChanges();
                Brands brand = new Brands
                {
                    Name = "Toyota"
                };
                Manager.context.Brands.Add(brand);
                Manager.context.SaveChanges();
                Transports transport = new Transports
                {
                    IDBrand = 1,
                    Model = "Torneo-Dron",
                    Year = 2000,
                    Number = "TOR 123-345-678",
                    Date = Convert.ToDateTime("2020-01-20"),
                };
                Manager.context.Transports.Add(transport);
                Manager.context.SaveChanges();
            }
        }

        protected void BtnEnter_Click(object sender, EventArgs e)
        {
            var user = Manager.context.Users.SingleOrDefault(x => x.Email == TbLogin.Text && x.Password == TbPassword.Text);
            if (user!=null)
            {
                //if (ChLogin.Checked)
                //{

                //}
                Manager.user = user;
                Response.Write("<script>alert('Авторизация пройдена!');</script>");
                Response.Redirect("OrderForm.aspx");
            }
            else
            {
                Response.Write("<script>alert('Ошибка авторизации!');</script>");
            }
        }

        protected void BtnReg_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegForm.aspx");
        }
    }
}