using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Three : MonoBehaviour
{

    private int clickCounter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            AddOneToCounter();

        }

        if(clickCounter >= 10)
        {
            Debug.Log($"GAME OVER");
        }
    }

    private void AddOneToCounter()
    {
        clickCounter++;
    }
}
