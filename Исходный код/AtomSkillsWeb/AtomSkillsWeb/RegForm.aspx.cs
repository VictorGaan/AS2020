using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AtomSkillsWeb
{
    public partial class RegForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnReg_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            if (string.IsNullOrWhiteSpace(TbLastName.Text)) sb.Append("Поле фамилия не заполнено!\n");
            if (string.IsNullOrWhiteSpace(TbFirstName.Text)) sb.Append("Поле имя должно не заполнено!\n");
            if (string.IsNullOrWhiteSpace(TbEmail.Text)) sb.Append("Поле email не заполнено!\n");
            if (!Regex.Match(TbEmail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Success) sb.Append("Неверный формат email!\n");
            if (string.IsNullOrWhiteSpace(TbPassword.Text)) sb.Append("Поле пароль не заполнено!\n");
            if (string.IsNullOrWhiteSpace(TbPasswordSubmit.Text)) sb.Append("Поле подтвердите пароль не заполнено!\n");
            if (TbPassword.Text!=TbPasswordSubmit.Text)
            {
                sb.Append("Пароли не совпадают!\n");
            }
            if (sb.Length>1)
            {
                Response.Write($"<script>alert('Ошибка введенных данных');</script>");
                return;
            }
            Users user = new Users
            {
                FirstName = TbFirstName.Text,
                LastName = TbLastName.Text,
                MiddleName = TbMiddleName.Text,
                Email = TbEmail.Text,
                Password = TbPassword.Text
            };
            Manager.context.Users.Add(user);
            Manager.context.SaveChanges();
            Manager.user = user;
            Response.Write("<script>alert('Пользователь зарегистрирован!');</script>");
            Response.Redirect("OrderForm.aspx");
        }
    }
}