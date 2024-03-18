using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public float moveSpeed;
    public GameObject target;
    void Update(){
        Move();
    }

    void Move(){
        var step = moveSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, step);
    }








    #region oldVersion
    /*
    GameObject playerTarget;
    Vector3 offSet;

    // Start is called before the first frame update
    void Start()
    {
        playerTarget = GameObject.FindWithTag("Player");
        offSet = transform.position - playerTarget.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, playerTarget.transform.position + offSet, 0.01f);
    }*/
    #endregion
}
