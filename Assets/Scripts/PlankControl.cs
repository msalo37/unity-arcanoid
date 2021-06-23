using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlankControl : MonoBehaviour
{
    [SerializeField]
    private float speed = 15f;

    [SerializeField]
    private Transform plank;

    private void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 destination = new Vector2(mousePosition.x, plank.position.y);
        plank.position = Vector2.Lerp(plank.position, destination, speed * Time.deltaTime);
    }
}