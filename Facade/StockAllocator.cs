using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Facade
{
    public static class StockAllocator
    {
        public static int GetAllocations(string itemNumber, SqlConnection connection)
        {
            // Retrieve allocated stock for product from database.
            return 10;
        }

    }
}
