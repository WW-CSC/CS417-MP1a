using UnityEngine;
using UnityEngine.InputSystem;
using Unity.XR.CoreUtils;

public class CameraSwapToggle : MonoBehaviour
{
    public XROrigin xrOrigin;
    public Camera externalCamera;
    public InputActionReference trigger;

    private Camera mainXRCamera;
    private bool isExternalActive = false;

    private void Start()
    {
        mainXRCamera = xrOrigin.Camera;
        mainXRCamera.enabled = true;
        externalCamera.enabled = false;
    }

    private void OnEnable()
    {
        trigger.action.Enable();
        trigger.action.performed += OnClick;
    }

    private void OnDisable()
    {
        trigger.action.performed -= OnClick;
    }

    public void OnClick(InputAction.CallbackContext context)
    {
        isExternalActive = !isExternalActive;
        mainXRCamera.enabled = isExternalActive;
        externalCamera.enabled = !isExternalActive;
    }
}