using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMovement : MonoBehaviour
{
    [SerializeField][Range(0, 2)] private float velocity;
    

    
    void Update()
    {
        if(transform.position.x >= -6)
        {
            transform.position -= new Vector3(Time.deltaTime * velocity, 0, 0);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
