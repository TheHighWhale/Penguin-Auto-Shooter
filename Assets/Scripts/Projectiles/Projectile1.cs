using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile1 : MonoBehaviour
{
    public float speed = 10f;
    public float damage = 50f;

    private Vector2 direction;

    public void Seek(Vector2 _direction)
    {
        direction = _direction;
    }

    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if (collision.CompareTag("Enemy"))
       // {
        //    enemy1Stats = collision.gameObject.GetComponent<Enemy1Stats>();
         //   if (enemy1Stats != null) // Check if the component exists
         //   {
         //       enemy1Stats.health -= damage;
         ////       Destroy(gameObject);
          //  }
       // }
    }
}
