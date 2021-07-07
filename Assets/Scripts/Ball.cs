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
        IDamagable damageable = collision2D.gameObject.GetComponent<IDamagable>();
        if (damageable != null)
        {
            damageable.Damage(damage);
        }
    }
}
