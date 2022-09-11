using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sticky : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "player")
        {
            collision.gameObject.transform.SetParent(transform);
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        collision.gameObject.transform.SetParent(null);
    }
}
