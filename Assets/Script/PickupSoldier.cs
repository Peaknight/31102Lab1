using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class PickupSoldier : MonoBehaviour
{
    private int soldierCount = 0; // ��ǰ�����ʿ������
    public int maxSoldiers = 3; // �������ʿ������
    public AudioClip pickupSound; // ʰȡʿ������Ч
    public int score = 0; // ��ҵ÷�
    public Text scoreText;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Soldier") && soldierCount < maxSoldiers)
        {
            // ����ʿ������
            soldierCount++;
            // ����ʰȡ��Ч
            if (pickupSound != null)
            {
               // AudioSource.PlayClipAtPoint(pickupSound, transform.position);
            }
            // ����ʿ������
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("House"))
        {
            // ��ʿ������ת��Ϊ����
            score += soldierCount;
            // ������Я����ʿ������
            soldierCount = 0;
            // ������������������߼����������UI��ʾ����
        }
        if (scoreText != null)
        {
            scoreText.text =  score.ToString();
        }
    }
    private void Update()
    {
        Debug.Log(soldierCount);
    }
}
