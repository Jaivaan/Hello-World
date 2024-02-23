using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private int life =1;
    public string name;
      public int Life { get => life; set => life = value; }

    public Character(string name)
    {
        this.name = name;
        Debug.Log("Hola soy " + name);
    }

    ~Character()
    {
        Debug.Log("Muelto.");
    }
}
