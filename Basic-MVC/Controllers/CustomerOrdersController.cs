using Basic_MVC.Models;
using Basic_MVC.ViewModel;
using Microsoft.AspNetCore.Mvc;

public class CustomerOrdersController : Controller
{
    public ActionResult Index()
    {
        // Örnek müşteri oluşturma
        var customer = new Customer
        {
            Id = 1,
            FirstName = "Ahmet",
            LastName = "Yılmaz",
            Email = "ahmet.yilmaz@example.com"
        };

        // Örnek siparişler oluşturma
        var orders = new List<Order>
        {
            new Order { Id = 1, ProductName = "Laptop", Price = 1500.00m, Quantity = 1 },
            new Order { Id = 2, ProductName = "Telefon", Price = 500.00m, Quantity = 2 }
        };

        // ViewModel oluşturma
        var viewModel = new CustomerOrderViewModel
        {
            Customer = customer,
            Orders = orders
        };

        // ViewModel'i view'a iletme
        return View(viewModel);
    }
}
