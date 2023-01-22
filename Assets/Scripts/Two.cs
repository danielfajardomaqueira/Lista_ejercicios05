using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Two : MonoBehaviour
{

    public string Username;
    public string Password;

    // Start is called before the first frame update
    void Start()
    {
        Login(Username, Password);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private bool Login(string Username, string Password) //function to do a login process.
    {
        if (Username == "admin" && Password == "abccba")
        {
            Debug.Log($"Login Accepted");
            return true;
        }

        Debug.Log($"Login Incorrecct");
        return false;
    }
}
