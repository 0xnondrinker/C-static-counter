using UnityEngine;
using UnityEngine.Serialization;

namespace CodeBase.StaticData
{
    [CreateAssetMenu(fileName = "MonsterData", menuName = "StaticData/Monster")]
    public class MonsterStaticData : ScriptableObject
    {
        public MonsterTypeId MonsterTypeId;
        
        [Range(1, 100)]
        public int Hp;
        
        [Range(1, 30)]
        public float Damage;
        
        [Range(1, 10)]
        public float AttackCooldown;
        
        [Range(0.5f, 1)]
        public float Cleavage;
        
        [Range(0.5f, 1)]
        public float EffectiveDistance;
        
        [Range(1, 20)]
        public float MoveSpeed;

        public int MaxLoot;
        public int MinLoot;
        
        public GameObject Prefab;
    }
}