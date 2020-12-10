
namespace VendingMachine.Models
{
    public struct Operation
    {
        public Operation(int operationId, string name, int executionTimeMs )
        {
            OperationId = operationId;
            Name = name;
            ExecutionTimeMs = executionTimeMs;
        }

        public int OperationId { get;  }

        public string Name { get;  }

        public int ExecutionTimeMs { get; set; }
    }
}
