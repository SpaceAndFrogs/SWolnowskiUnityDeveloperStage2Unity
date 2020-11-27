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
    public AudioSource hitSound;
    public float animationTime;
    public Animator animator;
    public void Dead()
    {
        hitSound.Play();
        animator.SetTrigger("Die");
        aiming.enabled = false;
        rotating.enabled = false;
        shoot.enabled = false;
        line.SetActive(false);
        StartCoroutine("ToPoolingPlace");
 
    }
    IEnumerator ToPoolingPlace()
    {
        yield return new WaitForSeconds(animationTime);
        var.decreseNumberOfEnemiesOnLevel();
        transform.position = pollingPlace.position;
    }
}
