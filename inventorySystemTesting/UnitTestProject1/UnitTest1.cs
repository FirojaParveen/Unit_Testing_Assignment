using System;
using System.Collections.Generic;
using inventorySystemTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        public List<Product> listmethod()
        {
            List<Product> prod = new List<Product>();
            prod.Add(new Product("lettuce", 10, 50, "leafygreen"));
            prod.Add(new Product("cabbage", 20, 100, "Cruciferous"));
            prod.Add(new Product("pumpkin", 30, 30, "Marrow"));
            prod.Add(new Product("cauliflower", 10, 25, "Cruciferous"));
            prod.Add(new Product("zucchini", 20.5, 50, "Marrow"));
            prod.Add(new Product("yam", 30, 50, "Root"));
            prod.Add(new Product("spinach", 10, 100, "Leafy green"));
            prod.Add(new Product("broccoli", 20.2, 75, "Cruciferous"));
            prod.Add(new Product("garlic", 30, 20, "Leafy green"));
            prod.Add(new Product("silverbeet", 10, 50, "Marrow"));
            return prod;
        }
        [TestMethod]

        public void TestMethod1()
        {
            var prod = listmethod();
            var pr = new ProductRepository(prod);
            int count = pr.Calculate();
            Assert.AreEqual(10, count);
        }
        [TestMethod]
        public void TestMethod2()
        {
            var prod = listmethod();
            var pr = new ProductRepository(prod);
            pr.AddProduct();
            int count1 = pr.Calculate();
            Assert.AreEqual(11, count1);
        }
        [TestMethod]
        public void TestMethod3()
        {
            var prod = listmethod();
            var pr = new ProductRepository(prod);
            pr.product = pr.DeleteProduct(pr.product, "zucchini");
            pr.product= pr.DeleteProduct(pr.product, "broccoli");
            int count2 = pr.Calculate();
            Assert.AreEqual(8, count2);
        }
        [TestMethod]
        public void TestMethod4()
        {
            var prod = listmethod();
            var pr = new ProductRepository(prod);
            pr.AddProduct();
            int count1 = pr.Calculate();
            Assert.AreEqual(11, count1);
        }
        [TestMethod]
        public void TestMethod5()
        {
            var prod = listmethod();
            var pr = new ProductRepository(prod);
            pr.AddProduct();
            int myIndex = 0;
            foreach (Product item in pr.product)
            {
                if (item.Name == "Potato")
                {
                    myIndex = pr.product.IndexOf(item);

                }
            }
            Assert.AreEqual(pr.Calculate()-1, myIndex);
        }
        [TestMethod]
        public void TestMethod6()
        {
            var prod = listmethod();
            var pr = new ProductRepository(prod);
            var lst=pr.FindByType("Cruciferous");
            Assert.AreEqual(3, lst.Count);
        }
        [TestMethod]
        public void TestMethod7()
        {
            var prod = listmethod();
            var pr = new ProductRepository(prod);
            var lst = pr.FindByType("Marrow");
            foreach (Product item in lst)
            {
                Assert.AreEqual("Marrow", item.Type);
            }
        }
         [TestMethod]
         public void TestMethod8()
         {
            
            var prod = listmethod();
            var pr = new ProductRepository(prod);
            pr.product = pr.DeleteProduct(pr.product, "cabbage");
           
            int count3 = pr.Calculate();
            Assert.AreEqual(9, count3);
        }
         [TestMethod]
        public void TestMethod9()
        {
            var prod = listmethod();
            var pr = new ProductRepository(prod);
            pr.product = pr.DeleteProduct(pr.product, "cabbage");
            var count4 = 0;
            foreach(Product item in pr.product)
            {
                if(item.Type == "cabbage")
                {
                    count4 = count4 + 1;
                }
            }
            Assert.AreEqual(0, count4);
        }
        [TestMethod]
        public void TestMethod10()
        {
            var prod = listmethod();
            var pr = new ProductRepository(prod);
            double total = pr.TotalAmount();
            Assert.AreEqual(71.2, total);
        }
    }
}
