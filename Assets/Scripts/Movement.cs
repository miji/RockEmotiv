using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 impulse = new Vector3(0.0f, 5.0f, 0.0f);
    public float distance = 1;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.AddForce(impulse, ForceMode.Impulse);
        }
    }

    
}
