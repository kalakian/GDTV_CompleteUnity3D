using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10.0f;
    void Start()
    {
        PrintInstructions();
    }

    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Move your player with WASD or arrow keys");
        Debug.Log("Don't hit the walls");
    }

    void MovePlayer()
    {
        float xMove = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zMove = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xMove, 0, zMove);
    }
}
