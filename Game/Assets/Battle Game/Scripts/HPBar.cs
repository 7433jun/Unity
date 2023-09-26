using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPBar : MonoBehaviour
{
    [SerializeField] Slider hpBar;

    private void Awake()
    {
        hpBar = gameObject.GetComponentInChildren<Slider>();
    }

    public void CurrentHP(float hp, float MaxHP)
    {
        hpBar.value = hp / MaxHP;
    }
}
