using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitLeftRight : BaseUnit
{
    private float xLimit = 10;
    

    // Start is called before the first frame update
    public override void Start()
    {
        Name = "Left Right";
        Speed = 5;
        Move(0, 0, 0);

    }

    // Update is called once per frame
    public override void Update()
    {
        
        base.Update();     
    }

    public override void Move()
    {
        ChangeDirection(transform.position.x, -xLimit, xLimit);
        Move(transform.position + Vector3.right * Speed * Time.deltaTime * Direction);
        
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
