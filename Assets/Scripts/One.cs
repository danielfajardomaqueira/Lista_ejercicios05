using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class One : MonoBehaviour
{

    public float Num1;
    public float Num2;
    public float Num3;

    // Start is called before the first frame update
    void Start()
    {
        arithmeticMean(Num1, Num2, Num3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private float arithmeticMean(float Num1, float Num2, float Num3)
    {
        float result = (Num1 + Num2 + Num3) / 3;
        Debug.Log($"The arithmetic mean of {Num1}, {Num2} and {Num3} is {(Num1 + Num2 + Num3) / 3}");
        return result;
        
        
    }
}
