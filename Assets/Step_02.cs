using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Step_02 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        {
            int a = 5;
            int b = 3;
            int result = a + b;
            Debug.Log("���ϱ� ���: " + result);
        }
        {
            int a = 8;
            int b = 2;
            int result = a - b;
            Debug.Log("���� ���: " + result);
        }
        {
            int a = 6;
            int b = 4;
            int result = a * b;
            Debug.Log("���ϱ� ���: " + result);
        }
        {
            float a = 10.0f;
            float b = 2.0f;
            float result = a / b;
            Debug.Log("������ ���: " + result);
        }
        {
            int a = 11;
            int b = 3;
            int result = a % b;
            Debug.Log("������ ���: " + result);
        }
        {
            int a = 5;
            a++;
            Debug.Log("���� ���: " + a);
        }
        {
            int a = 7;
            a--;
            Debug.Log("���� ���: " + a);
        }
        {
            int a = 8;
            int result = -a;
            Debug.Log("��ȣ ���� ���: " + result);
        }
        {
            int a = 10;
            int b = 3;
            a += b; // a = a + b;
            Debug.Log("���� ���� ���� ���: " + a);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
