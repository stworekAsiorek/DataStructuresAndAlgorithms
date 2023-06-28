namespace DataStructuresAndAlgorithms.Practice.PhoneBook
{
    public class PhoneBook
    {
        private readonly IPhoneEntryValidator phoneEntryValidator;
        private readonly Node phoneEntry = new();
        public PhoneBook(IPhoneEntryValidator _phoneEntryValidator)
        {
            phoneEntryValidator = _phoneEntryValidator;
        }

        public void AddPhoneEntry(PhoneEntry newPhoneEntry)
        {
            if(!phoneEntryValidator.Validate(newPhoneEntry))
            {
                return;
            }
            var pointer = phoneEntry;
            var lastName = newPhoneEntry.LastName.ToLower();
            foreach (var _char in lastName)
            {
                if (!pointer.nodes.ContainsKey(_char))
                {
                    pointer.nodes.Add(_char, new Node());
                }
                pointer = pointer.nodes[_char];
            }
            if (!pointer.phoneEntries.Contains(newPhoneEntry))
            {
                pointer.phoneEntries.Add(newPhoneEntry);
            }
        }

        public List<PhoneEntry> FindPeopleWithPrefix(string prefix)
        {
            prefix = prefix.ToLower();
            var pointer = phoneEntry;
            foreach (var _char in prefix)
            {
                if (!pointer.nodes.ContainsKey(_char))
                {
                    return new List<PhoneEntry>();
                }
                pointer = pointer.nodes[_char];
            }
            var result = new List<PhoneEntry>();
            result = AppendDescendantPhoneEntries(pointer, result);
            return result;
        }

        private List<PhoneEntry> AppendDescendantPhoneEntries(Node pointer, List<PhoneEntry> result)
        {
            result.AddRange(pointer.phoneEntries);
            foreach (var phoneEntry in pointer.nodes.Values)
            {
                AppendDescendantPhoneEntries(phoneEntry, result);
            }
            return result;
        }

        private class Node
        {
            public readonly Dictionary<char, Node> nodes = new();
            public readonly HashSet<PhoneEntry> phoneEntries = new();
        }
    }
}
