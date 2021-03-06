using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="Move",menuName ="Enemy/Create new move")] 

public class MoveBase : ScriptableObject
{
    [SerializeField] string name;

    [TextArea]
    [SerializeField] string description;

    [SerializeField] EnemyType type;
    [SerializeField] int power;
    [SerializeField] int accuracy;
    //pp= # de veces que se puede hacer un movimiento
    [SerializeField] int pp;

    public string Name
    {
        get {return name;}
    }

    public string Description
    {
        get {return description;}
    }

    public EnemyType Type
    {
        get {return type;}
    }

    public int Power 
    {
        get {return power;}
    }

    public int Accuracy
    {
        get {return accuracy;}
    }

    public int PP
    {
        get {return pp;}
    }

}
