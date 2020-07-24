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
      Vendor newVendor = new Vendor("test vendor");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Test Category";
      Vendor newVendor = new Vendor(name);

      string result = newVendor.Name;

      Assert.AreEqual(name, result);
    }
    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "Susie's Cafe";
      Vendor newVendor = new Vendor(name);

      int result = newVendor.Id;

      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string name01 = "Susie's Cafe";
      string name02 = "Joe's Cafe";
      Vendor newVendor1 = new Vendor(name01);
      Vendor newVendor2 = new Vendor(name02);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      List<Vendor> result = Vendor.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void FindVendor_ReturnsCorrectVendor_Vendor()
    {
      string name01 = "Susie's Cafe";
      string name02 = "Joe's Cafe";
      Vendor newVendor1 = new Vendor(name01);
      Vendor newVendor2 = new Vendor(name02);
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
      string name = "Susie's Cafe";
      Vendor newVendor = new Vendor(name);
      newVendor.AddOrder(newOrder);

      List<Order> result = newVendor.Orders;

      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void RemoveVendor_RemovesInstanceOfVendor_Int()
    {
      string name = "Susie's Cafe";
      Vendor newVendor = new Vendor(name);
      List<Vendor> allVendors = Vendor.GetAll();
      
      Vendor.RemoveVendor(newVendor);

      Assert.AreEqual(0, allVendors.Count);
    }
  }
}