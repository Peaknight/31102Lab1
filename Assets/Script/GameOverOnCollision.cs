using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverOnCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Tree"))
        {
            // ���ﴦ����Ϸ�����߼�
            // ���磬���¼��ص�ǰ���������һ����Ϸ��������
            SceneManager.LoadScene("GameFinished");
        }
    }
}
