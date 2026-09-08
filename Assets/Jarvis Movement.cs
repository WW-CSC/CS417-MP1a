using UnityEngine;

public class JarvisMovement : MonoBehaviour
{
    public float rotationSpeed = 15.0f;

    public GameObject jarvis;

    void Update()
    {
        jarvis.transform.Rotate(5f * Time.deltaTime, rotationSpeed * Time.deltaTime, 0f);
    }
}
