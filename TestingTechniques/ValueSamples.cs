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

    };
}
