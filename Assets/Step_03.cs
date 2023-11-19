using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.AI;

public class Step_03 : MonoBehaviour
{
    // Start is called before the first frame update
    void func1()
    {
        {
            //드래그 후 Ctrl KC  해제는 KU
            int a = 5;
            int b = 5;
            bool isEqual = (a == b);
            Debug.Log("두 값이 같은가 : " + isEqual);
        }

    void func2()
        {
            int a = 5;
            int b = 3;
            bool isNotEuqal = (a != b);
            Debug.Log("두 값이 다른가 : " + isNotEuqal);
        }
        //{
        //    int a = 7;
        //    int b = 4;
        //    bool isGreater = (a > b);
        //    Debug.Log("a가 b보다 큰가 : " + isGreater);
        //}
        //{
        //    int a = 3;
        //    int b = 6;
        //    bool isLess = (a < b);
        //    Debug.Log("a가 b보다 작은가 : " + isLess);
        //}
        //{
        //    int a = 3;
        //    int b = 4;
        //    bool isLessOrEqual = (a <= b);
        //    Debug.Log("a가 b보다 작거나 같은가 : " + isLessOrEqual);
        //}
        //{
        //    int a = 3;
        //    int b = 6;
        //    bool isGreaterOrEqual = (a >= b);
        //    Debug.Log("a가 b보다 크거나 같은가 : " + isGreaterOrEqual);
        //}
        //{
        //    int a = 7;
        //    int b = 6;
        //    bool isGreaterOrEqual = (a >= b);
        //    if (isGreaterOrEqual)
        //    {
        //        // true 면 실행
        //        Debug.Log("참");
        //    }
        //    else
        //    {
        //        // false 면 실행
        //        Debug.Log("거짓");
        //    }
        //}
        //{
        //    int a = 7;
        //    if (a == 10)
        //    {
        //        Debug.Log("10");
        //    }
        //    else if (a == 9)
        //    {
        //        Debug.Log("9");
        //    }
        //    else if (a == 8)
        //    {
        //        Debug.Log("8");
        //    }
        //    else
        //    {
        //        Debug.Log("아무것도 아님");
        //    }
        //}
        //{
        //    for (int i = 0; i < 10; i++) // i 를 set 하고 뒤의 로직을 실행한다.
        //    {
        //        //실행
        //        Debug.Log(i);
        //    }
        //}
        //{
        //    for (int i = 0; i < 10; i++) //조건문
        //    {
        //        if (i >= 5)
        //        { 
        //            Debug.Log(i); 
        //        }
        //        else
        //        {
        //            Debug.Log("else");
        //        }
        //    }
        //}
        //{
        //    // 0 ~ 40 까지의 수중에 10으로 나눠서 나머지가 0인 숫자들을 Debug.Log 로 출력하기
        //    for (int i = 0; i <= 40; i++)
        //        if (i % 10 == 0)
        //        {
        //            Debug.Log(i);   
        //        }
        //}
        //{
        //    // 0부터 100까지의 수 중에 홀수인 애들만 출력해라
        //    for (int i = 0; i <= 100; i++)
        //        if (i % 2 != 0)
        //        {
        //        Debug.Log(i);
        //        }
        //}
        //{   // 0부터 100까지의 수 중에 5의 배수인 애들만 출력해라
        //    for (int i = 0; i <= 100; i++)
        //        if (i % 5 == 0)
        //        {
        //            Debug.Log(i);
        //        }
        //}
        //{
        //    int i = 5;
        //    if (i > 4 && i == 5)
        //    {
        //        Debug.Log("True");
        //    }
        //    if (i >= 5)
        //        Debug.Log("True"); 
        //}
        //int i = 20;
        //if (i > 10 || i % 20 == 0)
        //{
        //    Debug.Log("True");
        //}

        //int i = 1;

        //bool bCheck = !(i == 1);
        //if (bCheck)
        //{
        //    Debug.Log("True");
        //}

        // 0부터 100까지의 수중에 5의 배수이고 그 값이 50보다는 큰 값만 출력해라
        //{
        //    for (int i = 0; i <= 100; i++)
        //        if (i % 5 == 0 && i > 50)
        //        {
        //            Debug.Log(i);
        //        }
        //}
        //{
        //    //0부터 100까지의 수 중에 2의 배수이거나 7의 배수인 애들만 출력해라
        //    for (int i = 0; i <= 100; i++)
        //        if (i % 2 == 0 || i % 7 == 0)
        //        {
        //            Debug.Log(i);
        //        }
        //}
        //{
        //    //0부터 100까지의 수 중에 2로 나뉘어지는 수가 아닌 애들만 출력해라
        //    for (int i = 0; i <= 100; i++)
        //        if (!(i % 2 == 0))
        //        {
        //            Debug.Log(i);
        //        }
        //}
        //
        //int i = 6;
        //int a = i == 5 ? 1 : 0;
        //Debug.Log(a);

        //if (i == 5)
        //{
        //    a = 1;
        //}
        //else
        //{
        //    a = 0;
        //}
        //int i = 6;

        //switch (i)
        //{
        //    case 5:
        //        Debug.Log(5);
        //        break;
        //    case 6:
        //        Debug.Log("Hello");
        //        break;
        //}

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
