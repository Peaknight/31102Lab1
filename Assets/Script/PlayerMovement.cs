using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    void Start()
    {
        // ���������
        Cursor.visible = false;
    }

    void Update()
    {
        // �����λ�ô���Ļ����ת��Ϊ��������
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // ������2D��Ϸ�����ǲ���ı������z��λ��
        mousePosition.z = transform.position.z;

        // ���������λ��Ϊ��굱ǰ��λ��
        transform.position = mousePosition;
    }

    void OnDisable()
    {
        // ���ű������û����屻����ʱ���ٴ���ʾ�����
        Cursor.visible = true;
    }
}
