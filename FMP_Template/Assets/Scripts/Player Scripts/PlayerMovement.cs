using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Variables you can change")]
    public float moveSpeed; //The speed of the player
    [Tooltip("The player object you want to use, can be 2D or 3D")] public GameObject playerPrefab; //player object
    [Tooltip("if you are using a 2D sprite, tick this box!")] public bool spriteUsed; //bool for if a sprite is being used. 
    
    GameObject clone; //an object to hold the player object so it is not effected by the movement code. 
    Rigidbody rb; //rigidbody of player
    Vector3 moveDirection; //movement vector
    Camera mainCamera; //camera

    void Start()
    {
        rb = GetComponent<Rigidbody>(); //assign Rigidbody from object. 
        clone = Instantiate(playerPrefab, transform.position, Quaternion.identity, this.transform); //spawn in the player object
        mainCamera = Camera.main; //assign the camera
    }

    void FixedUpdate()
    {
        Move();
    }

    void LateUpdate(){
        //Creates a billboarding effect for if you are using a 2D sprite. 
        if(spriteUsed == true){
            clone.transform.LookAt(mainCamera.transform);
            clone.transform.Rotate(0, 0, 0);
        }
    }

    void Move(){
        float moveHorizontal = Input.GetAxisRaw("Horizontal"); //Left and right movement
        float moveVertical = Input.GetAxisRaw("Vertical"); //forwards and backwards
        moveDirection = (moveHorizontal * transform.right + moveVertical * transform.forward); //sets the movement vector to the inputs
        rb.MovePosition(transform.position + moveDirection * moveSpeed * Time.deltaTime); //moves the rigidbody according to inputs. 
    }
}
