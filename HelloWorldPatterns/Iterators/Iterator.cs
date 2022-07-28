namespace HelloWorldPatterns.Iterators
{
    public abstract class Iterator<TInput, TOutput>: IIterator<TInput, TOutput>
    {
        public abstract void ProcessInput(TInput input, Action<TOutput> process);
    }
}
