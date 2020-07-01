using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace delivery
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedPage1 : TabbedPage
    {
        public class OrderElem
        {
            public int orderNumber { get; set; }
            public string status { get; set; }
            public string addressShop { get; set; }
            public string addressDelivery { get; set; }
            public string client { get; set; }
            public string phone { get; set; }
            public string total { get; set; }
        }

        public List<OrderElem> Order { get; set; }


        public TabbedPage1()
        {
            InitializeComponent();
            Order = new List<OrderElem>
            {
                new OrderElem{ status = "Назначен", orderNumber = 1, addressDelivery = "улица Пушкина, 1", addressShop = "проспект Ленина, 47", client = "Иванов И.И.", phone = "+79139123123", total = "12112 руб." },
            };
            this.BindingContext = this;
        }
    }
}