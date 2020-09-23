using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int maxHealth = 100;
    private int currentHealth;
    private float deathTime = 4f;
    private BoxCollider2D boxCollider;
    private EnemyAnimations animations;

    private void Awake()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        animations = GetComponent<EnemyAnimations>();
    }

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }
    
    public void TakeDamage(int damage)
    {
        currentHealth = currentHealth - damage;
        animations.PlayHurtAnimation();

        //Play the hurt animation

        if (currentHealth <= 0)
            Die();
    }

    void Die()
    {
        //play the death animation
        Debug.Log("Enemy died");
        animations.PlayDeathAnimation();
        boxCollider.enabled = false;
        Destroy(gameObject, deathTime);
    }

}
