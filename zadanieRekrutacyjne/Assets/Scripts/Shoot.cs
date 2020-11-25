using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    private Touch touch;
    public GameObject shootPoint1;
    public GameObject shootPoint2;
    private bool canShoot = true;
    void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Ended && !canShoot)
            {
                canShoot = true;
            }

            if (touch.phase == TouchPhase.Stationary && canShoot)
            {
                canShoot = false;
                Shooting();
            }   
        }
    }

    void Shooting()
    {
            RaycastHit hit;
            Vector3 direction = shootPoint2.transform.position - shootPoint1.transform.position;
        if (Physics.Raycast(shootPoint1.transform.position, direction, out hit, Mathf.Infinity))
        {
            if (hit.transform.gameObject.CompareTag("Enemy"))
            {
                EnemyHit enemyHit = hit.transform.gameObject.GetComponent<EnemyHit>();
                enemyHit.Dead();
            }
            else
            {
                if (hit.transform.gameObject.CompareTag("Player"))
                {
                    PlayerHit playerHit = hit.transform.gameObject.GetComponent<PlayerHit>();
                    playerHit.RestartLevel();
                }
            }
        }
    }
}
