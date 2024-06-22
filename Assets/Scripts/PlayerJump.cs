using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    Vector2 jumpForce = new Vector2(0f, 3000f);
    bool isJumping = false;
    int jumpMaxNumber = 1;
    int jumpNumber = 0;
    Rigidbody2D rb;
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isJumping = true;
            jumpNumber++;
        }
    }

    private void FixedUpdate()
    {
        Jump();
    }

    void Jump()
    {
        if (isJumping && jumpNumber <= jumpMaxNumber)
        {
            rb.AddForce(jumpForce, ForceMode2D.Impulse);
        }

        if(Mathf.Abs(rb.velocity.y) < 0.001)
        {
          jumpNumber = 0;  
        }


        isJumping=false;
    }
}
