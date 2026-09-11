using UnityEngine;

public class Clickedon : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject gameObject;
    public ParticleSystem particles;
    public AudioSource audio;

    public void OnClick()
    {
        particles.transform.position = gameObject.transform.position;
        particles.Play();
        audio.transform.position = gameObject.transform.position;
        audio.Play();
    }

}
