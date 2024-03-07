using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogPosition : MonoBehaviour
{
public float speed = 3f;
public float speedRotation = 1;

    // Start is called before the first frame update
    void Start()
    {
        createCubeAndSetParent();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Position: " + transform.position.ToString());
        }

        checkMovement(speed);
        checkScale(speed);
        transform.rotation *= Quaternion.Euler(0f, speedRotation* Time.deltaTime * 7, 0f);

    }

    public void checkMovement(float speed){
        float moveSpeed = speed * Time.deltaTime;

        if(Input.GetKey(KeyCode.W)){
            transform.position += new Vector3(0, moveSpeed, 0);
        }
        if(Input.GetKey(KeyCode.S)){
            transform.position += new Vector3(0, -moveSpeed, 0);
        }
        if(Input.GetKey(KeyCode.A)){
            transform.position += new Vector3(-moveSpeed, 0, 0);
        }
        if(Input.GetKey(KeyCode.D)){
            transform.position += new Vector3(moveSpeed, 0, 0);
        }
    }

    public void checkScale(float speed){
    
        float moveSpeed = speed * Time.deltaTime;

        if(Input.GetKey(KeyCode.Z)){
            transform.localScale += new Vector3(moveSpeed, 0f, 0f);
        }
        if(Input.GetKey(KeyCode.X)){
            transform.localScale += new Vector3(0f, moveSpeed, 0f);
        }
        if(Input.GetKey(KeyCode.C)){
            transform.localScale += new Vector3(0f, 0f, moveSpeed);
        }   
    }

    public void createCubeAndSetParent(){
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.SetParent(this.transform);
    }
}
