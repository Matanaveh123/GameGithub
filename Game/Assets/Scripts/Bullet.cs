using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 20;
    public Rigidbody2D rb;

    void Start()
    {
        rb.velocity = transform.right * speed;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<Target>())
        {
            collision.GetComponent<Target>().TakeDamage(damage);
        }

        if (collision.gameObject.layer == 9 || collision.GetComponent<Target>())
        {
            Destroy(gameObject);
        }
    }

}
