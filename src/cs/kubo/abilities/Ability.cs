using Enums;

namespace Abilities {
    public class Ability {
        public string Name {get; set;}
        public string IconPath {get; private set;}
        public Types Type {get; private set;}
        public int BaseCD {get; set;}
        public int TotalCD {get; set;}

        public Ability(string name, string path, Types type, int cd) {
            Name = name;
            IconPath = path;
            Type = type;
            BaseCD = cd;
        }

        public float CalcCD(){
            float calc;

            calc = BaseCD;

            return calc;
        }
    }
}