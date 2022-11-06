namespace UserRegistrationRegex
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter First Name");
            string firstName = Console.ReadLine();
            ValidFirstName a = new ValidFirstName();
            bool val = a.FirstName(firstName);

            if (val)
            {
                Console.WriteLine("Valid FirstName");
            }
            else
            {
                Console.WriteLine("Invalid FirstName");
            }          
        }
    }
}
