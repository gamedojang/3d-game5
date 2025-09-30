using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 50f;
    [SerializeField] private float distance = 3f;

    private Transform _target;
    private Vector2 _lookVector;
    
    private float _azimuthAngle;
    private float _polarAngle;

    private void Awake()
    {
        _azimuthAngle = 0f;
        _polarAngle = 0f;
    }

    private void LateUpdate()
    {
        if (_target != null)
        {
            // 마우스 x, y 값을 이용해 카메라 이동
            _azimuthAngle += _lookVector.x * rotationSpeed * Time.deltaTime;
            _polarAngle -= _lookVector.y * rotationSpeed * Time.deltaTime;
            _polarAngle = Mathf.Clamp(_polarAngle, -20f, 60f);
            
            var cartesianPosition = GetCameraPosition(distance, _polarAngle, _azimuthAngle);
            transform.position = _target.position + cartesianPosition;
            transform.LookAt(_target);
        }
    }

    public void SetTarget(Transform target, PlayerInput playerInput)
    {
        _target = target;
        
        // 카메라 초기 위치 설정
        var cartesianPosition = GetCameraPosition(distance, _polarAngle, _azimuthAngle);
        transform.position = _target.position + cartesianPosition;
        transform.LookAt(_target);

        // 마우스 이동
        playerInput.actions["Look"].performed += OnActionLook;
        playerInput.actions["Look"].canceled += OnActionLook;
    }
    
    private void OnActionLook(InputAction.CallbackContext context)
    {
        _lookVector = context.ReadValue<Vector2>();
    }

    private Vector3 GetCameraPosition(float r, float polarAngle, float azimuthAngle)
    {
        float b = r * Mathf.Cos(polarAngle * Mathf.Deg2Rad);
        float x = b * Mathf.Sin(azimuthAngle * Mathf.Deg2Rad);
        float y = r * Mathf.Sin(polarAngle * Mathf.Deg2Rad);
        float z = b * Mathf.Cos(azimuthAngle * Mathf.Deg2Rad);
        
        return new Vector3(x, y, z);
    }
}
