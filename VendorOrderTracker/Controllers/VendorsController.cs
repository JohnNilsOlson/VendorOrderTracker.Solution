using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }
    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }
    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string vendorStreetAddress, string vendorCity)
    {
      Vendor newVendor = new Vendor(vendorName, vendorStreetAddress, vendorCity);
      return RedirectToAction("Index");
    }
    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor foundVendor = Vendor.FindVendor(id);
      List<Order> orders = foundVendor.Orders;
      model.Add("vendor", foundVendor);
      model.Add("orders", orders);
      return View(model);
    }
    [HttpPost("/vendors/{vendorId}")]
    public ActionResult Create(int vendorId, string orderDescription)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor foundVendor = Vendor.FindVendor(vendorId);
      Order newOrder = new Order(orderDescription);
      foundVendor.AddOrder(newOrder);
      List<Order> vendorOrders = foundVendor.Orders;
      model.Add("vendor", foundVendor);
      model.Add("orders", vendorOrders);
      return View("Show", model);
    }
    [HttpPost("/vendors/{vendorId}/delete")]
    public ActionResult Delete(int vendorId)
    {
      Vendor.RemoveVendor(vendorId);
      return View();
    }
  }
}