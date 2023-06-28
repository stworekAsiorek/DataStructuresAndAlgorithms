using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Practice.PhoneBook
{
    public interface IPhoneEntryValidator
    {
        bool Validate(PhoneEntry phoneEntry);
    }

    public class PhoneEntryValidator: IPhoneEntryValidator
    {
        private readonly Regex nameRegex = new(@"^[A-Za-z]+$");
        private readonly Regex numberRegex = new(@"^[0-9]+$");

        public bool Validate(PhoneEntry phoneEntry)
        {
            if (string.IsNullOrEmpty(phoneEntry.FirstName) || !nameRegex.IsMatch(phoneEntry.FirstName))
            {
                return false;
            }
            if (string.IsNullOrEmpty(phoneEntry.LastName) || !nameRegex.IsMatch(phoneEntry.LastName))
            {
                return false;
            }
            if (string.IsNullOrEmpty(phoneEntry.PhoneNumber) || !numberRegex.IsMatch(phoneEntry.PhoneNumber))
            {
                return false;
            }
            return true;
        }
    }
}
