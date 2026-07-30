using Abilities;
using Enums;

namespace AbilitiesRegistry {
    public class AbilityRegistry {

        //PLAIN MOVES
        public static readonly Ability TACKLE = new Ability("Tackle",
        "src/assets/icons/abilities/tackle.png", Types.PLAIN, 5); //SLIDES FORWARD AND HITS
        public static readonly Ability LAUNCH = new Ability("Launch",
        "src/assets/icons/abilities/launch.png", Types.PLAIN, 8); //hits opp and launches them far
        public static readonly Ability MEGA_PUNCH = new Ability("Mega-Punch",
        "src/assets/icons/abilities/mega_punch.png", Types.PLAIN, 8); //hits opp with a hard punch

        //AQUA MOVES
        public static readonly Ability WHIRLPOOL = new Ability("Whirlpool",
        "src/assets/icons/abilities/4proj.png", Types.AQUA, 6);
        //sucks opponents towards itself, and then launches them out with a lot of dmg
        public static readonly Ability TSUNAMI = new Ability("Tsunami",
        "src/assets/icons/abilities/tsunami.png", Types.AQUA, 8);
        //creates a huge wave that pushes opps away
        public static readonly Ability WATER_BOMB = new Ability("Water Bomb",
        "src/assets/icons/abilities/bomb.png", Types.AQUA, 6);
        //drops a bomb of water that explodes onto an opp
        public static readonly Ability AQUA_DEFENSE = new Ability("Aqua Defense",
        "src/assets/icons/abilities/speed_defense_gain.png", Types.AQUA, 5);

        //SPARK MOVES
        public static readonly Ability LIGHTNING = new Ability("Lightning",
        "src/assets/icons/abilities/lightning.png", Types.SPARK, 6);
        //shoots a lightning strike down at the opponent
        public static readonly Ability CHARGED_FIELD = new Ability("Charged Field",
        "src/assets/icons/abilities/attack_defense_gain.png", Types.SPARK, 8);
        //makes itself (and teammates) gain atk and spd for a while
        public static readonly Ability CHARGED_TACKLE = new Ability("Charged Tackle",
        "src/assets/icons/abilities/tackle.png", Types.SPARK, 6);
        //tackle, but an electric move and has a 15% chance of paralyzing opponents

        //GHOUL MOVES
        public static readonly Ability SPOOK = new Ability("Spook",
        "src/assets/icons/abilities/spook.png", Types.GHOUL, 5); //appears behind opp and
        //damages them which also has a 25% chance of paralyzing them
        public static readonly Ability PHASE = new Ability("Phase",
        "src/assets/icons/abilities/phase.png", Types.GHOUL, 8);
        //kubo goes half transparent and gains the ghost status effect
        //which makes it phase through other kubos and walls but makes it take more damage
        public static readonly Ability VANISH = new Ability("Vanish",
        "src/assets/icons/abilities/sleep.png", Types.GHOUL, 8);
        //makes the kubo immune to all damage and putting it to sleep to heal
        //for a while but when it comes back its def stat is halved

        //GRASS MOVES
        public static readonly Ability VINE_WHOOP = new Ability("Vine Whoop",
        "src/assets/icons/abilities/vine_whoop.png", Types.GRASS, 6);
        //every opponent within a cone area of 90 degrees + xWidth*20 is hit twice
        public static readonly Ability ABSORPTION = new Ability("Absorption",
        "src/assets/icons/abilities/absorption.png", Types.GRASS, 8);
        //kubo heals 2/3 the amount of health taken from the opp with an attack
        public static readonly Ability LEAF_SHOT = new Ability("Leaf Shot",
        "src/assets/icons/abilities/leaf_shot.png", Types.GRASS, 6);
        //kubo shoots 10 + xProj*2 leaves at the opp

        //FIGHTING MOVES
        public static readonly Ability ANKLE_BREAKER = new Ability("Ankle Breaker",
        "src/assets/icons/abilities/ankle_breaker.png", Types.FIGHTING, 8); 
        //gains speed, lowers opp speed and slides past them, hitting them
        public static readonly Ability BOXING_HIT = new Ability("Boxing Hit",
        "src/assets/icons/abilities/punch.png", Types.FIGHTING, 6);
        //hits the opp with a powerful punch
        public static readonly Ability KICKING_SPIN = new Ability("Kicking Spin",
        "src/assets/icons/abilities/4proj.png", Types.FIGHTING, 6);
        //hits all opps in a certain range in a full circle, knocking them back

        //PYRO MOVES
        public static readonly Ability FLAMETHROWER = new Ability("Flamethrower",
        "src/assets/icons/abilities/flamethrower.png", Types.PYRO, 6);
        //tracks a target for 3 seconds, spitting fire at them
        //possible to give them the burning status effect
        public static readonly Ability HEATWAVE = new Ability("Heatwave",
        "src/assets/icons/abilities/8proj.png", Types.PYRO, 5);
        //shoots 8 + xProj*2 fire balls in a circle around itself to hit opps
        //possible to give them the burning status effect
        public static readonly Ability BURN_UP = new Ability("Burn Up",
        "src/assets/icons/abilities/burn_up.png", Types.PYRO, 8);
        //increases its defense stat 2x but fire attacks do 1/2 the damage
        //for the duration of the defense stat increase
        
        //TOXIC MOVES
        public static readonly Ability STINGER = new Ability("Stinger",
        "src/assets/icons/abilities/stinger.png", Types.TOXIC, 5);
        //hits the opponent in front of it, having a 35% chance to poison it
        //but it takes 10% of the max HP away
        public static readonly Ability POISON_BOMB = new Ability("Poison Bomb",
        "src/assets/icons/abilities/bomb.png", Types.TOXIC, 5);
        //drops a bomb on the target that upon exploding deals
        //damage and has a 75% chance of poisoning the opp
        public static readonly Ability BREACHING_BITE = new Ability("Breaching Bite",
        "src/assets/icons/abilities/bite.png", Types.TOXIC, 6);
        //bites the opponent and makes them 2x more likely to get a status effect

        //ALLOY MOVES
        public static readonly Ability STEEL = new Ability("Steel",
        "src/assets/icons/abilities/defup_spddown.png", Types.ALLOY, 8);
        //slows kubo down but gives them double the defense

    }
}