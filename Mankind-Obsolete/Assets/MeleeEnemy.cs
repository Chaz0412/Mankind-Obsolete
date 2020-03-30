using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeEnemy : MonoBehaviour
{
    Animator animator;
    public float attackRange;
    public int dmg;
    private float lastAttack;
    public float attackDelay;
    public Transform target;
    Player player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, target.position);
        if(distance < attackRange)
        {
                //animator.SetTrigger("Attack");
                //player.takeDamage(dmg);
                Debug.Log("hit");
                lastAttack = Time.time;
        }
    }
}
