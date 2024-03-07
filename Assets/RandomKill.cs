using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomKill : MonoBehaviour
{
    public Object[] gameObjects;
    
    void Start()
    {
        gameObjects = GameObject.FindObjectsOfType(typeof(MonoBehaviour));
    }

 
    void Update()
    {
        Matanza();
    }


    private void Matanza()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Muertini");
            if (gameObjects.Length > 0)
            {
                int randomIndex = Random.Range(0, gameObjects.Length);
                Destroy(gameObjects[randomIndex]);
            }
        }
    }
}
