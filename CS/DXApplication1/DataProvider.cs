using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DXApplication1 {
    public class DataProvider {
        public static BindingList<Category> GetCategoryList(int recordCount = 10) {
            BindingList<Category> list = new BindingList<Category>();
            for (int i = 0; i < recordCount; i++) {
                list.Add(new Category(i) { CategoryName = string.Format("Text {0}", i) });
            }
            return list;
        }
        public static BindingList<Product> GetProductList(int recordCount = 15) {
            BindingList<Product> list = new BindingList<Product>();
            for (int i = 0; i < recordCount; i++) {
                list.Add(new Product(i) { CategoryID = i % 5, Description = string.Format("Description {0}", i), ProductName = string.Format("Product {0}", i) });
            }
            return list;
        }
        public static BindingList<Order> GetOrderList(int recordCount = 25) {
            BindingList<Order> list = new BindingList<Order>();
            for (int i = 0; i < recordCount; i++) {
                list.Add(new Order(i) { ProductID = i % 15, OrderNumber = 1000 + i });
            }
            return list;
        }
    }
    public class Category {
        public Category(int id) {
            ID = id;
        }
        public int ID { get; private set; }
        public string CategoryName { get; set; }
    }
    public class Product {
        public Product(int id) {
            ID = id;
        }
        public int ID { get; private set; }
        public int CategoryID { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
    }
    public class Order {
        public Order(int id) {
            ID = id;
        }
        public int ID { get; private set; }
        public int ProductID { get; set; }
        public int OrderNumber { get; set; }
    }
}
