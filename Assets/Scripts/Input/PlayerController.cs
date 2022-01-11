using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    float vertic;
    float horiz;
    float jump;
    Vector3 directionMove;

    [Header("Movement")]
    [SerializeField] float speed;
    [SerializeField] float jumpForce;
    [SerializeField] float dragGrounded;
    [SerializeField] float dragAir;
    bool isOnGround = true;

    Rigidbody rb;
    

    public void OnMove(float horiz,float vertic)
    {
        this.horiz = horiz;
        this.vertic = vertic;
    }
    public void OnLook(float xLook,float yLook)
    {
        //CameraController recive inputs for  now.
    }
    public void OnJump(float jump)
    {
        this.jump = jump;
    }
    private void DragControl()
    {
        if(isOnGround)
        {
            rb.drag = dragGrounded;
        }
        else
        {
            rb.drag = dragAir;
        }
       
    }
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }
    void Move()
    {
        directionMove = (transform.forward * vertic + transform.right * horiz).normalized;
        rb.AddForce(directionMove * speed, ForceMode.Acceleration);
        
    }
    void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce * jump, ForceMode.Impulse);
    }
    private void FixedUpdate()
    {
        Move();
        Jump();
    }
    private void Update()
    {
        DragControl();
    }
}
