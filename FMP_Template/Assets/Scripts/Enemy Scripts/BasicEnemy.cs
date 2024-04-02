using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BasicEnemy : MonoBehaviour
{
    [Range(1, 100)]
    public float enemyHealth;
    public float enemyDamage, enemySpeed, attackRange;
    public Transform playerObject;

    NavMeshAgent navAgent;

    // Start is called before the first frame update
    void Start()
    {
        playerObject = GameObject.FindWithTag("Player").transform;
        navAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        navAgent.destination = playerObject.position;
        if(Vector3.Distance(playerObject.position, transform.position) <= attackRange){
            playerObject.GetComponent<PlayerHealth>().TakeDamage(enemyDamage);
            Destroy(gameObject);
        }
    }

    public void TakeDamage(float amount){
        enemyHealth -= amount;
        if(enemyHealth <= 0f){
            Destroy(gameObject);
        }
    }
}
