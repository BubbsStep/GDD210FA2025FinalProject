using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    //public float speed = 2f;

    [SerializeField] private Animator playerAnimator;

    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");  
        float moveZ = Input.GetAxisRaw("Vertical");    

        Vector3 move = new Vector3(moveX, 0f, moveZ) * speed * Time.deltaTime;

        transform.Translate(move, Space.World);

        if(Input.anyKey)
        {
            playerAnimator.SetTrigger("Walk");
            playerAnimator.Play("PlayerWalk");
        }
        else
        {
            playerAnimator.SetTrigger("Idle");
            playerAnimator.Play("PlayerIdle");
        }

    }
}
