using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorObject : MonoBehaviour{

    void Start(){
        this.GetComponent<MeshRenderer>().material.color = Color.red;
    }

    void Update(){
        
    }
}
