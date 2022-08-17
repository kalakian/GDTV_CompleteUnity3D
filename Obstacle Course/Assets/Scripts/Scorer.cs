using UnityEngine;

public class Scorer : MonoBehaviour
{
    int timesBumped = 0;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Hit")
        {
            timesBumped++;

            Debug.Log("You've bumped into a thing this many times: " + timesBumped);
        }
    }
}
