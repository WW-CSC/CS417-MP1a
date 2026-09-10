using UnityEngine;
using UnityEngine.EventSystems;

public class ObjectClick : MonoBehaviour, IPointerClickHandler
{
    public GameObject gameObject;
    public ParticleSystem particles;
    public AudioSource audio;

    public void OnPointerClick(PointerEventData eventData)
    {
        OnClick();
    }
    public void OnClick()
    {
        particles.transform.position = gameObject.transform.position;
        particles.Play();
        audio.transform.position = gameObject.transform.position;
        audio.Play();
    }
}
