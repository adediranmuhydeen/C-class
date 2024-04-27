namespace C_class
{
    public class Teacher : BaseEntity
    {        
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        //this is polymorphism(Method overriding)
        public override void SayMyName()
        {
            Console.WriteLine($"{FirstName}, {LastName}");
        }
    }
}
