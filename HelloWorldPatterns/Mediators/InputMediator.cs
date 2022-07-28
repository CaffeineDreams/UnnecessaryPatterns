using HelloWorldPatterns.DataTypes;

namespace HelloWorldPatterns.Mediators
{
    public class InputMediator
    {
        private IList<ICharacter> characters = new List<ICharacter>();

        public void AddCharacter(char character)
        {
            var c = new Character();
            c.Set(character);
            characters.Add(c);
        }

        public void Clear()
        {
            characters.Clear();
        }

        public override string ToString()
        {
            return new String(
                characters
                    .Select((c) => c.Read())
                    .ToArray());
        }
    }
}
