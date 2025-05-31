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
        // ���� ��ġ�� ���
        float newY = transform.localPosition.y;

        // ���� �̵�
        if (movingUp)
        {
            newY += moveSpeed * Time.deltaTime;
            if (newY >= start.y + moveDistance)
            {
                newY = start.y + moveDistance;
                movingUp = false; // ���� ��ȯ
            }
        }
        // �Ʒ��� �̵�
        else
        {
            newY -= moveSpeed * Time.deltaTime;
            if (newY <= start.y - moveDistance)
            {
                newY = start.y - moveDistance;
                movingUp = true; // ���� ��ȯ
            }
        }

        // ���ο� ��ġ ����
        transform.localPosition = new Vector3(start.x, newY, start.z);
    }
}
