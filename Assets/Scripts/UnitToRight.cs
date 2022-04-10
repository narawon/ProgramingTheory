using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitToRight : BaseUnit
{
    private float xLimit = 10;
    private float xStart = -10;

    // Start is called before the first frame update
    public override void Start()
    {
        Name = "To Right";
        Speed = 5;
        
    }

    // Update is called once per frame
    public override void Update()
    {
        base.Update();     
    }

    public override void Move()
    {
        if (transform.position.x > xLimit)
        {
            Move(xStart, 0, 0);
        }
        else
        {
            Move(transform.position + Vector3.right * Time.deltaTime * Speed);
        }
        
        base.Move();
    }

    // POLIMOPHISM
    public void Move(float x, float y, float z)
    {
        transform.position = new Vector3(x, y, z);
    }

    public void Move(Vector3 position)
    {
        transform.position = position;
    }
}
