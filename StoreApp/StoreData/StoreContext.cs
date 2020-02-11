using Microsoft.EntityFrameworkCore;
using StoreModel;
using System;

namespace StoreData
{
    public class StoreContext :DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }
    }
}
