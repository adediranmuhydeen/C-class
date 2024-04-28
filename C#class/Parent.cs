namespace C_class
{
    public class Parent : BaseEntity
    {
        
        public string Address { get; set; }        
        
        public override void SayMyName()
        {
            Console.WriteLine($"{FirstName}, {LastName}");
        }


    }
}

