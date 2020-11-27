using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GlobalVariables var;
    public GameObject player;
    public float movementSpeed;
    public LevelCounter levelCounter;
    public GameObject endMenu;
    public GameObject inGameMenu;
    public GameObject menuButton;
    
    void Update()
    {
        if (var.CurrentLevel() == 5 && var.NumberOfEnemies() == 0)
        {
            inGameMenu.SetActive(false);
            menuButton.SetActive(false);
            endMenu.SetActive(true);
        }

        if (var.NumberOfEnemies() == 0 && var.CurrentLevel() < 5)
        {
            
            Vector3 offSet = new Vector3(0, 0, -3f);
            Vector3 desirePlace = new Vector3(var.levels[var.CurrentLevel()].transform.position.x, transform.position.y, var.levels[var.CurrentLevel()].transform.position.z) + offSet;           
            player.transform.position = var.levels[var.CurrentLevel()].playerSpawnPoint.transform.position;
            player.transform.rotation = var.levels[var.CurrentLevel()].playerSpawnPoint.transform.rotation;
            transform.position = desirePlace;
            var.levels[var.CurrentLevel()].SpawnEnemies();
            var.IncreseCurrentLevel();
            levelCounter.ChangeLevel();
        }

        
    }
}
