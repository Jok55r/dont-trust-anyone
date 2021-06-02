using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //public GameObject PlayerIdle;
    public GameObject PlayerWalk;
    public Rigidbody2D rb;
    public float move = 0f;
    public float speed = 20f;
    public float jump = 0f;
    public BoxCollider2D CheckingGround;
    public bool isOnGround;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        move = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow) && isOnGround)
        {
            rb.velocity = new Vector2(rb.velocity.y, jump);
        }
    }

    void FixedUpdate()
    {
        Vector3 left = new Vector3(-3, 3, 1);
        Vector3 right = new Vector3(3, 3, 1);
        rb.velocity = new Vector2(move * speed, rb.velocity.y);
        if (move < 0) PlayerWalk.transform.localScale = left;
        if (move > 0) PlayerWalk.transform.localScale = right;

        if (CheckingGround = null) isOnGround = false;
        else isOnGround = true;
    }
}