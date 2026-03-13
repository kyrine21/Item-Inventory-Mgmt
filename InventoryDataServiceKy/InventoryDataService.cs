using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryModel;

namespace InventoryDataServiceKy
{
    public class InventoryDataService
    {
        List<InventoryModel> itemsOnStock = new List<InventoryModel>();

        public InventoryDataService() { 
            InventoryModel item1 = new InventoryModel() { Name = "Mouthwash", Quantity = 10 };
            InventoryModel item2 = new InventoryModel() { Name = "Cotton Buds", Quantity = 20 };
            InventoryModel item3 = new InventoryModel() { Name = "Teeth Floss", Quantity = 5 };

           
        }
    }
}
