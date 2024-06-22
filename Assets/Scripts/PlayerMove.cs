using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    float dirX;
    float speedX = 10f;
    Rigidbody2D rb;
    void Awake ()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        dirX = Input. GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2 (dirX*speedX, rb.velocity.y);
    }
}
