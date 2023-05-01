using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private float length;
    private float startPos;

    private Transform cam;

    public float ParallaxEffect;

    void Start()
    {
        startPos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
        cam = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        float Distance = cam.transform.position.x * ParallaxEffect;
        float rePos = cam.transform.position.x * (1 - ParallaxEffect);

        transform.position = new Vector3(startPos + Distance, transform.position.y, transform.position.z);

        if(rePos > startPos + length)
        {
            startPos += length;
        }
    }
}
