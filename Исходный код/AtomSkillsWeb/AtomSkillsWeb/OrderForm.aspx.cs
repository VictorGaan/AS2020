using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AtomSkillsWeb
{
    public partial class OrderForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            OrdersGrid.DataSource = Manager.context.Orders.Where(x => x.IDStatus == 1).ToList();
            OrdersGrid.DataBind();
        }

        protected void BtnFilter_Click(object sender, EventArgs e)
        {
            OrdersGrid.DataSource = Manager.context.Orders.Where(x => x.AddressFrom == TbArea1.Text && x.AddressTo == TbArea2.Text).ToList();
            OrdersGrid.DataBind();
        }

        protected void BtnGo_Click(object sender, EventArgs e)
        {
            Orders order = new Orders
            {
                IDOperator = Manager.user.ID,
                IDSupplier = Manager.user.ID,
                Date = DateTime.Now,
                Price = Convert.ToDecimal(PriceList.SelectedValue),
                AddressFrom = TbAreaFrom.Text,
                AddressTo = TbAreaTo.Text,
                IDStatus = 1,
                IDTrans = 1,
            };
            Manager.context.Entry(order).State = System.Data.Entity.EntityState.Added;
            Manager.context.SaveChanges();
            Response.Write($"<script>alert('Заказ оформлен!');</script>");
            OrdersGrid.DataSource = Manager.context.Orders.Where(x => x.IDStatus == 1).ToList();
            OrdersGrid.DataBind();
        }

        protected void BtnCancel_Click(object sender, EventArgs e)
        {
            //Orders order = OrdersGrid.SelectedItem.DataItem as Orders;
            Button btn = (Button)sender;
            DataGridItem row = (DataGridItem)btn.NamingContainer;
            string id = row.Cells[1].Text;
            var order = Manager.context.Orders.Where(x => x.AddressFrom ==id).First();
            if (order != null)
            {
                Manager.context.Entry(order).Property(x => x.IDStatus).CurrentValue = 2;
                Manager.context.Entry(order).State = System.Data.Entity.EntityState.Modified;
                Manager.context.SaveChanges();
                Response.Write($"<script>alert('Заказ отменен!');</script>");
                OrdersGrid.DataSource = Manager.context.Orders.Where(x => x.IDStatus == 1).ToList();
                OrdersGrid.DataBind();
            }
        }
    }
}