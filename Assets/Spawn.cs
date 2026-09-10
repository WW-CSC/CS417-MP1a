using UnityEngine;
using UnityEngine.InputSystem;

public class Spawn : MonoBehaviour
{
    public GameObject jarvis, probe;
    public GameObject menu;
    public InputActionReference action;
    public ParticleSystem spawnParticles;
    public AudioSource spawnAudio;
    public bool currentview = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        menu.SetActive(false);
        jarvis.SetActive(false);
        probe.SetActive(false);
        action.action.Enable();
        action.action.performed += (ctx) => ChangeViewJarvis();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeViewJarvis()
    {
        if(currentview == false)
        {
            jarvis.SetActive(true);
            probe.SetActive(true);
            spawnParticles.transform.position = jarvis.transform.position;
            spawnAudio.transform.position = jarvis.transform.position;
            spawnParticles.Play();
            spawnAudio.Play();
            currentview = true;
        }
        else
        {
            jarvis.SetActive(false);
            probe.SetActive(false);
            currentview = false;
        }
    }
}
