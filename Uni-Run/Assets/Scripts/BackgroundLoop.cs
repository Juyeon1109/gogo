using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//왼쪽 끝으로 이동할 배경을 오른쪽 끝으로 재배치하는 스크립트
public class BackgroundLoop : MonoBehaviour
{
    public float width;     //배경의 가로 길이 
    // Start is called before the first frame update
    private void Awake()     //가로 길이를 측정하는 처리
    {
       //BoxCollider2D 컴포넌트의 size 필드의 x 값을 가로 길이로 사용
       BoxCollider2D backgroundCollider = GetComponent<BoxCollider2D>();         //BoxCollider2D 컴포넌트에 접근
       width = backgroundCollider.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        //현재 위치가 원점에서 왼쪽으로 Width 이상 이동했을 떄의 위치를 재배치
        if(transform.position.x <= -width)
        {
            Repostion();        //함수 실행
        }
    }

    //위치를 재배치 하는 매서드
    private void Repostion()
    {
        //현재 위치에서 오른쪽으로 가로 길이 * 2 만큼 이동
        Vector2 offset = new Vector2(width * 2f, 0);
        transform.position = (Vector2) transform.position + offset; 
    }
}
