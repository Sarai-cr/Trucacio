using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleHud : MonoBehaviour
{
    [SerializeField] Text nameText;
    [SerializeField] Text levelText;
    [SerializeField] HPBar HpBar;

    Enemigo _enemy;

    //función de valores
    public void SetData(Enemigo enemy)
    {
        _enemy = enemy;

        nameText.text = enemy.Base.Name;
        levelText.text = "Lvl" + enemy.Level;
        HpBar.SetHP((float) enemy.HP / enemy.MaxHp);
    }

    public void UpdateHP()
    {
        HpBar.SetHP((float)_enemy.HP/_enemy.MaxHp);
    }

}

