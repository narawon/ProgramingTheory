using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitJump : BaseUnit
{
    private float yLimit = 5;
    private float direction = 1;

    // Start is called before the first frame update
    public override void Start()
    {
        Name = "Jumping";
        Speed = 6;

    }
    public override void Move()
    {
        if (transform.position.y > yLimit)
        {
            direction = -1;
        }
        else if (transform.position.y < 0)
        {
            direction = 1;
        }
        transform.position += Vector3.up * Speed * direction * Time.deltaTime;
        
        base.Move();
    }
}
