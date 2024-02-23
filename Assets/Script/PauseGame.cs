using UnityEngine;
using UnityEngine.UI; // ����UI�����ռ�

public class PauseGame : MonoBehaviour
{
    public Text pauseText; // ��Inspector�����ö�Pause Text������
    private bool isPaused = false; // ������Ϸ�Ƿ���ͣ

    void Update()
    {
        // ����ESC���İ���
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // �л���ͣ״̬
            isPaused = !isPaused;

            if (isPaused)
            {
                // ��ͣ��Ϸ
                Time.timeScale = 0;
                // ��ʾPause Text
                pauseText.enabled = true;
            }
            else
            {
                // ������Ϸ
                Time.timeScale = 1;
                // ����Pause Text
                pauseText.enabled = false;
            }
        }
    }
}
