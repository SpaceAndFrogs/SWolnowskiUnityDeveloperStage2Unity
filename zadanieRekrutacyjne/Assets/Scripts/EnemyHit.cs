using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHit : MonoBehaviour
{
    public void Dead()
    {
        gameObject.SetActive(false);
        //To Do: Death animation and sound
    }
}
