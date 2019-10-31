using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class UtilityService
    {
        private readonly List<string> colors;
        private readonly Random random;

        public UtilityService()
        {
            colors = new List<string>
            {
                "red",
                "blue",
                "lime",
                "orange",
                "magenta"
            };

            random = new Random();
        }

        public string RandomColor()
        {
            return colors[random.Next(colors.Count)];
        }

        public List<string> ValidateEmail(string email)
        {
            List<string> result = new List<string>();
            if (email.Contains('.') && email.Contains('@'))
            {
                result.Add("is @this.valid is a valid email address");
                result.Add("green");
                return result;
            }
            result.Add("not_valid_email.com is not a valid email address");
            result.Add("red");
            return result;

        }
    }
}
