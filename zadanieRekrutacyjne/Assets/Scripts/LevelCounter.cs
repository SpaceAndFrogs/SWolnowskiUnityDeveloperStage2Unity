using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelCounter : MonoBehaviour
{
    public GlobalVariables var;
    private TextMeshProUGUI counter;
    private void Start()
    {
        counter = gameObject.GetComponent<TextMeshProUGUI>();
        counter.text = "LvL " + (var.CurrentLevel() + 1);
    }

    public void ChangeLevel()
    {
        counter.text = "LvL " + (var.CurrentLevel() + 1);
    }
}
