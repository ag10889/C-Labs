using System;
namespace Assignment4
{
    class CharacterThree : Character
    {
        public CharacterThree() : base("I am a pirate and my name rhymes with Jack Spaniel.", "Jack Sparrow") { }

        public override string greeting()
        {
            return "Ahoy matey, I am " + getCharacterName();
        }

        public override string getInformation()
        {
            return "I am the captain of the Black Pearl and have searched for treasure all over the world.";
        }

        public override string sayGoodbye()
        {
            return "Farewell, until we meet again.";
        }
    }
}

