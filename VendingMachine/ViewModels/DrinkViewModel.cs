using System.Collections.Generic;
using VendingMachine.Models;

namespace VendingMachine.ViewModels
{
    public class DrinkViewModel 
    {
        public DrinkViewModel(IEnumerable<DrinkType> drinks)
        {
            Drinks = drinks;
        }

        public IEnumerable<DrinkType> Drinks { get; set; }
        
    }

    
}
