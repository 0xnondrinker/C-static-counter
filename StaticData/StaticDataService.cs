using System.Collections.Generic;
using System.Linq;
using CodeBase.Infrastructure.Services;
using UnityEngine;

namespace CodeBase.StaticData
{
    public class StaticDataService : IStaticDataService
    {
        private Dictionary<MonsterTypeId,MonsterStaticData> _monsters;
        private Dictionary<string,LevelStaticData> _levels;

        public void LoadMonsters()
        {
            _monsters = Resources.LoadAll<MonsterStaticData>("StaticData/Monster")
                .ToDictionary(x => x.MonsterTypeId, x => x);
            
            _levels = Resources.LoadAll<LevelStaticData>("StaticData/level")
                .ToDictionary(x => x.LevelKey, x => x);
        }

        public MonsterStaticData ForMonster(MonsterTypeId typeId) =>
            _monsters.TryGetValue(typeId, out MonsterStaticData staticData)
                ? staticData
                : null;

        public LevelStaticData ForLevel(string sceneKey) =>
            _levels.TryGetValue(sceneKey, out LevelStaticData staticData) 
                ? staticData 
                : null;
    }
}