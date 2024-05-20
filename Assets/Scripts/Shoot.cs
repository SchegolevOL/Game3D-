using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    [SerializeField] GameObject bullet;
    [SerializeField] Transform shootPoint;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, shootPoint.position, bullet.transform.rotation);
        }
    }

}
