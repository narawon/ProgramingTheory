using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitFrontBack : BaseUnit
{
    private static float zLimit = 10;
    private static float direction = 1;

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
        if (transform.position.z > zLimit)
        {
            direction = -1;
        }
        else if (transform.position.z < -zLimit)
        {
            direction = 1;
        }

        transform.position += Vector3.forward * Speed * Time.deltaTime * direction;
        base.Move();
    }
}
