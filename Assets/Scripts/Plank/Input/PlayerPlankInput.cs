using UnityEngine;

namespace Plank.Input
{
    public class PlayerPlankInput : AbstractPlankInput
    {
        [SerializeField] private Transform plank;
        
        public override float GetHorizontalAxis()
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(UnityEngine.Input.mousePosition);
            Vector3 dir = (plank.position - mousePosition).normalized;

            return -dir.x;
        }
    }
}