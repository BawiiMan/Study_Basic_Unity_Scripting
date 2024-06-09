using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumScript : MonoBehaviour
{
    enum Direction { North, East, South, West };
    private void Start()
    {
        Direction myDirection;
        myDirection = Direction.West;
        myDirection = ReverseDirection(myDirection);
        Debug.Log(myDirection);
    }

    Direction ReverseDirection(Direction dir)
    {
        if (dir == Direction.North)
        {
            dir = Direction.South;
            //Debug.Log(dir);
        }
        else if (dir == Direction.South)
            dir = Direction.North;
        else if (dir == Direction.East)
            dir = Direction.West;
        else if (dir == Direction.West)
            dir = Direction.East;

        return dir;
    }
}
