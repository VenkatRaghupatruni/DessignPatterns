using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Facade
{
    public class Product
    {
        private SqlConnection _connection;
        private string _itemNumber;

        public Product(string itemNumber, SqlConnection connection)
        {
            _connection = connection;
            _itemNumber = itemNumber;
        }

        public int PhysicalStock
        {
            get
            {
                // Retrieve stock level from database.
                return 25;
            }
        }

        public int StockOnOrder
        {
            get
            {
                // Retrieve incoming ordered stock from database.
                return 35;
            }
        }

        public int LowStockLevel
        {
            get
            {
                // Retrieve low stock level from database.
                return 30;
            }
        }

    }
}
