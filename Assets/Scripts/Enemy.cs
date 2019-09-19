using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    public float speed;
    public Animator animator;

    private void Update()
    {
        
           if (health <= 0)
        {
            Destroy(gameObject);
            //animator.SetBool("isDead", true);
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
   
    }
}
