using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


/// <summary>
/// Base class for moving object. Children class needs to implement Move method
/// </summary>
public class BaseUnit : MonoBehaviour
{
    [SerializeField] private TextMeshPro nameDisplay;

    // ENCAPSULATION
    /// <summary>
    /// keeps the moving direction (Read Only)
    /// </summary>
    /// 
    private float m_direction = 1;
    protected float Direction {
        get
        {
            return m_direction;
        }
    } 


    // ENCAPSULATION
    /// <summary>
    /// Whenever name is set, it is displayed. Empty string cannot be assigned to name.
    /// </summary>
    private string m_name = "name";
    public string Name 
    {

        get
        {
            return m_name;
        }
        
        set 
        {
            if (value == "")
            {
                Debug.LogError("name cannot be empty string");
            }
            else
            {
                m_name = value;
                nameDisplay.text = m_name;
            }
        } 
    }

    /// <summary>
    /// Checks the speed cannot be 0
    /// </summary>
    private float m_speed = 10;
    public float Speed
    {
        get
        {
            return m_speed;
        }

        set
        {
            if (value == 0)
            {
                Debug.LogError("speed cannot be 0");
            }
            else
            {
                m_speed = value;
            }
        }
    }

    protected void ChangeDirection(float current, float min, float max)
    {
        if (current < min)
        {
            m_direction = 1;
        }
        else if (current > max)
        {
            m_direction = -1;
        }
    }


    // Start is called before the first frame update
    public virtual void Start()
    {
        
    }

    // Update is called once per frame
    public virtual void Update()
    {
        Move();
    }

    /// <summary>
    /// Abstract method to be implemented by child class
    /// </summary>
    public virtual void Move()
    {

    }
}
