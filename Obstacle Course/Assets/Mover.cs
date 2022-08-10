using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10.0f;
    void Start()
    {
        
    }

    void Update()
    {
        float xMove = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zMove = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xMove , 0, zMove);
    }
}
