using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Three : MonoBehaviour
{

    private int clickCounter = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            AddOneToCounter();  //sum function
            if (clickCounter == 10)
            {
                Debug.Log($"GAME OVER"); //Game Over Mechanic.
            }
        }

        
    }

    private void AddOneToCounter()
    {
        clickCounter++; //sum the number of "clicks" of the key.
    }
}
