using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04 {
    class Products {
        private int productId;
        private string productName;
        private int supplierId;
        private int categoryId;
        private string quantityPerUnit;
        private double unitPrice;
        private int unitsInStock;
        private bool discontinued;

        public Products(int productId, string productName, int supplierId, int categoryId, string quantityPerUnit, 
            double unitPrice, int unitsInStock, bool discontinued) {
            this.productId = productId;
            this.productName = productName;
            this.supplierId = supplierId;
            this.categoryId = categoryId;
            this.quantityPerUnit = quantityPerUnit;
            this.unitPrice = unitPrice;
            this.unitsInStock = unitsInStock;
            this.discontinued = discontinued;
        }

        public int ProductId { get => productId; set => productId = value; }
        public string ProductName { get => productName; set => productName = value; }
        public int SupplierId { get => supplierId; set => supplierId = value; }
        public int CategoryId { get => categoryId; set => categoryId = value; }
        public string QuantityPerUnit { get => quantityPerUnit; set => quantityPerUnit = value; }
        public double UnitPrice { get => unitPrice; set => unitPrice = value; }
        public int UnitsInStock { get => unitsInStock; set => unitsInStock = value; }
        public bool Discontinued { get => discontinued; set => discontinued = value; }
    }
}
