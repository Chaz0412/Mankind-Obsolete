using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeEnemy : MonoBehaviour
{
    public Animator animator;
    public float attackRange;
    public int dmg;
    private float lastAttack;
    public float attackDelay;
    public Transform target;
    public Player player;
    private Vector3 position;

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, target.position);
        if(distance < attackRange)
        {
            if (Time.time > lastAttack + attackDelay)
            {
                animator.Play("MeleeAttack");
                player.takeDamage(dmg);
                lastAttack = Time.time;
            }
        }
    }
}
