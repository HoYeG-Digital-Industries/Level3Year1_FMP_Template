using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
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
        Instantiate(enemyPrefabs[Random.Range(0, 2)], transform.position, Quaternion.identity);
        enemyCount++;
    }
    
}
