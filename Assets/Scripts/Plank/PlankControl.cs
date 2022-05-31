using Plank.Input;
using UnityEngine;

namespace Plank
{
    public class PlankControl : MonoBehaviour
    {
        [SerializeField] private float speed = 15f;
        [SerializeField] private Transform plank;
        [SerializeField] private AbstractPlankInput plankInput;
        
        private void Update()
        {
            Vector2 moveDirection = new Vector2(plankInput.GetHorizontalAxis(), 0);
            plank.Translate(moveDirection * speed * Time.deltaTime);
        }
    }
}
