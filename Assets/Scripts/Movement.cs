using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 impulse = new Vector3(0.0f, 5.0f, 0.0f);
    public float distance = 1;
    public float repeat = 0.1f;
    public bool autoImpulse = false;
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
            AddImpulseToRock();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            if (!autoImpulse)
            {
                InvokeRepeating("AddImpulseToRock", 0, repeat);
                autoImpulse = true;
            }
            else
            {
                CancelInvoke("AddImpulseToRock");
                autoImpulse = false;
            }
                
        }

    }


    void AddImpulseToRock()
    {
        rb.AddForce(impulse, ForceMode.Impulse);
    }

    
}
