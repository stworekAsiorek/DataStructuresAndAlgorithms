namespace DataStructuresAndAlgorithms.Practice.CtCI.StacksAndQueues
{
    public class SetOfStacks<T>
    {
        private readonly int _singleStackCapacity;
        private List<StackWithCapacity<T>> _stacks = new List<StackWithCapacity<T>>();

        public SetOfStacks(int singleStackCapacity)
        {
            _singleStackCapacity = singleStackCapacity;
        }

        public void Push(T item)
        {
            if (!_stacks.Any())
            {
                _stacks.Add(new StackWithCapacity<T>(_singleStackCapacity));
            }

            if (!_stacks.Last().TryPush(item))
            {
                _stacks.Add(new StackWithCapacity<T>(_singleStackCapacity));
                _stacks.Last().Push(item);
            }

            return;
        }

        public T Pop()
        {
            if (!_stacks.Any())
            {
                throw new EmptySetOfStacksException();
            }

            var item = _stacks.Last().Pop();

            if (_stacks.Last().IsEmpty())
            {
                _stacks.Remove(_stacks.Last());
            }

            return item;
        }
    }

    public class EmptySetOfStacksException : Exception
    {
    }
}
