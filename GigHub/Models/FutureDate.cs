using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace GigHub.Models
{
    public class FutureDate:ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime dateTime;
            var idValid = DateTime.TryParseExact(Convert.ToString(value), 
                "d MMM yyyy", 
                CultureInfo.CurrentCulture, 
                DateTimeStyles.None, 
                out dateTime);
            return (idValid && dateTime > DateTime.Now);
        }
    }
}