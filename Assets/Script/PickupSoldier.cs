using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class PickupSoldier : MonoBehaviour
{
    private int soldierCount = 0; // ��ǰ�����ʿ������
    public int maxSoldiers = 3; // �������ʿ������
    public AudioClip pickupSound; // ʰȡʿ������Ч
    public int score = 0; // ��ҵ÷�
    public Text scoreText;
    private int seat;
    public Text soldierNumText;

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
        seat = maxSoldiers - soldierCount;
        if (soldierNumText != null)
        {
            soldierNumText.text = seat.ToString();
        }

        if (score >= 11)
        {
            // ����ͨ�س���
            SceneManager.LoadScene("PassScene");
        }
    }
    private void Update()
    {
        Debug.Log(soldierCount);
        if (Input.GetKeyDown(KeyCode.R))
        {
            // ���¼��ص�ǰ����
            SceneManager.LoadScene("Game");
            Time.timeScale = 1;
        }
    }
}
