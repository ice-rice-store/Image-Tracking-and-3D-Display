using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 代码作者：小贺儿
/// 编码日期：2023年1月4日
/// 最后修改日期：2024年7月25日
/// 脚本挂载位置：彩绘唐人俑、铜狮雕塑、中国古代青铜器鼎物体
/// 实现功能：缩放模型交互
/// 备注：仅在打包发布后有效
/// </summary>
public class Scale : MonoBehaviour
{
    public static bool isScaling; // 状态标志
    Vector2 oldPos1;
    Vector2 oldPos2;

    void Update()
    {
        if (Input.touchCount == 2)
        {
            Vector2 temPos1 = Input.GetTouch(0).position;
            Vector2 temPos2 = Input.GetTouch(1).position;

            // 判断手指是否朝相反方向移动
            Vector2 deltaPos1 = Input.GetTouch(0).deltaPosition;
            Vector2 deltaPos2 = Input.GetTouch(1).deltaPosition;

            if (Input.GetTouch(0).phase == TouchPhase.Moved || Input.GetTouch(1).phase == TouchPhase.Moved)
            {
                // 计算手指滑动的角度
                float angle1 = Vector2.SignedAngle(Vector2.up, deltaPos1);
                float angle2 = Vector2.SignedAngle(Vector2.up, deltaPos2);

                // 判断两个手指的滑动方向是否相反
                if (Mathf.Abs(angle1 - angle2) > 90) // 如果角度差大于90度，则方向相反
                {
                    isScaling = true; // 开始缩放
                    if (isEnLarge(oldPos1, oldPos2, temPos1, temPos2))
                    {
                        float oldScale = transform.localScale.x;
                        float newScale = oldScale * 1.025f; // 放大

                        transform.localScale = new Vector3(newScale, newScale, newScale);
                    }
                    else
                    {
                        float oldScale = transform.localScale.x;
                        float newScale = oldScale / 1.025f; // 缩小

                        transform.localScale = new Vector3(newScale, newScale, newScale);
                    }

                    oldPos1 = temPos1;
                    oldPos2 = temPos2;
                }
            }
        }
        else
        {
            isScaling = false; // 结束缩放
        }
    }

    bool isEnLarge(Vector2 oP1, Vector2 oP2, Vector2 nP1, Vector2 nP2)
    {
        float length1 = Mathf.Sqrt((oP1.x - oP2.x) * (oP1.x - oP2.x) + (oP1.y - oP2.y) * (oP1.y - oP2.y));
        float length2 = Mathf.Sqrt((nP1.x - nP2.x) * (nP1.x - nP2.x) + (nP1.y - nP2.y) * (nP1.y - nP2.y));

        return length1 < length2; // 返回是否放大
    }
}
