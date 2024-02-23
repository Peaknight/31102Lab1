using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class PickupSoldier : MonoBehaviour
{
    private int soldierCount = 0; // 当前跟随的士兵数量
    public int maxSoldiers = 3; // 最多跟随的士兵数量
    public AudioClip pickupSound; // 拾取士兵的音效
    public int score = 0; // 玩家得分
    public Text scoreText;
    private int seat;
    public Text soldierNumText;

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.CompareTag("Soldier") && soldierCount < maxSoldiers)
        {
            // 增加士兵计数
            soldierCount++;
       
            // 播放拾取音效
            if (pickupSound != null)
            {
               // AudioSource.PlayClipAtPoint(pickupSound, transform.position);
            }
            // 销毁士兵对象
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("House"))
        {
            // 将士兵数量转换为分数
            score += soldierCount;
            // 清空玩家携带的士兵数量
            soldierCount = 0;
            // 可以在这里添加其他逻辑，比如更新UI显示分数
        }
        if (scoreText != null)
        {
            scoreText.text =  score.ToString();
        }
        seat = maxSoldiers - soldierCount;
        if (soldierNumText != null)
        {
            soldierNumText.text = seat.ToString();
        }

        if (score >= 11)
        {
            // 加载通关场景
            SceneManager.LoadScene("PassScene");
        }
    }
    private void Update()
    {
        Debug.Log(soldierCount);
        if (Input.GetKeyDown(KeyCode.R))
        {
            // 重新加载当前场景
            SceneManager.LoadScene("Game");
            Time.timeScale = 1;
        }
    }
}
