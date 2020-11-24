using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aiming : MonoBehaviour
{
    public LineRenderer line;
    public GameObject shootPoint1;
    public GameObject shootPoint2;
    void Start()
    {
        line.SetPosition(0, shootPoint1.transform.position);

        line.SetPosition(1, shootPoint2.transform.position);
    }
    private void FixedUpdate()
    {
        line.SetPosition(0, shootPoint1.transform.position);
        line.SetPosition(1, shootPoint2.transform.position);
    }
}
