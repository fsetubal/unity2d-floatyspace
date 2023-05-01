using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMovement : MonoBehaviour
{
    [SerializeField][Range(0, 2)] private float velocity;

    private enum Direction { UP, DOWN}

    private Direction actualDirection;

    void Start()
    {
        int initialDirection = Random.Range(0, 2);

        if(initialDirection == 0)
        {
            actualDirection = Direction.UP;
        }
        else
        {
            actualDirection = Direction.DOWN;
        }
    }

    
    void Update()
    {
        switch (actualDirection)
        {
            case Direction.UP:
                transform.position += new Vector3(0, Time.deltaTime * velocity, 0);

                if(transform.position.y >= 6)
                {
                    actualDirection = Direction.DOWN;
                }
                break;

            case Direction.DOWN:
                transform.position -= new Vector3(0, Time.deltaTime * velocity, 0);

                if (transform.position.y <= -6)
                {
                    actualDirection = Direction.UP;
                }
                break;
        }
    }
}