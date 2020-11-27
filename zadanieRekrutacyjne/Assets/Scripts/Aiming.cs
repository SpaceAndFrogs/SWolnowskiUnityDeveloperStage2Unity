using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aiming : MonoBehaviour
{
    public LineRenderer line;
    public GameObject shootPoint1;
    public GameObject shootPoint2;
    public Gradient badAiming;
    public Gradient goodAiming;
    public bool isPlayer;
    void Start()
    {
        line.SetPosition(0, shootPoint1.transform.position);

        line.SetPosition(1, shootPoint2.transform.position);
    }
    private void FixedUpdate()
    {
        RaycastHit hit;
        Vector3 direction = shootPoint2.transform.position - shootPoint1.transform.position;
        if(Physics.Raycast(shootPoint1.transform.position,direction, out hit, Mathf.Infinity))
        {

            if(hit.transform.gameObject.CompareTag("Enemy") )
            {
                
                line.colorGradient = goodAiming;
            }else
            {
                if (hit.transform.gameObject.CompareTag("Player"))
                {
                    
                    line.colorGradient = badAiming;
                }else
                {
                    if (hit.transform.gameObject.CompareTag("Cachers"))
                    {
                        if (isPlayer)
                        {
                            line.colorGradient = badAiming;
                        }
                        else
                        {
                            line.colorGradient = goodAiming;
                        }

                    }    
                    
                }
                
            }

            shootPoint2.transform.position = hit.point;
        }
        line.SetPosition(0, shootPoint1.transform.position);
        line.SetPosition(1, shootPoint2.transform.position);
    }
}
