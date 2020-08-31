using UnityEngine;

namespace RPG.Combat
{
    [CreateAssetMenu(fileName = "Weapon", menuName = "Weapons/Make New Weapon", order = 0)]
    public class Weapon : ScriptableObject
    {
        [SerializeField] AnimatorOverrideController animatorOverride = null;
        [SerializeField] GameObject equippedPrefab = null;
        [SerializeField] float damage = 5f;
        [SerializeField] float range = 2f;

        public float Damage { get => damage; set => damage = value; }
        public float Range { get => range; set => range = value; }

        public void Spawn(Transform handTransform, Animator animator)
        {
            if(equippedPrefab != null)
            {
                Instantiate(equippedPrefab, handTransform);
            }
            if(animatorOverride != null)
            {
                animator.runtimeAnimatorController = animatorOverride;
            }
        }
    }
}