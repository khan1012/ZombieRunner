using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float totalHealth = 100;

    public void TakeDamage(float damage)
    {
        BroadcastMessage("OnDamageTaken");
        totalHealth -= damage;
        if (totalHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
