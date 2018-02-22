using System;
using System.Collections.Generic;
using System.Text;

namespace inventorySystemTesting
{
    public class ProductRepository
    {

        public List<Product> product = new List<Product>();
        public ProductRepository(List<Product> prod)
        {
            product = prod;
        }

        //method to count the length
        public int Calculate()
        {

            return product.Count;

        }
        // method to add new product in the list
        public List<Product> AddProduct()
        {
            
            product.Add(new Product("Potato", 10, 50, "root"));
            return product;

        }
        // method to find product by its type
        public List<Product> FindByType(string findtype)
        {

            List<Product> list = new List<Product>();
            foreach (Product item in product)
            {
                if (item.Type == findtype)
                {
                    list.Add(item);
                }
            }
            return list;
        }
        // method to delete product from the list
        public List<Product> DeleteProduct(List<Product> product_lst, string veg)
        {

            var deleteproduct = product_lst.Find(x=>x.Name == veg);

            product_lst.Remove(deleteproduct);
         return product_lst;

        }

        //method to find the total amount of buying selected products 
        public double TotalAmount()
        {
            double PriceSum = 0;

            foreach (Product item in product)
            {
                if (item.Name == "lettuce")
                {

                    PriceSum = PriceSum + (item.Price * 1);
                }
                if (item.Name == "zucchini")
                {
                    PriceSum = PriceSum + item.Price * 2;
                }
                if (item.Name == "broccoli")
                {
                    PriceSum = PriceSum + item.Price * 1;
                }

            }

            return PriceSum;
        }
    }

}



