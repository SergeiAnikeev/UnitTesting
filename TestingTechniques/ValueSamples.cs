namespace TestingTechniques
{
    public class ValueSamples
    {
        public string FullName = "John Jones";
        public int Age = 25;
        public DateOnly DateOfBirth = new(2000, 1, 1);

        public User AppUser = new()
        {
            FullName = "John Jones",
            Age = 25,
            DateOfBirth = new(2000, 1, 1)
        };

        public IEnumerable<User> Users = new[]
        {
            new User()
            {
                FullName = "John Jones",
                Age = 25,
                DateOfBirth = new(2000, 1, 1)
            },
            new User()
            {
                FullName = "John Jones 2",
                Age = 26,
                DateOfBirth = new(2001, 1, 1)
            },
            new User()
            {
                FullName = "John Jones 3",
                Age = 35,
                DateOfBirth = new(2002, 1, 1)
            }
        };


        public IEnumerable<int> Numbers = new[] { 1, 2, 3, 4, 5, 6, };
        public event EventHandler ExampleEvent;
        internal int InternalSecretNumber = 42;
        public virtual void RaiseExampleEvent()
        {
            ExampleEvent(this, EventArgs.Empty);
        }

    };
}
