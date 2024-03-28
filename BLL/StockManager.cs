using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace BLL
{
    public class StockManager
    {
        // ATTRIBUTES

        private Database _database = new Database();

        // METHODS

        public void generateTable()
        {
            string tableName = "Stock" + Helper.getLastId("Warehouses").ToString();
            string tableDefinition = "ProductId int primary key not null, Stock int check(0 <= Stock) not null default(0)";
            _database.createTable(tableName, tableDefinition);
        }
    }
}
