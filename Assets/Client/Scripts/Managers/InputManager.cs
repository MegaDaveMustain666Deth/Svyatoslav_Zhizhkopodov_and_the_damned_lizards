using UnityEngine.InputSystem;
using UnityEngine;

public class InputManager : PersistentSingleton<InputManager>
{
    public float i;
    private PlayerInput _playerInput;

    public void Initialization()
    {
        _playerInput = new PlayerInput();
    } 

    private void OnEnable()
    {
        _playerInput.Enable();    
    }

    private void OnDisable()
    {
        _playerInput.Disable();    
    }

    private void setDirection(float Value)
    {
        i = Value;
    }

    private void Update() 
    {
       i = _playerInput.Player.Move.ReadValue<float>();   
    }
}
