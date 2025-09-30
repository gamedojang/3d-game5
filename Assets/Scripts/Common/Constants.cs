using UnityEngine;

public static class Constants
{
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
    
}