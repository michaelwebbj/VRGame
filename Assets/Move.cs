using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 0f;

    // Start is called before the first frame update
    void Start()
    {
        speed = 0.010f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed, 0, 0);
    }
}
