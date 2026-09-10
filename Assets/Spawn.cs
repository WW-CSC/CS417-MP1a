using UnityEngine;
using UnityEngine.InputSystem;

public class Spawn : MonoBehaviour
{
    public GameObject jarvis, probe;
    public GameObject menu;
    public InputActionReference action1, action2;
    public ParticleSystem spawnParticles;
    public AudioSource spawnAudio;
    public bool currentview = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        menu.SetActive(false);
        jarvis.SetActive(false);
        probe.SetActive(false);
        action1.action.Enable();
        action1.action.performed += (ctx) => ChangeViewJarvis();
	action2.action.Enable();
        action2.action.performed += (ctx) => LoadMenu();
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
    public void LoadMenu()
    {
	menu.SetActive(!menu.activeSelf);
    }
}
