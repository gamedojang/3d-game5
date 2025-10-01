using UnityEngine;

public static class Constants
{
    public const float Gravity = -9.81f;
    
    // ----------------------------------------
    // Layer Mask
    public static LayerMask GroundLayerMask => LayerMask.GetMask("Ground");
    
    // ----------------------------------------
    // Player 상태
    public enum EPlayerState
    {
        None, Idle, Move, Jump, Attack, Hit, Dead
    }
    // ----------------------------------------
    // Player 애니메이터 파라미터
    public static readonly int PlayerAniParamIdle = Animator.StringToHash("idle");
    public static readonly int PlayerAniParamMove = Animator.StringToHash("move");
    public static readonly int PlayerAniParamJump = Animator.StringToHash("jump");
    public static readonly int PlayerAniParamAttack = Animator.StringToHash("attack");
    public static readonly int PlayerAniParamMoveSpeed = Animator.StringToHash("move_speed");
    public static readonly int PlayerAniParamGroundDistance = Animator.StringToHash("ground_distance");
    
    // ----------------------------------------
    // Enemy 상태
    public enum EEnemyState
    {
        None, Idle, Patrol, Chase, Attack, Hit, Dead
    }
    
    // ----------------------------------------
    // Enemy 애니메이터 파라미터
    public static readonly int EnemyAniParamIdle = Animator.StringToHash("idle");
    public static readonly int EnemyAniParamPatrol = Animator.StringToHash("patrol");
    public static readonly int EnemyAniParamChase = Animator.StringToHash("chase");
    public static readonly int EnemyAniParamAttack = Animator.StringToHash("attack");
    public static readonly int EnemyAniParamHit = Animator.StringToHash("hit");
    public static readonly int EnemyAniParamDead = Animator.StringToHash("dead");
    public static readonly int EnemyAniParamMoveSpeed = Animator.StringToHash("move_speed");
}