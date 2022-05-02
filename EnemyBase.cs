using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "Enemy", menuName = "Enemy/Create new enemy")]


public class EnemyBase : ScriptableObject
{

    [SerializeField]  string name;

    [TextArea]
    [SerializeField]  string description;

    [SerializeField]  Sprite frontSprite;
    [SerializeField]  Sprite backSprite;

    [SerializeField]  EnemyType type1;
    [SerializeField]  EnemyType type2;

    //Base stats
    [SerializeField] int maxHp;
    [SerializeField] int attack;
    [SerializeField] int defense;
    [SerializeField] int spAttack;
    [SerializeField] int spDefense;
    [SerializeField] int speed;
    [SerializeField] int anxiety;

[SerializeField] List<LearnableMove> learnableMoves;


    //getters por propiedades, C Sharp

    public string Name 
    {
        get {return name;}
    }

    public string Description
    {
        get {return description;}
    }

    public Sprite FrontSprite
    {
        get {return frontSprite;}
    }

    public Sprite BackSprite
    {
        get {return backSprite;}
    }

    public EnemyType Type1
    {
        get {return type1;}
    }

    public EnemyType Type2
    {
        get {return type2;}
    }

    public int MaxHp
    {
        get {return maxHp;}
    }

    public int Attack
    {
        get {return attack;}
    }

    public int Defense
    {
        get {return defense;}
    }

    public int SpAttack
    {
        get {return spAttack;}
    }

    public int SpDefense
    {
        get {return spDefense;}
    }

    public int Speed
    {
        get {return speed;}
    }

    public int Anxiety
    {
        get {return anxiety;}
    }

    public List<LearnableMove> LearnableMoves
    {
        get {return learnableMoves;}
    }



}

[System.Serializable]

public class LearnableMove
{
    [SerializeField] MoveBase moveBase;
    [SerializeField] int level;

    public MoveBase Base
    {
        get {return moveBase;}
    }

    public int Level
    {
        get {return level;}
    }
}


public enum EnemyType {

    None,
    Normal,
    Ghost,
    Slime,
    Owl,
    PoisonJar,
    Dummie,
    Chamape,
    PhysDmg,
    SpDmg,
    Poison,
    Paralysis,
    AttackShout,
    DeadlyFlutter,
    SlimeBalls,
    Burn,
    Hysteria,
    Stomp,
    StealSoul,
    Slingshot,
    Claws,
    StoneBalls,

}