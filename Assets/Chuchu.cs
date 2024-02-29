using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chuchu : MonoBehaviour
{   
    private Transform transformacion;

    private GameObject chuchuObject;
    public const string ChuchuTag = "Chuchu";

    void Start()
    {
        transformacion = GetComponent<Transform>();
        chuchuObject = GameObject.FindGameObjectWithTag(ChuchuTag);
    }

    void Update()
    {
        LogPosition();
        UseFindGameObjectWithTag();
    }

    void LogPosition()
    {
        Debug.Log("Position: " + transformacion.position.x + ", " + transformacion.position.y + ", " + transformacion.position.z);
    }

    void UseFindGameObjectWithTag()
    {
        if (chuchuObject != null)
        {
            Debug.Log("Toy aqui");
        }
    }
}
        
