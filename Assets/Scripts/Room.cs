using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
    [SerializeField] Door doorToNextRoom;

    private int _enemyCount;
    public int EnemyCount=>_enemyCount;

    public void AddEnemy()
    {
        _enemyCount++;
    }

    public void ReduceEnemyCount()
    {
        _enemyCount -= 1;

        if (_enemyCount <= 0)
        {
            StartCoroutine(doorToNextRoom.OpenDoorCorutine());
        }
    }
}
