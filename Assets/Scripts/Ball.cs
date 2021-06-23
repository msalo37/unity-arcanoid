using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Ball : MonoBehaviour
{
    private Rigidbody2D rb;
    private void Start() {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(Random.Range(-5f, 5f), 0);
    }
}
