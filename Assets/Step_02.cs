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
            Debug.Log("더하기 결과: " + result);
        }
        {
            int a = 8;
            int b = 2;
            int result = a - b;
            Debug.Log("빼기 결과: " + result);
        }
        {
            int a = 6;
            int b = 4;
            int result = a * b;
            Debug.Log("곱하기 결과: " + result);
        }
        {
            float a = 10.0f;
            float b = 2.0f;
            float result = a / b;
            Debug.Log("나누기 결과: " + result);
        }
        {
            int a = 11;
            int b = 3;
            int result = a % b;
            Debug.Log("나머지 결과: " + result);
        }
        {
            int a = 5;
            a++;
            Debug.Log("증가 결과: " + a);
        }
        {
            int a = 7;
            a--;
            Debug.Log("감소 결과: " + a);
        }
        {
            int a = 8;
            int result = -a;
            Debug.Log("부호 반전 결과: " + result);
        }
        {
            int a = 10;
            int b = 3;
            a += b; // a = a + b;
            Debug.Log("복합 대입 연산 결과: " + a);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
