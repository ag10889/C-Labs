using System;
namespace Assignment3
{
	public class Renew : Customer
	{
		private string name;
		public Renew(string name) : base('B')
		{
			this.name = name;
		}
        public override string getCustomerInfo()
        {
			return "Renewal license. Ticket number " + getCustomerInfo() + " " + "Name: " +  name;
        }
     }
}

