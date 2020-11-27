using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVariables : MonoBehaviour
{
    int currentLevel = 0;
    int numberOfEnemiesOnLevel = 0;
    public Level[] levels;
    public GameObject[] enemies;
    public GameObject poolingPlace;
    public GameObject endMenu;
    public GameObject restartExitMenu;
    public GameObject menuButton;
    public Shoot playerShootScript;
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
        
        
        foreach(GameObject enemy in enemies)
        {
            EnemyHit enemyHit = enemy.GetComponent<EnemyHit>();
            enemyHit.aiming.enabled = false;
            enemyHit.shoot.enabled = false;
            enemyHit.rotating.enabled = false;
            enemyHit.line.SetActive(false);
            enemyHit.transform.position = poolingPlace.transform.position;
        }
        currentLevel--;
        numberOfEnemiesOnLevel = 0;
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void Resume()
    {
        restartExitMenu.SetActive(false);
        menuButton.SetActive(true);

        playerShootScript.enabled = true;
        foreach (GameObject enemy in enemies)
        {
            Shoot shoot = enemy.GetComponent<Shoot>();
            shoot.enabled = true;
        }
    }

    public void ToInGameMenu()
    {
        restartExitMenu.SetActive(true);
        menuButton.SetActive(false);
        playerShootScript.enabled = false;

        foreach (GameObject enemy in enemies)
        {
            Shoot shoot = enemy.GetComponent<Shoot>();
            shoot.enabled = false;          
        }
    }

    public void RestartGame()
    {
        restartExitMenu.SetActive(false);
        endMenu.SetActive(false);
        menuButton.SetActive(true);
        playerShootScript.enabled = true;
        foreach (GameObject enemy in enemies)
        {
            EnemyHit enemyHit = enemy.GetComponent<EnemyHit>();
            enemyHit.aiming.enabled = false;
            enemyHit.shoot.enabled = false;
            enemyHit.rotating.enabled = false;
            enemyHit.line.SetActive(false);
            enemyHit.transform.position = poolingPlace.transform.position;
        }
        currentLevel = 0;
        numberOfEnemiesOnLevel = 0;
    }
}
