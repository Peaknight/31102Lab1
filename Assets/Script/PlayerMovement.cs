using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    /*void Start()
    {
        // 隐藏鼠标光标
        Cursor.visible = false;
    }

    void Update()
    {
        // 将鼠标位置从屏幕坐标转换为世界坐标
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // 由于是2D游戏，我们不想改变物体的z轴位置
        mousePosition.z = transform.position.z;

        // 设置物体的位置为鼠标当前的位置
        transform.position = mousePosition;
    }

    void OnDisable()
    {
        // 当脚本被禁用或物体被销毁时，再次显示鼠标光标
        Cursor.visible = true;
    }*/

    public float moveSpeed = 5f; // 玩家移动速度

    // Update is called once per frame
    void Update()
    {
        // 获取水平和垂直输入值(-1, 0, 1)
        float moveX = Input.GetAxisRaw("Horizontal"); // 对应左右箭头键
        float moveY = Input.GetAxisRaw("Vertical");   // 对应上下箭头键

        // 创建移动向量并乘以移动速度和Time.deltaTime，以确保平滑移动
        Vector2 movement = new Vector2(moveX, moveY).normalized * moveSpeed * Time.deltaTime;

        // 移动玩家
        transform.Translate(movement);

        if (moveX != 0)
        {
            Flip(moveX);
        }

        void Flip(float moveX)
        {
            // 根据移动方向翻转玩家，如果向左移动（moveX < 0），则翻转，否则恢复默认朝向
            Vector3 theScale = transform.localScale;
            theScale.x = moveX < 0 ? -Mathf.Abs(theScale.x) : Mathf.Abs(theScale.x);
            transform.localScale = theScale;
        }
    }
}
