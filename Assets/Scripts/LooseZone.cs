using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LooseZone : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision2D) 
    {
        if (collision2D.gameObject.CompareTag("Ball"))
        {
            Debug.Log("You loose!");
            Destroy(collision2D.gameObject);
        }
    }
}
