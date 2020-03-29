using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    float moveSpeed = 7f;
    public int damage = 20;

    Rigidbody2D rb;

    Player target;
    Vector2 moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindObjectOfType<Player>();
        moveDirection = (target.transform.position - transform.position).normalized * moveSpeed;
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
        Destroy(gameObject, 3f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player player = collision.GetComponent<Player>();
        if(collision.gameObject.name.Equals("Player"))
        {
            Destroy(gameObject);
            player.takeDamage(damage);
        }
        else if(collision.gameObject.name.Equals("TilemapBase"))
        {
            Destroy(gameObject);
        }
    }
}
