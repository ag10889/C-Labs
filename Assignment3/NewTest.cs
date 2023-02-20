using System;
namespace Assignment3
{
	public class NewTest : Customer
	{
		private string cusName;
		private string DOB;
		public NewTest(string name, string birth) : base('A')
		{
			cusName = name;
			DOB = birth;
		}
        public override string getCustomerInfo()
        {
			return "New Drivers' license. Ticket Number " + getTicketNumber() + "Name: " + cusName + " " + "DOB " + DOB;
        }
    }
}

