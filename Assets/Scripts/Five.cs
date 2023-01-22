using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Five : MonoBehaviour
{

    public float[] elements = { 10, -13, -100, 101, 7 };

    // Start is called before the first frame update
    void Start()
    {
        if(elements.Length >= 5) //Defines the length of the array to check how many elements it has.
        {
            Debug.Log($"First element = {elements[0]}");
            Debug.Log($"Third element = {elements[2]}");
            Debug.Log($"Fifth element = {elements[4]}");
        }
        else
        {
            Debug.Log($"Missing elements");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
