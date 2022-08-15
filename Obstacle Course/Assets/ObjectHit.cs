using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Bumped into a wall");
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
}
