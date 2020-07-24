using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class CategoryTest : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Category()
    {
      string name = "test vendor";
      string address = "123 fake street";
      string city = "test city";
      Vendor newVendor = new Vendor(name, address, city);
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "test vendor";
      string address = "123 fake street";
      string city = "test city";
      Vendor newVendor = new Vendor(name, address, city);

      string result = newVendor.Name;

      Assert.AreEqual(name, result);
    }
    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "test vendor";
      string address = "123 fake street";
      string city = "test city";
      Vendor newVendor = new Vendor(name, address, city);

      int result = newVendor.Id;

      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string name1 = "test vendor 1";
      string address1 = "123 fake street";
      string city1 = "test city 1";
      string name2 = "test vendor";
      string address2 = "321 fake street";
      string city2 = "test city 2";
      Vendor newVendor1 = new Vendor(name1, address1, city1);
      Vendor newVendor2 = new Vendor(name2, address2, city2);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      List<Vendor> result = Vendor.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void FindVendor_ReturnsCorrectVendor_Vendor()
    {
      string name1 = "test vendor 1";
      string address1 = "123 fake street";
      string city1 = "test city 1";
      string name2 = "test vendor";
      string address2 = "321 fake street";
      string city2 = "test city 2";
      Vendor newVendor1 = new Vendor(name1, address1, city1);
      Vendor newVendor2 = new Vendor(name2, address2, city2);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      Vendor foundVendor = Vendor.FindVendor(1);

      Assert.AreEqual(newVendor1, foundVendor);
    }
    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      string description = "test order";
      Order newOrder = new Order(description);
      List<Order> newList = new List<Order> { newOrder };
      string name = "test vendor";
      string address = "123 fake street";
      string city = "test city";
      Vendor newVendor = new Vendor(name, address, city);
      newVendor.AddOrder(newOrder);

      List<Order> result = newVendor.Orders;

      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void RemoveVendor_RemovesInstanceOfVendor_Int()
    {
      string name = "test vendor";
      string address = "123 fake street";
      string city = "test city";
      Vendor newVendor = new Vendor(name, address, city);
      List<Vendor> allVendors = Vendor.GetAll();
      
      Vendor.RemoveVendor(1);

      Assert.AreEqual(0, allVendors.Count);
    }
  }
}