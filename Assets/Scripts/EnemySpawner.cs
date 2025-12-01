using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [System.Serializable]
    public class EnemySpawnData
    {
        public GameObject enemyPrefab;
        public float spawnInterval = 2f;
        [HideInInspector] public float timer;
    }

    [Header("Enemy Spawn List")]
    public EnemySpawnData[] enemies;

    void Update()
    {
        foreach (EnemySpawnData enemyData in enemies)
        {
           
            enemyData.timer -= Time.deltaTime;

            if (enemyData.timer <= 0f)
            {
                Spawn(enemyData);
                enemyData.timer = enemyData.spawnInterval; 
            }
        }
    }

    void Spawn(EnemySpawnData data)
    {
        if (data.enemyPrefab == null) return;

        Instantiate(data.enemyPrefab, transform.position, Quaternion.identity);
    }
}
