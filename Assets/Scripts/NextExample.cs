using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextExample : MonoBehaviour
{
    //Next example
    public void Next()
    {
        transform.position = new Vector3(16, 1, -5);
    }

    //Previous example
    public void Return()
    {
        transform.position = new Vector3(0, 1, -5);
    }
}
