namespace C_class
{
    public class Student: BaseEntity
    {
        
        //This is polymorphism (Method overloading)
        public string MyName(string firstName, string lastName)
        {
            return $"My name is {firstName}, {lastName}";
        }

        public string MyName(string firstName, string lastName, string middlename)
        {
            return $"My name is {firstName} {middlename}, {lastName}";
        }

        public string MyName(string firstName, string lastName, string middlename, string title)
        {
            return $"My name is {title}, {firstName} {middlename}, {lastName}";
        }
        public override void SayMyName()
        {
            Console.WriteLine($"{FirstName} {MiddleName}, {LastName}");
        }
    }
}
