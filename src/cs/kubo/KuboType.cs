namespace Enums {
    public readonly struct KuboType {
        public Types Primary { get; }
        public Types? Secondary { get; }

        public KuboType(Types primary) {
            Primary = primary;
            Secondary = null;
        }

        public KuboType(Types primary, Types secondary) {
            Primary = primary;
            
            if (secondary == Types.PLAIN || primary == secondary) {
                Secondary = null;
            } else {
                Secondary = secondary;
            }
        }

        public bool HasType(Types type) => Primary == type || Secondary == type;

        public bool IsDualType => Secondary.HasValue;

        public override string ToString() => 
            IsDualType ? $"{Primary} / {Secondary}" : $"{Primary}";
    }
}