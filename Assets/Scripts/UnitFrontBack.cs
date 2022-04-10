using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitFrontBack : BaseUnit
{
    private static float zLimit = 10;
    

    // Start is called before the first frame update
    public override void Start()
    {
        Speed = 10;
        Name = "Forward Backward";
        
    }

    // Update is called once per frame
    public override void Update()
    {
        Move();
        base.Update();
    }

    public override void Move()
    {
        
        ChangeDirection(transform.position.z, -zLimit, zLimit);

        transform.position += Vector3.forward * Speed * Time.deltaTime * Direction;
        base.Move();
    }
}
