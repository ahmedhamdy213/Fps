
using UnityEngine;

public class Target : MonoBehaviour
{
    public float Health = 50f;
    public Animator animator;

    public void TakeDamage(float amount)
    {
        Health -= amount;
        if (Health <= 0f)
        {
            animator.SetTrigger("Die");

            Die();
        }
    }
   void Die()
    {
        Destroy(gameObject);
    }
}
