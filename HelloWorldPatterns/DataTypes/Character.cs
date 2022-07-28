namespace HelloWorldPatterns.DataTypes
{
    public class Character : ICharacter
    {
        private char character;

        public void Set(char c)
        {
            character = c;
        }

        public char Read()
        {
            return character;
        }
    }
}
