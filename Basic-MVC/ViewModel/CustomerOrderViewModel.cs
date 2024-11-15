namespace Basic_MVC.ViewModel
{
    using Basic_MVC.Models;
    using System.Collections.Generic;

    public class CustomerOrderViewModel
    {
        public Customer Customer { get; set; }
        public List<Order> Orders { get; set; }
    }

}
