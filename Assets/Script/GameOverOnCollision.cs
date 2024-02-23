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
            // 这里处理游戏结束逻辑
            // 例如，重新加载当前场景或加载一个游戏结束场景
            SceneManager.LoadScene("GameFinished");
        }
    }
}
