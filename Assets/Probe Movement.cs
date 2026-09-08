using UnityEngine;

public class ProbeMovement : MonoBehaviour
{
    public GameObject probe;
    public GameObject jarvis;
    public Vector3 velocity;
    public float gravity = 3.0f;
    public Vector3 orbitNormal = Vector3.up;

    void Start()
    {

        Vector3 offset = probe.transform.position - jarvis.transform.position;
        float circularSpeed = Mathf.Sqrt(gravity / offset.magnitude);
        Vector3 tangentDirection = Vector3.Cross(offset, orbitNormal).normalized;
        velocity = tangentDirection * circularSpeed;
    
    }

    void Update()
    { 

        Vector3 offset = probe.transform.position - jarvis.transform.position;
        float distance = offset.magnitude;
        
        Vector3 acceleration = -gravity * offset / Mathf.Pow(distance, 3);
        velocity += acceleration * Time.deltaTime;
        probe.transform.position += velocity * Time.deltaTime;
    }
}