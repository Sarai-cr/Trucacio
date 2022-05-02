using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo 
{
    public EnemyBase Base {get; set;}
    public int Level {get; set;}

    public int HP {get; set;}

    public List<Move> Moves {get; set;}


    public Enemigo(EnemyBase pBase, int pLevel)
    {
        Base = pBase;
        Level = pLevel;
        HP = MaxHp;

        //Crear movimientos 
        Moves = new List<Move>();
        foreach (var move in Base.LearnableMoves)
        {
            if (move.Level <=Level)
                Moves.Add(new Move (move.Base));
            
            if (Moves.Count >=4)
                break;

        }
    }

    public int Attack 
    {
        //fórmula para calcular stats y nivel
        get {return Mathf.FloorToInt((Base.Attack*Level)/100f)+5;}
    }

     public int MaxHp 
    {
        //fórmula para calcular stats y nivel
        get {return Mathf.FloorToInt((Base.MaxHp*Level)/100f)+10;}
    }

     public int Defense 
    {
        //fórmula para calcular stats y nivel
        get {return Mathf.FloorToInt((Base.Defense*Level)/100f)+5;}
    }

     public int SpAttack 
    {
        //fórmula para calcular stats y nivel
        get {return Mathf.FloorToInt((Base.SpAttack*Level)/100f)+5;}
    }
 
     public int SpDefense 
    {
        //fórmula para calcular stats y nivel
        get {return Mathf.FloorToInt((Base.SpDefense*Level)/100f)+5;}
    }

     public int Speed 
    {
        //fórmula para calcular stats y nivel
        get {return Mathf.FloorToInt((Base.Speed*Level)/100f)+5;}
    }

    public int Anxiety 
    {
        //fórmula para calcular stats y nivel
        get {return Mathf.FloorToInt((Base.Speed*Level)/100f)+5;}
    }

    public bool TakeDamage(Move move, Enemigo attacker)
    {
        //el daño depende del nivel y poder del personaje 
        float modifiers = Random.Range(0.85f, 1f);
        float a = (2*attacker.Level + 10) / 250f;
        float d = a*move.Base.Power*((float)attacker.Attack/Defense) + 2;
        int damage = Mathf.FloorToInt(d*modifiers);

        HP -= damage;
        if (HP <= 0)
        {
            HP = 0;
            return true;
        }
        return false;
    }

    public Move GetRandomMove()
    {
        int r = Random.Range(0,Moves.Count);
        return Moves[r];
    }
}
