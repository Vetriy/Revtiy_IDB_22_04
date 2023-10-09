using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphere : MonoBehaviour
{
    public GameObject sphere1;

    void Start()
    {

    }


    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Object is activated");
            sphere1.SetActive(true);
        }

        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Object is deactivated");
            sphere1.SetActive(false);
        }
    }
}