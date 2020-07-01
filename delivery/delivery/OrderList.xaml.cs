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
	public partial class OrderList : ContentPage
    {
        public class OrderItem
        {
            public int orderNumber { get; set; }
            public string status { get; set; }
        }

        public List<OrderItem> Orders { get; set; }

        public OrderList()
        {
            InitializeComponent();
            Orders = new List<OrderItem>
            {
                new OrderItem{ status = "Назначен", orderNumber = 1 },
                new OrderItem{ status = "Завершен", orderNumber = 2 }
            };
            this.BindingContext = this;
        }
        public async void onItemClick(object sender, ItemTappedEventArgs e)
        {
            await Navigation.PushAsync(new TabbedPage1());
        }
    }
}