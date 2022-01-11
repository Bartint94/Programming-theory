using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float vertic;
    float horiz;

    [SerializeField] GameObject gun;
    [SerializeField] GameObject cam;
    [SerializeField] float speed;

    Rigidbody rb;
    Vector3 directionMove;

    public void OnMove(float horiz,float vertic)
    {
        this.horiz = horiz;
        this.vertic = vertic;
    }
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }
    void Move()
    {
        directionMove = (cam.transform.forward * vertic + cam.transform.right * horiz).normalized;
        rb.AddForce(directionMove * speed, ForceMode.Acceleration);
        transform.rotation = cam.transform.rotation;
    }
    private void FixedUpdate()
    {
        Move();
    }
}
