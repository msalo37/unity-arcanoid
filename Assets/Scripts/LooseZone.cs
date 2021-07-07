using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LooseZone : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision2D) 
    {
        Ball ball = collision2D.gameObject.GetComponent<Ball>();
        if (ball != null)
        {
            Debug.Log("You loose!");
            Destroy(ball.gameObject);
        }
    }
}
