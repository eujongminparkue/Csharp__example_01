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
            //�巡�� �� Ctrl KC  ������ KU
            int a = 5;
            int b = 5;
            bool isEqual = (a == b);
            Debug.Log("�� ���� ������ : " + isEqual);
        }

    void func2()
        {
            int a = 5;
            int b = 3;
            bool isNotEuqal = (a != b);
            Debug.Log("�� ���� �ٸ��� : " + isNotEuqal);
        }
        //{
        //    int a = 7;
        //    int b = 4;
        //    bool isGreater = (a > b);
        //    Debug.Log("a�� b���� ū�� : " + isGreater);
        //}
        //{
        //    int a = 3;
        //    int b = 6;
        //    bool isLess = (a < b);
        //    Debug.Log("a�� b���� ������ : " + isLess);
        //}
        //{
        //    int a = 3;
        //    int b = 4;
        //    bool isLessOrEqual = (a <= b);
        //    Debug.Log("a�� b���� �۰ų� ������ : " + isLessOrEqual);
        //}
        //{
        //    int a = 3;
        //    int b = 6;
        //    bool isGreaterOrEqual = (a >= b);
        //    Debug.Log("a�� b���� ũ�ų� ������ : " + isGreaterOrEqual);
        //}
        //{
        //    int a = 7;
        //    int b = 6;
        //    bool isGreaterOrEqual = (a >= b);
        //    if (isGreaterOrEqual)
        //    {
        //        // true �� ����
        //        Debug.Log("��");
        //    }
        //    else
        //    {
        //        // false �� ����
        //        Debug.Log("����");
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
        //        Debug.Log("�ƹ��͵� �ƴ�");
        //    }
        //}
        //{
        //    for (int i = 0; i < 10; i++) // i �� set �ϰ� ���� ������ �����Ѵ�.
        //    {
        //        //����
        //        Debug.Log(i);
        //    }
        //}
        //{
        //    for (int i = 0; i < 10; i++) //���ǹ�
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
        //    // 0 ~ 40 ������ ���߿� 10���� ������ �������� 0�� ���ڵ��� Debug.Log �� ����ϱ�
        //    for (int i = 0; i <= 40; i++)
        //        if (i % 10 == 0)
        //        {
        //            Debug.Log(i);   
        //        }
        //}
        //{
        //    // 0���� 100������ �� �߿� Ȧ���� �ֵ鸸 ����ض�
        //    for (int i = 0; i <= 100; i++)
        //        if (i % 2 != 0)
        //        {
        //        Debug.Log(i);
        //        }
        //}
        //{   // 0���� 100������ �� �߿� 5�� ����� �ֵ鸸 ����ض�
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

        // 0���� 100������ ���߿� 5�� ����̰� �� ���� 50���ٴ� ū ���� ����ض�
        //{
        //    for (int i = 0; i <= 100; i++)
        //        if (i % 5 == 0 && i > 50)
        //        {
        //            Debug.Log(i);
        //        }
        //}
        //{
        //    //0���� 100������ �� �߿� 2�� ����̰ų� 7�� ����� �ֵ鸸 ����ض�
        //    for (int i = 0; i <= 100; i++)
        //        if (i % 2 == 0 || i % 7 == 0)
        //        {
        //            Debug.Log(i);
        //        }
        //}
        //{
        //    //0���� 100������ �� �߿� 2�� ���������� ���� �ƴ� �ֵ鸸 ����ض�
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
