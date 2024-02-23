using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helloworld : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Enemy enemy = new Enemy("ese");
        Player player = new Player("el man");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Enemy name " + enemy.name);
        Debug.Log("Enemy HP" + enemy.Life);
    }
}
