using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int myint = 10 + 10 * 30;
        double mydouble = 10.0;
        float myfloat = 10.0f;
        bool mybool = true;
        string mystring = "hello world30 !!!";

        Debug.Log(mystring);
        Debug.Log(myint);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
