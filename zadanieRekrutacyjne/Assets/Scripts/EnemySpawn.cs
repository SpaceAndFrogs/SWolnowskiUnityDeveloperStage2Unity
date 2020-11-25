using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GlobalVariables var;

    public void Spawn()
    {
        var.enemies[var.NumberOfEnemies()].transform.position = transform.position;
        var.enemies[var.NumberOfEnemies()].transform.rotation = transform.rotation;

        EnemyHit enemyHit = var.enemies[var.NumberOfEnemies()].GetComponent<EnemyHit>();

        enemyHit.aiming.enabled = true;

        enemyHit.rotating.enabled = true;

        enemyHit.shoot.enabled = true;

        enemyHit.line.SetActive(true);

        var.SetNumberOfEnemiesOnLevel(var.NumberOfEnemies() + 1);
    }
   
}
