using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");  
        float moveZ = Input.GetAxisRaw("Vertical");    

        Vector3 move = new Vector3(moveX, 0f, moveZ) * speed * Time.deltaTime;

        transform.Translate(move, Space.World);
    }
}
