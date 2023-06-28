using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace DataStructuresAndAlgorithms.Practice.PhoneBook
{
    public record PhoneEntry
    {
        public string FirstName { get; init; } 
        public string LastName { get; init; }
        public string PhoneNumber { get; init;}
        public override string ToString() {
            return $"First name: {FirstName}, last name: {LastName}, phone number: {PhoneNumber}\n"; 
        }
    }
}
