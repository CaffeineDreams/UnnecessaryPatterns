namespace HelloWorldPatterns.Iterators
{
    public interface IIterator<TInput, out TOutput>
    {
        public void ProcessInput(TInput input, Action<TOutput> process);
    }
}
