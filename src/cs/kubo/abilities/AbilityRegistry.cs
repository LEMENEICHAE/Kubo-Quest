using Abilities;
using Enums;

namespace AbilitiesRegistry {
    public class AbilityRegistry {

        //PLAIN MOVES
        public const Ability TACKLE = new Ability("Tackle",
        "src/assets/icons/abilities/tackle.png",Types.PLAIN, 5); //SLIDES FORWARD AND HITS
        public const Ability LAUNCH = new Ability("Launch",
        "src/assets/icons/abilities/launch.png", Types.PLAIN, 8); //hits opp and launches them far
        public const Ability MEGA_PUNCH = new Ability("Mega-Punch",
        "src/assets/icons/abilities/mega_punch.png", Types.PLAIN, 8); //hits opp with a hard punch

        //AQUA MOVES
        public const Ability WHIRLPOOL = new Ability("Whirlpool",
        "src/assets/icons/abilities/4proj.png", Types.AQUA, 6);
        //sucks opponents towards itself, and then launches them out with a lot of dmg
        public const Ability TSUNAMI = new Ability("Tsunami",
        "src/assets/icons/abilities/tsunami.png", Types.AQUA, 8);
        //creates a huge wave that pushes opps away
        public const Ability WATER_BOMB = new Ability("Water Bomb",
        "src/assets/icons/abilities/bomb.png", Types.AQUA, 6);
        //drops a bomb of water that explodes onto an opp
        public const Ability AQUA_DEFENSE = new Ability("Aqua Defense",
        "src/assets/icons/abilities/speed_defense_gain.png", Types.AQUA, 5);

        //SPARK MOVES

        //GHOUL MOVES
        public const Ability SPOOK = new Ability("Spook",
        "src/assets/icons/abilities/spook.png", Types.GHOUL, 5); //appears behind opp and
        //damages them which also has a 25% chance of paralyzing them
        public const Ability PHASE = new Ability("Phase",
        "src/assets/icons/abilities/phase.png", Types.GHOUL, 8)
        //kubo goes half transparent and gains the ghost status effect
        //which makes it phase through other kubos and walls but makes it take more damage

        //GRASS MOVES

        //FIGHTING MOVES
        public Ability ANKLE_BREAKER = new Ability("Ankle Breaker",
        "src/assets/icons/abilities/ankle_breaker.png",
         Types.FIGHTING, 8) //gains speed, lowers opp speed and slides past them, hitting them

    }
}