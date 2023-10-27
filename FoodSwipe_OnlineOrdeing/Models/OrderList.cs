using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;


namespace FoodOrderingSystem.Models
{
    public partial class OrderList
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public int Quantity { get; set; }
        public string TotalPrice { get; set; }

        public string Email { get; set; }

       
    }
}
