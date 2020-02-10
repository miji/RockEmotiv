using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public Transform target;
    public float distance = 1f;
    private float offset_x, offset_z;
    // Start is called before the first frame update
    void Start()
    {
        offset_x = transform.position.x - target.transform.position.x;
        offset_z = transform.position.z - target.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);
    }

    private void FixedUpdate()
    {
        transform.position = new Vector3(target.transform.position.x + offset_x, transform.position.y, target.transform.position.z + offset_z);
    }
}
