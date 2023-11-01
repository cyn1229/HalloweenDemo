using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatFly : MonoBehaviour
{
    private Vector3 origPos;

    private float elapse;

    public float Interval = 0.05f;

    public float Range = 0.05f;
    // Start is called before the first frame update
    void Start()
    {
        origPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
