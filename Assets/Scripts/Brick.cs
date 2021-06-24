using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour, IDamagable
{
    [SerializeField]
    private int health = 1;

    public void Damage(int damage)
    {
        health -= damage;

        if (health <= 0)
            DestroyBrick();        
    }

    private void DestroyBrick()
    {
        Destroy(gameObject);
    }
}
