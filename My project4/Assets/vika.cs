using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vika : MonoBehaviour
{
    public GameObject sphere;
    public Text x;
    public int y = 0;
    public bool a=true;

    public void ButtonPressed()
    {
        if (a)
        {
            sphere.SetActive(false);
            a = false;
        }

        else
        {
            sphere.SetActive(true);
            a = true;
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        y--;
        x.text = y.ToString();
    }
    void Start()
    {


    }

    void FixedUpdate()
    {


    }
}