using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Four : MonoBehaviour
{

    public float[] elements = { 10, -13, -100, 101, 7 }; //define the number of elements in the array.

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"First element = {elements[0]}");
        Debug.Log($"Third element = {elements[2]}");
        Debug.Log($"Fifth element = {elements[4]}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
