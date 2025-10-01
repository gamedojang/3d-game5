

using UnityEngine;
using UnityEngine.InputSystem;
using static Constants;

public class PlayerStateIdle: PlayerState, ICharacterState
{
    public PlayerStateIdle(PlayerController playerController, Animator animator, PlayerInput playerInput) 
        : base(playerController, animator, playerInput) { }

    public void Enter()
    {
        // Idle 애니메이션 실행
        _animator.SetBool(PlayerAniParamIdle, true);
        
        // Player Input에 대한 액션 할당
        _playerInput.actions["Fire"].performed += Attack;
        _playerInput.actions["Jump"].performed += Jump;
    }

    public void Update()
    {
        if (_playerInput.actions["Move"].IsPressed())
        {
            _playerController.SetState(EPlayerState.Move);
        }
    }

    public void Exit()
    {
        // Idle 애니메이션 중단
        _animator.SetBool(PlayerAniParamIdle, false);
        
        // Player Input에 대한 액션 할당 해제
        _playerInput.actions["Fire"].performed -= Attack;
        _playerInput.actions["Jump"].performed -= Jump;
    }
}