using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour
{
    [SerializeField] int maxHP = 10;
    int hp;
    void Start()
    {
        hp = maxHP;
    }

    public void TakeDamage(int damage)
    {
        hp -= damage;
        if(hp <=0)
        {
            Destroy (gameObject);
        }
    }
}
