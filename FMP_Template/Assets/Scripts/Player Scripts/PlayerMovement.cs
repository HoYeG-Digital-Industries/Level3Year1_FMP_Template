using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [Range(1, 10)] public float moveSpeed;
    public GameObject playerPrefab;
    public bool spriteUsed;
    
    GameObject clone;
    CharacterController controller;
    Vector3 moveDirection;
    Camera mainCamera;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        clone = Instantiate(playerPrefab, transform.position, Quaternion.identity, this.transform);
        mainCamera = Camera.main;
    }

    
    void FixedUpdate()
    {
        Move();
    }

    void LateUpdate(){
        clone.transform.LookAt(mainCamera.transform);
        clone.transform.Rotate(0, 0, 0);
    }

    void Move(){
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        moveDirection = (moveHorizontal * transform.right + moveVertical * transform.forward);

        controller.Move(moveDirection * moveSpeed * Time.deltaTime);
    }
}
