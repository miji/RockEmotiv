using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tobii.Gaming;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
	public GazeAware ga;
    public Vector3 impulse = new Vector3(0.0f, 5.0f, 0.0f);
    public float distance = 1;
    public float repeat = 0.1f;
    public bool autoImpulse = false;
    public float height;
    public Text heightText;

    private float _initialHeight;

    // Start is called before the first frame update

    void Start()
    {
        _initialHeight = 1.42696f;
    }

    // Update is called once per frame
    void Update()
    {
		if (ga.HasGazeFocus)
		{
			if (!autoImpulse)
            {
                InvokeRepeating("AddImpulseToRock", 0, repeat);
                autoImpulse = true;
            }
		}
		else
		{
			if (autoImpulse)
			{
				CancelInvoke("AddImpulseToRock");
                autoImpulse = false;
			}
		}

        height = transform.position.y - _initialHeight;
        heightText.text = height.ToString();
    }


    void AddImpulseToRock()
    {
        rb.AddForce(impulse, ForceMode.Impulse);
    }

    
}
