using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ObjectShooter : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
	public GameObject gameObject;
	public Transform spawnpoint;
	private UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable interactable;
    private void Awake()
    {
        interactable = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRSimpleInteractable>();
    }

    
    private void OnEnable()
    {
        interactable.activated.AddListener(OnTriggerPressed);
    }

    private void OnDisable()
    {
        interactable.activated.RemoveListener(OnTriggerPressed);
    }

    private void OnTriggerPressed(BaseInteractionEventArgs args)
    {
        Shoot();
    }
    private void Shoot()
    {
        GameObject spawned = Instantiate(gameObject, spawnpoint.position, spawnpoint.rotation);
	projectileMoveemnt movement = spawned.GetComponent<projectileMoveemnt>();
	movement.velocity = spawnpoint.forward * 5;
    }



}
