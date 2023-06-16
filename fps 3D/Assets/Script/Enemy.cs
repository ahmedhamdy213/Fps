using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int Hp = 200;
    public Animator animator;
    public void TakeDamage(int damageAmount)
    {
        Hp -= damageAmount;
        if (Hp <= 0) 
        {
            animator.SetTrigger("Die");
        
        }
        
    }
}
