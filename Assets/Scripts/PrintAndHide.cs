using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;

    public static Renderer()
    {
        GameObject redObj;
        GameObject blueObj;
    }
        int i;
        // Start is called before the first frame update
        void Start()
        {
            i = 3;
        }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log(gameObject.name + ":" + i);
    }
}