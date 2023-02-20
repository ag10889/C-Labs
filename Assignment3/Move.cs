using System;
namespace Assignment3
{
	public class Move : Customer
	{
		private string name;
		private string state;
		public Move(string name, string state) : base('C')
		{
			this.name = name;
			this.state = state;
		}
        public override string getCustomerInfo()
        {
			return "Moved from " + state + ". " + "Ticket Number " + getTicketNumber() + ". Name: " + name;
        }
    }
}

