using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public GameObject[] spawnPoints;
    public GameObject playerSpawnPoint;

    public void SpawnEnemies()
    {
        foreach(GameObject point in spawnPoints)
        {
            point.SetActive(true);
            EnemySpawn enemySpawn = point.GetComponent<EnemySpawn>();
            enemySpawn.Spawn();
            
        }
    }
}
