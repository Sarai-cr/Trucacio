using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleUnit : MonoBehaviour
{
  [SerializeField] EnemyBase _base;
  [SerializeField] int level;
  [SerializeField] bool isPlayerUnit;

  public Enemigo Enemy {get; set;}

    
  //crear enemigo desde la base y nivel
  public void Setup()
  {
        Enemy = new Enemigo(_base,level);
        if (isPlayerUnit)
            GetComponent<Image>().sprite = Enemy.Base.BackSprite;
        else 
            GetComponent<Image>().sprite = Enemy.Base.FrontSprite;
  }
}
