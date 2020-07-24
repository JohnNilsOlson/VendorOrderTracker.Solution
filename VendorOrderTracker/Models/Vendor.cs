using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> {};
    public string Name { get; set; }
    public string StreetAddress { get; set; }
    public string City { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; }
    public Vendor(string vendorName, string vendorStreetAddress, string vendorCity)
    {
      Name = vendorName;
      StreetAddress = vendorStreetAddress;
      City = vendorCity;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<Order>{};
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static List<Vendor> GetAll()
    {
      return _instances;
    }
    public static Vendor FindVendor(int searchId)
    {
      return _instances[searchId - 1];
    }
    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }
    public static void RemoveVendor(int searchId)
    {
      Vendor foundVendor = Vendor.FindVendor(searchId);
      _instances.Remove(foundVendor);
    }
  }
}