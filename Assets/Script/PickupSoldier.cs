using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PickupSoldier : MonoBehaviour
{
    private int soldierCount = 0; // 当前跟随的士兵数量
    public int maxSoldiers = 3; // 最多跟随的士兵数量
    public AudioClip pickupSound; // 拾取士兵的音效
    public int score = 0; // 玩家得分

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
    }
}
