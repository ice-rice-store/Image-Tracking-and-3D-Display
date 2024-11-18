using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 代码作者：小贺儿
/// 编码日期：2023年1月4日
/// 最后修改日期：2024年11月2日
/// 脚本挂载位置：彩绘唐人俑、铜狮雕塑、中国古代青铜器鼎物体
/// 实现功能：旋转模型交互
/// 备注：仅在打包发布后有效
/// </summary>
/// <summary>
/// 优化：严郑康
/// 编码日期：2024年11月2日
/// 最后修改日期：2024年11月2日
/// 优化内容功能：
///     ·在原有水平旋转的基础上，添加竖直方向旋转的功能
///     ·优化旋转速度

/// </summary>
public class Rotate : MonoBehaviour
{
    // 速度
    float xSpeed = 20f; // 修改为0.1倍
    float ySpeed = 200f;

    void Update()
    {
        // 如果触摸了屏幕
        if (Input.touchCount == 1 && !Scale.isScaling)
        {
            // 处理单指触摸，绕Y轴旋转
            if (Input.GetTouch(0).phase == TouchPhase.Moved)
            {
                transform.Rotate(-Vector3.up * Input.GetAxis("Mouse X") * ySpeed * Time.deltaTime);
            }
        }
        else if (Input.touchCount == 2 && !Scale.isScaling)
        {
            // 处理双指触摸，判断两个手指是否朝同一个方向滑动
            Vector2 touch0Delta = Input.GetTouch(0).deltaPosition;
            Vector2 touch1Delta = Input.GetTouch(1).deltaPosition;

            // 判断两个手指的滑动方向是否一致
            if (Vector2.Dot(touch0Delta.normalized, touch1Delta.normalized) > 0)
            {
                // 计算滑动量并进行旋转，绕X轴旋转
                float deltaY = (touch0Delta.y + touch1Delta.y) * 0.1f; // 使用0.1倍的速度
                transform.Rotate(Vector3.right * deltaY);
            }
        }


        // 如果手指双击
        if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            if (Input.GetTouch(0).tapCount == 2)
            {
                ResetScaleAndRotation();
            }
        }

    }

    private void ResetScaleAndRotation()
    {
        if (transform.tag == "Tang People")
        {
            transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
            transform.localRotation = Quaternion.Euler(new Vector3(0f, -90f, 0f));
        }
        if (transform.tag == "Bronze Lion")
        {
            transform.localScale = new Vector3(0.07f, 0.07f, 0.07f);
            transform.localRotation = Quaternion.Euler(new Vector3(0f, 90f, 0f));
        }
        if (transform.tag == "Tripod")
        {
            transform.localScale = new Vector3(3.0f, 3.0f, 3.0f);
            transform.localRotation = Quaternion.Euler(new Vector3(0f, -90f, 0f));
        }
    }
}
