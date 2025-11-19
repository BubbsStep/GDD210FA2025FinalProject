using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private Animator demoSwordAnimator;
    [SerializeField] private Collider demoAttackCollider;
    [SerializeField] private SpriteRenderer demoSwordSprite;

    private bool isAttacking = false;

    void Update()
    {
        if (!isAttacking && Input.GetMouseButtonDown(0))
        {
            Debug.Log("Player Attack");
            StartAttack();
        }
    }

    private void StartAttack()
    {
        isAttacking = true;

        // Reset the animator state so the animation always restarts
        demoSwordAnimator.Rebind();
        demoSwordAnimator.Update(0f);

        demoAttackCollider.enabled = true;
        demoSwordSprite.enabled = true;
        demoSwordAnimator.SetTrigger("SwordAttack");
    }

    // Called as an animation event
    private void EndSwordAttack()
    {
        demoAttackCollider.enabled = false;
        demoSwordSprite.enabled = false;

        isAttacking = false;
    }
}