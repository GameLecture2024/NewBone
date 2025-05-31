using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingUI : MonoBehaviour
{
    public float moveSpeed = 10;
    public float moveDistance = 10;
    private Vector3 start;
    private bool movingUp = true;

    RectTransform rectTransform;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        start = transform.localPosition;
    }

    private void Update()
    {
        // 현재 위치를 계산
        float newY = transform.localPosition.y;

        // 위로 이동
        if (movingUp)
        {
            newY += moveSpeed * Time.deltaTime;
            if (newY >= start.y + moveDistance)
            {
                newY = start.y + moveDistance;
                movingUp = false; // 방향 전환
            }
        }
        // 아래로 이동
        else
        {
            newY -= moveSpeed * Time.deltaTime;
            if (newY <= start.y - moveDistance)
            {
                newY = start.y - moveDistance;
                movingUp = true; // 방향 전환
            }
        }

        // 새로운 위치 설정
        transform.localPosition = new Vector3(start.x, newY, start.z);
    }
}
