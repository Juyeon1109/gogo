using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour
{
    //���� ������Ʈ�� ��� �������� �����̴� ��ũ��Ʈ
    public float speed = 10.0f; //�̵��ӵ�


    // Start is called before the first frame update
    void Start()
    {
        Dog.count = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameManager.Instance.isGameOver)   //���ӿ����� �ƴ϶��
        {
            //�ʴ� speed �ӵ��� �������� �����̵�
            transform.Translate(Vector3.left * speed * Time.deltaTime); //���� ������Ʈ�� �ʴ� (-speed, 0, 0) ��ŭ �̵� 
        }
    }
}
