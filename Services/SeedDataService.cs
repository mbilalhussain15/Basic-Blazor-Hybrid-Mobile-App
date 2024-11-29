using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleProject1.Data;

namespace SampleProject1.Services
{
    public class SeedDataService
    {
        private readonly DatabaseContext _context;
        public SeedDataService(DatabaseContext context) 
        {
            _context = context;
        }
        public async Task SeedDataAsync() {

            var deviceCategory = await _context.FindAsync<ExpenseCategory>("Device-1");
            if (deviceCategory is not null)
            {
                return;
            }
            var expenseCategories = new List<ExpenseCategory>
            {
                new("Device-1"),
                new("Device-2"),
                new("Device-3")
              
            };
            var locationCategories = new List<locationCategory>
            {
                new locationCategory("Device1","/images/device.png"),
                new locationCategory("Device2","/images/device.png"),
                new locationCategory("Device3","/images/device.png")
            };

            foreach (var location in locationCategories) 
            {
                await _context.AddItemAsync<locationCategory>(location);

            }

            foreach (var expenseCategory in expenseCategories)
            {
                await _context.AddItemAsync<ExpenseCategory>(expenseCategory);

            }
        }
    }
}
