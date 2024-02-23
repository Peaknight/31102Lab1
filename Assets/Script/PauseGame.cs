using UnityEngine;
using UnityEngine.UI; // 引入UI命名空间

public class PauseGame : MonoBehaviour
{
    public Text pauseText; // 在Inspector中设置对Pause Text的引用
    private bool isPaused = false; // 跟踪游戏是否暂停

    void Update()
    {
        // 监听ESC键的按下
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // 切换暂停状态
            isPaused = !isPaused;

            if (isPaused)
            {
                // 暂停游戏
                Time.timeScale = 0;
                // 显示Pause Text
                pauseText.enabled = true;
            }
            else
            {
                // 继续游戏
                Time.timeScale = 1;
                // 隐藏Pause Text
                pauseText.enabled = false;
            }
        }
    }
}
