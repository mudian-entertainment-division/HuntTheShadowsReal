using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{
    public Image healthbar;
    public float maxHealth = 100f;
    public float curHealth = 0f;

    [Header("Enemies")]
    public GameObject enemies;

    void Start()
    {
        curHealth = maxHealth;
        //SetHealthBar();

    }

    public void TakeDamage(float amount)
    {
        curHealth -= amount;
        Debug.Log("Damage Taken");
        if (curHealth <= 0)
        {
            Destroy(gameObject);
        }
        //SetHealthBar();
    }

  
}

