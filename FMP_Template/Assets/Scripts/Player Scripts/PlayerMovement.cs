using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [Range(1, 10)] public float moveSpeed;
    public GameObject playerPrefab;
    public bool spriteUsed;
    
    GameObject clone;
    Rigidbody rb;
    Vector3 moveDirection;
    Camera mainCamera;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        clone = Instantiate(playerPrefab, transform.position, Quaternion.identity, this.transform);
        mainCamera = Camera.main;
    }

    void FixedUpdate()
    {
        Move();
    }

    void LateUpdate(){
        if(spriteUsed == true){
            clone.transform.LookAt(mainCamera.transform);
            clone.transform.Rotate(0, 0, 0);
        }
    }

    void Move(){
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");
        moveDirection = (moveHorizontal * transform.right + moveVertical * transform.forward);
        rb.MovePosition(transform.position + moveDirection * moveSpeed * Time.deltaTime);
    }
}
