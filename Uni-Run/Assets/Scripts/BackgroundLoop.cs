using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//���� ������ �̵��� ����� ������ ������ ���ġ�ϴ� ��ũ��Ʈ
public class BackgroundLoop : MonoBehaviour
{
    public float width;     //����� ���� ���� 
    // Start is called before the first frame update
    private void Awake()     //���� ���̸� �����ϴ� ó��
    {
       //BoxCollider2D ������Ʈ�� size �ʵ��� x ���� ���� ���̷� ���
       BoxCollider2D backgroundCollider = GetComponent<BoxCollider2D>();         //BoxCollider2D ������Ʈ�� ����
       width = backgroundCollider.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        //���� ��ġ�� �������� �������� Width �̻� �̵����� ���� ��ġ�� ���ġ
        if(transform.position.x <= -width)
        {
            Repostion();        //�Լ� ����
        }
    }

    //��ġ�� ���ġ �ϴ� �ż���
    private void Repostion()
    {
        //���� ��ġ���� ���������� ���� ���� * 2 ��ŭ �̵�
        Vector2 offset = new Vector2(width * 2f, 0);
        transform.position = (Vector2) transform.position + offset; 
    }
}
