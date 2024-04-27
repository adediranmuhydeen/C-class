namespace C_class
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Title { get; set; }

        /// <summary>
        /// print name of entity
        /// </summary>
        public abstract void SayMyName();
    }
}
