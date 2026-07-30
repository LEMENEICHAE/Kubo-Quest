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
        public const Ability LIGHTNING = new Ability("Lightning",
        "src/assets/icons/abilities/lightning.png", Types.SPARK, 6);
        //shoots a lightning strike down at the opponent
        public const Ability CHARGED_FIELD = new Ability("Charged Field",
        "src/assets/icons/abilities/attack_defense_gain.png", Types.SPARK, 8);
        //makes itself (and teammates) gain atk and spd for a while
        public const Ability CHARGED_TACKLE = new Ability("Charged Tackle",
        "src/assets/icons/abilities/tackle.png", Types.SPARK, 6);
        //tackle, but an electric move and has a 15% chance of paralyzing opponents

        //GHOUL MOVES
        public const Ability SPOOK = new Ability("Spook",
        "src/assets/icons/abilities/spook.png", Types.GHOUL, 5); //appears behind opp and
        //damages them which also has a 25% chance of paralyzing them
        public const Ability PHASE = new Ability("Phase",
        "src/assets/icons/abilities/phase.png", Types.GHOUL, 8);
        //kubo goes half transparent and gains the ghost status effect
        //which makes it phase through other kubos and walls but makes it take more damage
        public const Ability VANISH = new Ability("Vanish",
        "src/assets/icons/abilities/sleep.png", Types.GHOUL, 8);
        //makes the kubo immune to all damage and putting it to sleep to heal
        //for a while but when it comes back its def stat is halved

        //GRASS MOVES
        public const Ability VINE_WHOOP = new Ability("Vine Whoop",
        "src/assets/icons/abilities/vine_whoop.png", Types.GRASS, 6);
        //every opponent within a cone area of 90 degrees + xWidth*20 is hit twice
        public const Ability ABSORPTION = new Ability("Absorption",
        "src/assets/icons/abilities/absorption.png", Types.GRASS, 8);
        //kubo heals 2/3 the amount of health taken from the opp with an attack
        public const Ability LEAF_SHOT = new Ability("Leaf Shot",
        "src/assets/icons/abilities/leaf_shot.png");
        //kubo shoots 10 + xProj*2 leaves at the opp

        //FIGHTING MOVES
        public const Ability ANKLE_BREAKER = new Ability("Ankle Breaker",
        "src/assets/icons/abilities/ankle_breaker.png",Types.FIGHTING, 8); 
        //gains speed, lowers opp speed and slides past them, hitting them
        public const Ability BOXING_HIT = new Ability("Boxing Hit",
        "src/assets/icons/abilities/punch.png", Types.FIGHTING, 6);
        //hits the opp with a powerful punch
        public const Ability KICKING_SPIN = new Ability("Kicking Spin",
        "src/assets/icons/abilities/4proj.png", Types.FIGHTING, 6);
        //

    }
}