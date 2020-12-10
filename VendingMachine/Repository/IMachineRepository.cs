using System.Collections.Generic;

namespace VendingMachine.Models
{
    public interface IMachineRepository
    {
        IEnumerable<DrinkType> GetDrinkTypes { get; }
        IEnumerable<Program> GetPrograms { get; }
    }
}
