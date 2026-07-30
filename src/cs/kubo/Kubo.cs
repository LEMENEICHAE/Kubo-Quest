using Enums;
using Abilities;

public class Kubo {
    public string Name {get; set;}
    public Types Type {get; set;}
    public string ModelLink {get; private set;}
    public int BaseATK {get; set;}
    public int BaseHP {get; set;}

    public Ability ability1 = {get; set;}
    public Ability ability2 = {get; set;}

    public Kubo(string name, Types type, string ModelLink, int baseATK, int baseHP,
        Ability ab1, Ability ab2) {
        Name = name;
        Type = type;
        ModelLink = modelLink;
        BaseATK = baseATK;
        BaseHP = baseHP;
        Ability1 = ab1;
        Ability2 = ab2;
    }
}