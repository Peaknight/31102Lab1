using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    /*void Start()
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
    }*/

    public float moveSpeed = 5f; // ����ƶ��ٶ�

    // Update is called once per frame
    void Update()
    {
        // ��ȡˮƽ�ʹ�ֱ����ֵ(-1, 0, 1)
        float moveX = Input.GetAxisRaw("Horizontal"); // ��Ӧ���Ҽ�ͷ��
        float moveY = Input.GetAxisRaw("Vertical");   // ��Ӧ���¼�ͷ��

        // �����ƶ������������ƶ��ٶȺ�Time.deltaTime����ȷ��ƽ���ƶ�
        Vector2 movement = new Vector2(moveX, moveY).normalized * moveSpeed * Time.deltaTime;

        // �ƶ����
        transform.Translate(movement);
    }
}
