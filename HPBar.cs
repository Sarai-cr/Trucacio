using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPBar : MonoBehaviour
{
    [SerializeField] GameObject anx;

    public void SetHP(float hpNormalized)
    {
        anx.transform.localScale = new Vector3(hpNormalized, 1f);
    }

}
