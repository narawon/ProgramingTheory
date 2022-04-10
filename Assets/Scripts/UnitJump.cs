using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitJump : BaseUnit
{
    private float yLimit = 5;
    

    // Start is called before the first frame update
    public override void Start()
    {
        Name = "Jumping";
        Speed = 6;

    }
    public override void Move()
    {
        
        ChangeDirection(transform.position.y, 0, yLimit);
        transform.position += Vector3.up * Speed * Direction * Time.deltaTime;
        
        base.Move();
    }
}
