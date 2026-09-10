using UnityEngine.InputSystem;
using UnityEngine;

public class Lightchangebehavoir : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Light roomLight;
    public InputActionReference buttonPressed;
    private float currentcolor = 0.0f;
    private float cycleSpeed = 0.2f;
    private bool onOff = false;

    void Start()
    {
        buttonPressed.action.Enable();
        buttonPressed.action.performed += Onclick;
    }

    // Update is called once per frame
    void Update()
    {
        if(onOff)
        {
            currentcolor = (currentcolor + cycleSpeed * Time.deltaTime) % 1.0f;
            roomLight.color = Color.HSVToRGB(currentcolor, 0.85f, 1.0f);
        }
        else
        {
            roomLight.color = Color.white;
        }
    }
     
    void Onclick(InputAction.CallbackContext context)
    {
        onOff = !onOff;
    }


}
