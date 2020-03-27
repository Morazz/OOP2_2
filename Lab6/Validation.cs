using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using System.ComponentModel;
using System.IO;

namespace Lab5
{
    public class UserAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value != null)
            {
                string name = value.ToString();
                if (!name.StartsWith("1"))
                {
                    return true;
                }
                else
                    this.ErrorMessage = "Name can't start with 1";
            }
            return false;
        }
    }
}


