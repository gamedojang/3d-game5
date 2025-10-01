using UnityEngine;
using UnityEngine.InputSystem;
using static Constants;

public class PlayerStateAttack: PlayerState, IPlayerState
{
    public PlayerStateAttack(PlayerController playerController, Animator animator, PlayerInput playerInput) 
        : base(playerController, animator, playerInput) { }

    public void Enter()
    {
        _animator.SetTrigger(PlayerAniParamAttack);
        _playerInput.actions["Fire"].performed += AttackTrigger;
    }

    public void Update() { }

    public void Exit()
    {
        _playerInput.actions["Fire"].performed -= AttackTrigger;
    }

    private void AttackTrigger(InputAction.CallbackContext context)
    {
        _animator.SetTrigger(PlayerAniParamAttack);
    }
}