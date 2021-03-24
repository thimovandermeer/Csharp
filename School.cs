using System;
using System.Text;

namespace Test
{
	public class School
	{

		public string Name { get; set; }
		public string Address { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Zip { get; set; }
		public string PhoneNumber { get; set;}
		private string _twitterAddress;

		string TwitterAdress
        {
			// make sure the twitter address start with a @ symbol
			get { return _twitterAddress; }
			set
            {
				if (value.StartsWith("@"))
                {
					_twitterAddress = value;
                }
                else
                {
					throw new Exception("The twitter address sucks bro");
                }
            }
        }
        public School()
        {
			Name = "Untitled School";
			Address = "Untitled Address";
			PhoneNumber = "FAKE NEWS";
        }

        public School(string schoolName, string SchoolPhoneNumber)
        {
			Name = schoolName;
			PhoneNumber = SchoolPhoneNumber;
        }

        public static float AverageThreeScores(float a, float b, float c) => a + b + c / 3;

		public static int AverageThreeScores(int a, int b, int c)
        {
			var result = (a + b + c) / 3;
			return result;
        }
        public override string ToString()
        {
			var sb = new StringBuilder();
			sb.AppendLine(this.Name);
			sb.AppendLine(this.Address);
			sb.AppendLine(this.City);
			sb.AppendLine(this.State);
			sb.AppendLine(this.PhoneNumber);
			sb.Append(this.State);
            return sb.ToString();
        }
    }
}
