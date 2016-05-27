using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Facade
{
    public class StockFacade
    {
        public bool IsLowStock(string itemNumber)
        {
            SqlConnection conn = GetConnection();

            Product product = new Product(itemNumber, conn);

            int physical = product.PhysicalStock;
            int onOrder = product.StockOnOrder;
            int lowStock = product.LowStockLevel;
            int allocations = StockAllocator.GetAllocations(itemNumber, conn);

            int available = physical + onOrder - allocations;
            return (available <= lowStock);
        }

        private SqlConnection GetConnection()
        {
             return new SqlConnection();
        }

    }
}
