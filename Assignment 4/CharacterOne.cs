using System;
namespace Assignment4
{
    class CharacterOne : Character
    {
        public CharacterOne() : base("I am a famous detective and my name rhymes with Jeroi Rolmes.", "Sherlock Holmes") { }

        public override string greeting()
        {
            return "Hello, I am " + getCharacterName();
        }

        public override string getInformation()
        {
            return "I have a brilliant mind and have solved many complex cases.";
        }

        public override string sayGoodbye()
        {
            return "Goodbye, I must go solve another case now.";
        }
    }
}

