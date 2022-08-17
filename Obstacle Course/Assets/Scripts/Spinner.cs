using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] Vector3 rotateAmount = Vector3.zero;

    void Update()
    {
        transform.Rotate(rotateAmount * Time.deltaTime);
    }
}
