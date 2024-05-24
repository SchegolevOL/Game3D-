using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] Room enemyRoom;

    void Start()
    {
        enemyRoom.AddEnemy();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Destroy(gameObject);
        }
    }
    private void OnDestroy()
    {
        enemyRoom.ReduceEnemyCount();
    }

}
