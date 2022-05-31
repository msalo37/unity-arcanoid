using Damage;
using UnityEngine;

namespace Brick
{
    public class BrickColorChanger : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer spriteRenderer;
        [SerializeField] private DamageableObject damageableObject;

        private int _maxHealth;
        
        private void Awake()
        {
            _maxHealth = damageableObject.GetHealth();
            damageableObject.OnDamaged.AddListener(ChangeColor);
            ChangeColor();
        }

        private void ChangeColor()
        {
            spriteRenderer.color = CalculateColor(damageableObject.GetHealth(), _maxHealth);
        }
        
        private Color32 CalculateColor(float current, float max)
        {
            return new Color(Mathf.Clamp((1 - current / max), 0, 1), Mathf.Clamp((current / max), 0, 1), 0, 0.5f);;
        }
    }
}