using Damage.Inteface;
using UnityEngine;
using UnityEngine.Events;

namespace Damage
{
    public class DamageableObject : MonoBehaviour, IDamageable
    {
        [SerializeField] private int health;

        public UnityEvent OnDamaged;
        public UnityEvent OnDeath;
        
        public void Damage(int damage)
        {
            health -= damage;
            OnDamaged?.Invoke();

            if (health > 0) return;
            OnDeath?.Invoke();
            DestroyMe();
        }

        private void DestroyMe()
        {
            gameObject.SetActive(false);
        }
        
        public int GetHealth()
        {
            return health;
        }
    }
}