using UnityEngine;

public class PlayerClamp : MonoBehaviour
{
    public Camera cam;      // Assign your camera
    public float padding = 0.3f;

    float minX, maxX;

    void Start()
    {
        if (cam == null)
            cam = Camera.main;
    }

    void Update()
    {
        UpdateBounds();

        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, minX, maxX);
        transform.position = pos;
    }

    void UpdateBounds()
    {
        float depth = Mathf.Abs(cam.transform.position.z - transform.position.z);

        Vector3 leftWorld = cam.ScreenToWorldPoint(new Vector3(0, 0, depth));
        Vector3 rightWorld = cam.ScreenToWorldPoint(new Vector3(Screen.width, 0, depth));

        minX = leftWorld.x + padding;
        maxX = rightWorld.x - padding;
    }
}
