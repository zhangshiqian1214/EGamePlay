﻿using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using EGamePlay.Combat;
using ET;
using Log = EGamePlay.Log;

namespace EGamePlay.Combat
{
    public class SkillExecutionData
    {
#if !NOT_UNITY
        public GameObject SkillExecutionAsset { get; set; }
#endif
        public float SkillExecuteTime { get; set; }
        public List<Effect> ExecutionEffects { get; set; } = new List<Effect>();
    }

    /// <summary>
    /// 技能执行体，执行体就是控制角色表现和技能表现的，包括角色动作、移动、变身等表现的，以及技能生成碰撞体等表现
    /// </summary>
    [EnableUpdate]
    public partial class SkillExecution : AbilityExecution
    {
        public SkillAbility SkillAbility { get { return AbilityEntity as SkillAbility; } }
        public List<CombatEntity> SkillTargets { get; set; } = new List<CombatEntity>();
        public CombatEntity InputTarget { get; set; }
        public Vector3 InputPoint { get; set; }
        public float InputDirection { get; set; }
        public long OriginTime { get; set; }
    }
}