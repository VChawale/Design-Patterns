using Design_Patterns.Command.FX;
namespace Design_Patterns.Command
{
    public class AddCustomerCommand : ICommand
    {
        private CustomerService customerService = new CustomerService();

        public AddCustomerCommand(CustomerService customerService)
        {
            this.customerService = customerService;
        }

        public void Execute()
        {
            customerService.AddCustomer();
        }
    }
}