using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingTechniques
{
    public class Greeter
    {
        private readonly IDateTimeProvider _dateTimeProvider;
        public Greeter(IDateTimeProvider dateTimeProvider)
        {
            _dateTimeProvider = dateTimeProvider;
        }
        public string GenerateGreetMessage()
        {
            var dateTimeNow = _dateTimeProvider.DateTimeNow;
            return dateTimeNow.Hour switch
            {
                >= 5 and < 12 => "Good morning",
                >= 12 and < 18 => "Good afternoon",
                _ => "Good evening"
            };
        }
    }
}
