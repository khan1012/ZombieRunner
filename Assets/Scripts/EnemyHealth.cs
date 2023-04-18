using UnityEngine;
using UnityEngine.AI;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float totalHealth = 100;
    public bool isDead;

    public void TakeDamage(float damage)
    {
        BroadcastMessage("OnDamageTaken");
        totalHealth -= damage;
        if (totalHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        isDead = true;
        GetComponent<Animator>().SetTrigger("die");
    }

    public bool IsDead()
    {
        return isDead;
    }
}
