using System.Collections.Generic;


namespace VendingMachine.Models
{    
    public class MockMachineRepository : IMachineRepository
    {        
        public IEnumerable<DrinkType> GetDrinkTypes =>
            new List<DrinkType>
            {
                new DrinkType {
                    DrinkId = 1,
                    Name = "Lemon Tea"                
                },
                new DrinkType {
                    DrinkId = 2,
                    Name = "Coffe"                    
                },
                new DrinkType {
                    DrinkId = 3,
                    Name = "Chocolate"                    
                }
            };

        public IEnumerable<Program> GetPrograms =>
            new List<Program>
            {
                new Program {
                    DrinkId = 1,
                    Actions = new List<Operation>
                    {
                        new Operation( 1, "Boil some water", 4000 ),
                        new Operation( 2, "Steep the water in the tea", 2000),
                        new Operation( 5, "Pour in the cup", 3000),
                        new Operation( 6, "Add lemon", 1000),
                    }
                },
                new Program {
                    DrinkId = 2,                    
                    Actions = new List<Operation>
                    {
                        new Operation( 1, "Boil some water", 4000),
                        new Operation( 3, "Brew the coffee grounds", 4000),
                        new Operation( 5, "Pour in the cup", 3000),
                        new Operation( 7, "Add sugar and milk", 2000),
                    }
                },
                new Program {
                    DrinkId = 3,
                    Actions = new List<Operation>
                    {
                        new Operation( 1, "Boil some water", 4000),
                        new Operation( 2, "Add drinking chocolate powder to the water", 2000),
                        new Operation( 5, "Pour in the cup", 3000),
                    }
                }
            }; 
    }
}
