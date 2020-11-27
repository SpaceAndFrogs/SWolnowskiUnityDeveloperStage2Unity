using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    private Touch touch;
    public GameObject shootPoint1;
    public GameObject shootPoint2;
    private bool canShoot = false;
    public AudioSource gunShoot;
    public Animator animator;
    public ParticleSystem shootParticle;
    void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began && !canShoot)
            {
                canShoot = true;
            }

            if(touch.phase == TouchPhase.Moved && canShoot)
            {
                canShoot = false;
            }

            if (touch.phase == TouchPhase.Ended && canShoot)
            {
                canShoot = false;
                Shooting();
            }   
        }
    }

    void Shooting()
    {
        gunShoot.Play();
        animator.SetTrigger("Shoot");
        shootParticle.Play();
        RaycastHit hit;
        Vector3 direction = shootPoint2.transform.position - shootPoint1.transform.position;
        
        if (Physics.Raycast(shootPoint1.transform.position, direction, out hit, Mathf.Infinity))
        {
            if (hit.transform.gameObject.CompareTag("Player"))
            {
                PlayerHit playerHit = hit.transform.gameObject.GetComponent<PlayerHit>();
                playerHit.RestartLevel();
                
            }
            else
            {
                if (hit.transform.gameObject.CompareTag("Enemy"))
                {
                    EnemyHit enemyHit = hit.transform.gameObject.GetComponent<EnemyHit>();
                    enemyHit.Dead();
                }
            }
        }
    }
}
