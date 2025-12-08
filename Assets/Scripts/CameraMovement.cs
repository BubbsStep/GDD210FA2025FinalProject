using UnityEngine;

public class MoveRight : MonoBehaviour
{
    public float speed = 1f; 
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
