using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour, IDamagable
{
    private int maxHealth;
    private SpriteRenderer _spriteRenderer;
    
    [SerializeField]
    private int health = 1;

    private void Awake()
    {
        maxHealth = health;
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _spriteRenderer.color = CalculateColor(health, maxHealth);
    }

    public void Damage(int damage)
    {
        health -= damage;

        _spriteRenderer.color = CalculateColor(health, maxHealth);
        
        if (health <= 0)
            DestroyBrick();        
    }

    private void DestroyBrick()
    {
        Destroy(gameObject);
    }
    
    public int GetHealth()
    {
        return health;
    }
    
    private Color32 CalculateColor(float current, float max)
    {
        return new Color(Mathf.Clamp((1 - current / max), 0, 1), Mathf.Clamp((current / max), 0, 1), 0, 0.5f);;
    }
}
