using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerIFrames : MonoBehaviour
{
    public float iFrameDuration = 0.2f;
    private bool isInvincible = false;
    private float iFrameTimer = 0f;

    [SerializeField] private SpriteRenderer playerRend;
    private Color originalColor = Color.white;


    void Update()
    {
        if (isInvincible)
        {
            iFrameTimer -= Time.deltaTime;

            if (iFrameTimer <= 0)
            {
                isInvincible = false;
                playerRend.color = originalColor;
            }
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Collision detected!");

        SimpleHomingEnemy enemy = other.gameObject.GetComponent<SimpleHomingEnemy>();

        if (enemy != null)
        {
            TakeDamage(enemy);
        }
    }

    public void TakeDamage(SimpleHomingEnemy enemy)
    {
        if (isInvincible) return;

        Debug.Log("TakeDamage called");

        Vector3 knockDir = (transform.position - enemy.transform.position).normalized;
        transform.position += knockDir * 1f;

        playerRend.color = Color.red;
        isInvincible = true;
        iFrameTimer = iFrameDuration;

        if (PlayerInv.playerHealth <= 0)
        {
            PlayerInv.Inventory.Clear();
            SceneManager.LoadScene("GameOver");
        }
    }
}
