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

    [Header("Ground Detection")]
    [SerializeField] LayerMask groundLayer;
    [SerializeField] float groundDistance = 0.4f;
    bool isOnGround;

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
   

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }


    private void DragControl()
    {
        if (isOnGround)
        {
            rb.drag = dragGrounded;
        }
        else
        {
            rb.drag = dragAir;
        }
    }
    void Move()
    {
        directionMove = (transform.forward * vertic + transform.right * horiz).normalized;
        rb.AddForce(directionMove * speed, ForceMode.Acceleration);
    }
    void Jump()
    {
        if (isOnGround)
        {
            rb.AddForce(Vector3.up * jumpForce * jump, ForceMode.Impulse);
        }
    }
    private void FixedUpdate()
    {
        Move();
        Jump();
    }


    private void Update()
    {
        isOnGround = Physics.CheckSphere(transform.position , groundDistance, groundLayer);
        DragControl();
    }
}
