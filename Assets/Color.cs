using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorObject : MonoBehaviour{

    private GameObject ObjetoColor;
    public bool check;
    public  string ColorTag;
    public GameObject[] gameObjects;
    public Color color;
    void Start(){
        gameObjects = GameObject.FindGameObjectsWithTag(ColorTag);
    }

    void Update(){
        UseFindGameObjectWithTag();
    }

    void UseFindGameObjectWithTag()
    {
        if (check == true)
        {
            //if (Input.GetButton())
            for (int i = 0; i < gameObjects.Length; i++)
            {
                gameObjects[i].GetComponent<MeshRenderer>().material.color = color;
            }
        }
       
        
    }
}
