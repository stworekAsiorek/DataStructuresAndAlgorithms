namespace DataStructuresAndAlgorithms.Practice.CtCI.TreesAndGraphs
{
    public class NodeWithDependencies
    {
        public string Name { get; set; }
        public IList<NodeWithDependencies> Adjacent { get; set; } = new List<NodeWithDependencies>();
        public int DependenciesNumber { get; set; } = 0;
        public int MarksNumber { get; set; } = 0;
        public bool Marked { get { return DependenciesNumber == MarksNumber ? true : false; } }
    }
}
