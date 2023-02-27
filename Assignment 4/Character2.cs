using System;
namespace Assignment4
{
    class CharacterTwo : Character
    {
        public CharacterTwo() : base("I am a powerful Jedi and my name rhymes with Muke Kywalker.", "Luke Skywalker") { }

        public override string greeting()
        {
            return "May the force be with you, I am " + getCharacterName();
        }

        public override string getInformation()
        {
            return "I am a skilled warrior and have fought against the evil empire.";
        }

        public override string sayGoodbye()
        {
            return "May the force be with you always.";
        }
    }

}

