using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float speed = 5f;

   // [SerializeField] Transform groundcheck;
   // [SerializeField] LayerMask ground;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizortialNo = Input.GetAxis("Horizontal");
        float verticalNo = Input.GetAxis("Vertical");
        rb.velocity = new Vector3(horizortialNo * speed, rb.velocity.y, verticalNo * speed);
        

    }
    
}
