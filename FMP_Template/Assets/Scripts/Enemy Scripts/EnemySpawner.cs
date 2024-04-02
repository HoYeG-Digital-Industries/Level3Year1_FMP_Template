using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyOne;
    [Range(1, 10)] public float spawnRate;

    int enemyCount;

    void Start(){
        InvokeRepeating("Spawn", 0.5f, spawnRate);
    }
    void Update()
    {
        if(enemyCount == 5){
            CancelInvoke();
        }
    }

    void Spawn(){
        Instantiate(enemyOne, transform.position, Quaternion.identity);
        enemyCount++;
    }
    
}
