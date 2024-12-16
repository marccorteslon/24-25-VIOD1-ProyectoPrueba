using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class limiteMovimiento : MonoBehaviour
{

    public float yMax = 6;
    public float yMin = -6;
    public float xMax = 2;
    public float xMin = -2;
    void Update()
    {
        if (transform.position.y > yMax)
        {
            Debug.Log("Me he pasado Y+");
            transform.position = new Vector3(transform.position.x, yMax);
        }
        if (transform.position.y < yMin)
        {
            Debug.Log("Me he pasado Y-");
            transform.position = new Vector3(transform.position.x, yMin);
        }
        if (transform.position.y > xMax)
        {
            Debug.Log("Me he pasado X+");
            transform.position = new Vector3(xMax, transform.position.y);
        }
        if (transform.position.y < xMin)
        {
            Debug.Log("Me he pasado X-");
            transform.position = new Vector3(xMin, transform.position.y);
        }
    }
}
