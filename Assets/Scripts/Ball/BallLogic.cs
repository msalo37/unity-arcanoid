using Damage.Inteface;
using UnityEngine;

namespace Ball
{
    public class BallLogic : MonoBehaviour
    {
        [SerializeField] private int damageDeal;
        [SerializeField] private Rigidbody2D rb;
    
        private void Start() 
        {
            rb.velocity = new Vector2(5f, 5f);
        }
    
        private void OnCollisionEnter2D(Collision2D collision2D) 
        {
            IDamageable damageable = collision2D.gameObject.GetComponent<IDamageable>();
            damageable?.Damage(damageDeal);
        }
    }
}

