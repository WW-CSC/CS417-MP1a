using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ObjectClick : MonoBehaviour
{
    private UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable interactable;
    public GameObject gameObject;
    public ParticleSystem particles;
    public AudioSource audio;

    
    public void Awake()
    {
	interactable = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable>();
    }

    public void OnEnable()
    {
        interactable.activated.AddListener(OnTriggerPressed);
    }

    public void OnDisable()
    {
       interactable.activated.RemoveListener(OnTriggerPressed);
    }

    public void OnTriggerPressed(BaseInteractionEventArgs args)
    {
        OnClick();
    }
    private void OnClick()
    {
        particles.transform.position = gameObject.transform.position;
        particles.Play();
        audio.transform.position = gameObject.transform.position;
        audio.Play();
    }
}
