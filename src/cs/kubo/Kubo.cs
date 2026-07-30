using Enums;
using Abilities;
namespace Kubos {
    public class Kubo {
        public string Name {get; set;}
        public KuboType Type {get; set;}
        public string ModelLink {get; private set;}
        public int dexIndex {get; private set;}
        public int BaseATK {get; set;}
        public int BaseHP {get; set;}

        public Ability Ability1 {get; set;}
        public Ability Ability2 {get; set;}

        public Kubo(string name, KuboType type, string modelLink, int index) {
            Name = name;
            Type = type;
            ModelLink = modelLink;
            dexIndex = index;
        }

        public Kubo Clone() {
            return new Kubo(Name, Type, ModelLink, DexIndex, BaseATK, BaseHP) {
                Ability1 = this.Ability1,
                Ability2 = this.Ability2
            };
        }
    }
}
