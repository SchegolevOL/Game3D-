using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] Transform shootPoint;
    [SerializeField] float power;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject newBullet = Instantiate(bulletPrefab, shootPoint.position, bulletPrefab.transform.rotation);

            newBullet.GetComponent<Rigidbody>().AddForce(shootPoint.forward 
                                                         * power * Time.deltaTime, ForceMode.Impulse);
        }
    }

}
