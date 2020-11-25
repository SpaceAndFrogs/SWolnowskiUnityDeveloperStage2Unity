using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHit : MonoBehaviour
{
    public GlobalVariables var;
    public Transform pollingPlace;
    public Aiming aiming;
    public Rotating rotating;
    public Shoot shoot;
    public GameObject line;
    public void Dead()
    {
        aiming.enabled = false;
        rotating.enabled = false;
        shoot.enabled = false;
        line.SetActive(false);
        var.decreseNumberOfEnemiesOnLevel();
        transform.position = pollingPlace.position;

        //To Do: Death animation and sound

    }
}
