namespace HelloWorldPatterns.Iterators
{
    public class StringIterator : Iterator<string, char>
    {
        public override void ProcessInput(string input, Action<char> process)
        {
            foreach (char c in input)
            {
                process(c);
            }
        }
    }
}
