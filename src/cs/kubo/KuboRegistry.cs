using Kubos;
using Enums;

namespace KubosRegistry {
    public class KuboRegistry {
        public static readonly Kubo BUSHTLE = new Kubo("Bushtle", new KuboType(Types.GRASS),
        "src/assets/models/kubos/bushtle.blend", 1);
        public static readonly Kubo BUPLANT = new Kubo("Buplant", new KuboType(Types.GRASS),
        "src/assets/models/kubos/buplant.blend", 2);
        public static readonly Kubo BUBATREE = new Kubo("Bubatree", new KuboType(Types.GRASS),
        "src/assets/models/kubos/bubatree.blend", 3);
        public static readonly Kubo COALIE = new Kubo("Coalie", new KuboType(Types.PYRO),
        "src/assets/models/kubos/coalie.blend", 4);
        public static readonly Kubo COARAM = new Kubo("Coaram", new KuboType(Types.PYRO),
        "src/assets/models/kubos/coaram.blend", 5);
        public static readonly Kubo COAJITSU = new Kubo("Coajitsu", new KuboType(Types.PYRO,
        Types.FIGHTING),"src/assets/models/kubos/coajitsu.blend", 6);
    }
}