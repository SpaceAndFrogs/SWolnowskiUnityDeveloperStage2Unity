using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVariables : MonoBehaviour
{
    int currentLevel = 0;
    int numberOfEnemiesOnLevel = 0;
    public Level[] levels;
    public GameObject[] enemies;
    public Transform pollingPlace;
    public void IncreseCurrentLevel()
    {
        currentLevel++;
    }

    public int CurrentLevel()
    {
        return currentLevel;
    }

    public void decreseNumberOfEnemiesOnLevel()
    {
        numberOfEnemiesOnLevel--;
    }

    public int NumberOfEnemies()
    {
        return numberOfEnemiesOnLevel;
    }

    public void SetNumberOfEnemiesOnLevel(int amountOfEnemies)
    {
        numberOfEnemiesOnLevel = amountOfEnemies;
    }

    public void ResetLevel()
    {
        numberOfEnemiesOnLevel = 0;
        currentLevel--;
        foreach(GameObject enemy in enemies)
        {
            enemy.transform.position = pollingPlace.position;
        }
    }
}
