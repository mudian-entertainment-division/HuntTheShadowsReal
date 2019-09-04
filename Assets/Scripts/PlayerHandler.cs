
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHandler : MonoBehaviour
{
    [Header("Value Variables")]

    public float curHealth;
    public float curMana, maxHealth, maxMana;
    [Header("Value Variables")]

    public Slider healthBar;
    public Slider manaBar;
    void Start()
    {

    }

    void Update()
    {
        if (healthBar.value != Mathf.Clamp01(curHealth / maxHealth))
        {
            curHealth = Mathf.Clamp(curHealth, 0, maxHealth);
            healthBar.value = Mathf.Clamp01(curHealth / maxHealth);
        }
        if (manaBar.value != Mathf.Clamp01(curMana / maxMana))
        {
            curMana = Mathf.Clamp(curMana, 0, maxHealth);
            manaBar.value = Mathf.Clamp01(curMana / maxMana);
        }
    }
}