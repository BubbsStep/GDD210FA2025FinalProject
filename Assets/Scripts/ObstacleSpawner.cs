using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject[] obstacles;
    public Transform player;

    public float spawnOffsetX = 8f;
    public float groundY = 0f;
    public float minZ = -1f;
    public float maxZ = 1f;

    public float spawnRate = 1.5f;
    private float timer;

    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
            SpawnObstacle();
            timer = spawnRate;
        }
    }

    void SpawnObstacle()
    {
        if (obstacles.Length == 0) return;

        GameObject obj = obstacles[Random.Range(0, obstacles.Length)];

        float randomZ = Random.Range(minZ, maxZ);

        Vector3 spawnPos = new Vector3(
            player.position.x + spawnOffsetX,
            groundY,
            randomZ
        );

        Instantiate(obj, spawnPos, Quaternion.Euler(0f, 90f, 0f));

    }
}
