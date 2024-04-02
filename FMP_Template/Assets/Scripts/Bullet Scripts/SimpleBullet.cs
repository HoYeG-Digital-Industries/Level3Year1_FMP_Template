using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleBullet : MonoBehaviour
{
    Rigidbody rigidbody;
    [Range(1, 20)] public float bulletSpeed;
    public float bulletDamage;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.AddForce(transform.forward * bulletSpeed, ForceMode.Impulse);
    }

    void OnTriggerEnter(Collider other){
        if(other.tag == "BasicEnemy"){
            other.transform.GetComponent<BasicEnemy>().TakeDamage(bulletDamage);
            Destroy(gameObject);
        }
        if(other.tag == "RangeEnemy"){
            //do something here for ranged
        }
    }
}
