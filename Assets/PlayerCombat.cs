using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour



{
public Transform attackPoint;
public LayerMask enemyLayers;

public float attackRange = 3f;
public int attackDamage = 40;
    



      void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }
    }

    void Attack()
    {
        
       Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);



       foreach(Collider2D enemy in hitEnemies)
       {
            enemy.GetComponent<Enemy>().TakeDamage(attackDamage);
       }
    }


void OnDrawGizmosSelected()
{
    if (attackPoint == null)
        return;
    Gizmos.DrawWireSphere(attackPoint.position, attackRange);
}
}
