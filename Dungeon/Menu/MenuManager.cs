using Dungeon.Enum;

namespace Dungeon.Menu
{
    internal class MenuManager
    {
        private string _characterName;
        public bool start = false;


        public void Manager(char key)
        {
            switch (key)
            {
                case ('1'):
                    start = true;
                    break;
                case ('2'):
                    SelectCharacterName();
                    break;
            }
        }

        public void SelectCharacterName()
        {
            var characterIsSelected = false;

            while (!characterIsSelected)
            {
                Display.ClearConsole();
                Display.DisplayRow(Ascii.selectCharacterText);
                var key = Console.ReadKey().KeyChar;
                SetUpCharacterName(key);

                if (_characterName is not null)
                {
                    characterIsSelected = true;
                    Console.WriteLine(_characterName);
                }
            }
        }

        public void SetUpCharacterName(char key)
        {
            switch (key)
            {
                case ('1'):
                    _characterName = "Alice";
                    break;
                case ('2'):
                    _characterName = "Jacek";
                    break;
                case ('3'):
                    _characterName = "Adam";
                    break;
            }
        }

        public Character CreateCharacter()
        {
            switch (_characterName) 
            {
                case ("Alice"):
                    return new Alice();
                case ("Jacek"):
                    return new Alice();
                case ("Adam"):
                    return new Alice();
            }
            return null;
        }
    }
}
