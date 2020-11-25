﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHit : MonoBehaviour
{
    public GlobalVariables var;
    public float resetDelay;
    private float resetDelayCd;
    private bool reset = false;
    private void Start()
    {
        resetDelayCd = resetDelay;
    }
    public void RestartLevel()
    {

        //To Do: death animation and sound
        reset = true;
    }
    private void Update()
    {
        if(reset)
        {
            resetDelayCd -= Time.deltaTime;
        }

        if(resetDelayCd <= 0)
        {
            reset = false;
            resetDelayCd = resetDelay;
            var.ResetLevel();
        }
    }
}
