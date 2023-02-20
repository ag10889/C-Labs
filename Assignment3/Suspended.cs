using System;
namespace Assignment3
{
	public class Suspended : Customer
	{
		private string name;
		private string violation;
		public Suspended(string name, string violation) : base('D')
		{
			this.name = name;
			this.violation = violation;
		}
        public override string getCustomerInfo()
        {
			return "Violation " + violation + ". Ticket Number: " + getTicketNumber() + ". Name: " + name;
        }
    }
}

