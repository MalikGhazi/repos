using System;
using System.Collections.Generic;
using System.Text;

namespace StoreModel
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public string ImagePath { get; set; }
    }
}
