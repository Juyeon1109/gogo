using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour
{
    public static int count = 0;        //���α׷��� �����ϴ� ���� �� ��

    public int AllCount = 0;

   
    public void Awake()
    {
        count++;
    }

    public void Start()
    {
        AllCount = count;
    }

    public void OnDestroy()     //�ı� �� �� ���� ����
    {
        count--;
    }
}
