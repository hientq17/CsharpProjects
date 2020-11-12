using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04 {
    class Categories {
        private int categoryId;
        private string categoryName;
        private string description;

        public Categories(int categoryId, string categoryName, string description) {
            this.categoryId = categoryId;
            this.categoryName = categoryName;
            this.description = description;
        }

        public int CategoryId { get => categoryId; set => categoryId = value; }
        public string CategoryName { get => categoryName; set => categoryName = value; }
        public string Description { get => description; set => description = value; }
    }
}
