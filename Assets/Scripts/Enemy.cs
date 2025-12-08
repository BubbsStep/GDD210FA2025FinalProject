using Unity.VisualScripting;
using UnityEngine;

public class SimpleHomingEnemy : MonoBehaviour
{
    public float speed = 3f;
    public int maxHealth = 10;
    public int damage = 10;

    [SerializeField] private int rewardMoney;

    private int currentHealth;
    private Transform player;

    public float iFrameDuration = 0.2f;
    private bool isInvincible = false;
    private float iFrameTimer = 0f;

    [SerializeField] private SpriteRenderer enemyRend;
    private Color originalColor = Color.white;

    void Start()
    {
        currentHealth = maxHealth;
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        // movement
        if (player != null && !isInvincible)
        {
            Vector3 direction = (player.position - transform.position).normalized;
            transform.position += direction * speed * Time.deltaTime;

            //Flip sprite based on direction
            if (direction.x < 0)
                enemyRend.flipX = false;
            else
                enemyRend.flipX = true;
        }

        // i-frame countdown
        if (isInvincible)
        {
            iFrameTimer -= Time.deltaTime;

            if (iFrameTimer <= 0)
            {
                isInvincible = false;
                enemyRend.color = originalColor;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Attack"))
        {
            TakeDamage(PlayerAttack.damage);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerInv.playerHealth -= damage;
        }
    }

    public void TakeDamage(int amount)
    {
        if (isInvincible) return;

        currentHealth -= amount;

        // Knockback
        Vector3 knockDir = (transform.position - player.position).normalized;
        transform.position += knockDir * 1f;

        // Turn red and start invincible timer
        enemyRend.color = Color.red;
        isInvincible = true;
        iFrameTimer = iFrameDuration;

        if (currentHealth <= 0)
        {
            PlayerInv.playerCurrency += rewardMoney;
            //Gives the player money for defeating the enemy
            Destroy(gameObject);
        }
    }
}
