using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
/// <summary>
/// Unit keeps moving left to right or vice versa. Inherits BaseUnit
/// </summary>
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
    /// <summary>
    /// Moves Unit to the (x, y, z) position
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <param name="z"></param>
    public void Move(float x, float y, float z)
    {
        transform.position = new Vector3(x, y, z);
    }

    // PLIMORPHISM
    /// <summary>
    /// Moves Unit to the vector position
    /// </summary>
    /// <param name="position"></param>
    public void Move(Vector3 position)
    {
        transform.position = position;
    }
}
