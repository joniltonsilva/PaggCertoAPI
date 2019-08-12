using System;
using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class JsonCurrency : RangeAttribute
    {
        private const decimal Minimum = 0;
        private const decimal Maximum = 999999.99M;

        public JsonCurrency() : base(Convert.ToDouble(Minimum), Convert.ToDouble(Maximum))
        {
            ErrorMessage = $"{0}: Between {Minimum} and {Maximum}.";
        }
    }
}
