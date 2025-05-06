using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackgroundX : MonoBehaviour
{
 
    private Vector3 startPos;
    public float repeat;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < startPos.x - repeat)
        {
            transform.position = startPos;
        }
    }
}

 



