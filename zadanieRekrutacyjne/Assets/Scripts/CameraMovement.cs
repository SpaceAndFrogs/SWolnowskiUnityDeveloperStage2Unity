using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GlobalVariables var;
    public GameObject player;
    public float movementSpeed;
    private void Start()
    {
        //var.levels[0].SpawnEnemies();
    }
    void Update()
    {
        if(var.NumberOfEnemies() == 0)
        {
            
            Vector3 offSet = new Vector3(0, 0, -3f);
            Vector3 desirePlace = new Vector3(var.levels[var.CurrentLevel()].transform.position.x, transform.position.y, var.levels[var.CurrentLevel()].transform.position.z) + offSet;           
            player.transform.position = var.levels[var.CurrentLevel()].transform.position;
            transform.position = desirePlace;
            var.levels[var.CurrentLevel()].SpawnEnemies();
            var.IncreseCurrentLevel();
        }
    }
}
