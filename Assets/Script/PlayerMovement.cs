using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    void Start()
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
    }
}
