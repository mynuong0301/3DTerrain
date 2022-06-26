using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : MonoBehaviour
{
    Rigidbody rb;
    Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        direction = new Vector3(-0.3f, 0, 0);
        
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + transform.TransformDirection(direction));
    }
}
