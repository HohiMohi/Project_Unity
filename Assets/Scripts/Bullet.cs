using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float speed = 50f;
    [SerializeField] int attack = 1;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
        Destroy(gameObject, 2f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        HP hp = collision.gameObject.GetComponent<HP>();
        if(hp != null)
        {
                hp.TakeDamage(attack);
        }


        Destroy(gameObject);
    }
}
