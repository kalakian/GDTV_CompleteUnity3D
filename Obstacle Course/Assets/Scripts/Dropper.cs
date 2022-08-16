using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 3;

    new MeshRenderer renderer;
    new Rigidbody rigidbody;

    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();

        renderer.enabled = false;
        rigidbody.useGravity = false;
    }

    void Update()
    {
        if (Time.time > timeToWait)
        {
            renderer.enabled = true;
            rigidbody.useGravity = true;
        }
    }
}
