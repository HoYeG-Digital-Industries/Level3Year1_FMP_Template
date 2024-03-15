using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject firePoint;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            GameObject bulletClone = Instantiate(bulletPrefab, firePoint.transform.position, Quaternion.identity);
            Destroy(bulletClone, 5f);
        }
        
    }
}
