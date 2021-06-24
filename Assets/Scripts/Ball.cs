using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Ball : MonoBehaviour
{
    [SerializeField]
    private int damage;

    private Rigidbody2D rb;

    private void Start() 
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(5f, 5f);
    }

    private void OnCollisionEnter2D(Collision2D collision2D) 
    {
        if (collision2D.gameObject.TryGetComponent<IDamagable>(out IDamagable damagable))
        {
            damagable.Damage(damage);
        }
    }
}
