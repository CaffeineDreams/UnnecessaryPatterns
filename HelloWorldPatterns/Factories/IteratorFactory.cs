namespace HelloWorldPatterns.Factories
{
    public static class IteratorFactory
    {
        private static Iterators.IIterator<TIn, TOut> CreateIterator<TIn, TOut>(Type inputType, Type outputType)
        {
            switch ((inputType, outputType))
            {
                case (Type, Type) _ when inputType == typeof(string) && outputType == typeof(char):
                    return new Iterators.StringIterator() as Iterators.IIterator<TIn, TOut>;
                default:
                    throw new ApplicationException($"No known iterator for provided types [{inputType.FullName}, {outputType.FullName}]");
            }
        }

        public static Iterators.IIterator<TIn, TOut> CreateIterator<TIn,TOut>()
            where TIn : IComparable
            where TOut : IComparable
        {
            return (Iterators.IIterator<TIn, TOut>)CreateIterator<TIn, TOut>(typeof(TIn), typeof(TOut));
        }
    }
}
