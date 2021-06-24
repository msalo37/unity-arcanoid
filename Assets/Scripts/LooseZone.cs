using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LooseZone : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision2D) 
    {
        if (collision2D.gameObject.TryGetComponent<Ball>(out Ball ball))
        {
            Debug.Log("You loose!");
            Destroy(ball.gameObject);
        }
    }
}
