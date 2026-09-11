using UnityEngine;
using UnityEngine.InputSystem;

public class TeleportPlayer : MonoBehaviour
{
    public Transform playerOrigin;
    public Transform insideLocation;
    public Transform outsideLocation;
  

    public InputActionProperty toggleButtonAction;

    private bool isOutside = false;

    private void OnEnable()
    {
        toggleButtonAction.action.Enable();
        toggleButtonAction.action.performed += OnButtonPressed;
    }

    private void OnDisable()
    {
        toggleButtonAction.action.performed -= OnButtonPressed;
        toggleButtonAction.action.Disable();
    }

    private void OnButtonPressed(InputAction.CallbackContext context)
    {
        ToggleLocation();
    }

    public void ToggleLocation()
    {

        if (isOutside)
        {
            playerOrigin.position = insideLocation.position;
            isOutside = false;
        }
        else
        {
            playerOrigin.position = outsideLocation.position;
            isOutside = true;
        }
    }
}