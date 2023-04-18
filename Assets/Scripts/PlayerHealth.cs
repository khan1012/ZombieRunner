using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float totalHealth = 100f;

    public void TakeDamage(float damage)
    {
        totalHealth -= damage;
        if (totalHealth <= 0) { GetComponent<DeathHandler>().HandleDeath(); }
    }
}
