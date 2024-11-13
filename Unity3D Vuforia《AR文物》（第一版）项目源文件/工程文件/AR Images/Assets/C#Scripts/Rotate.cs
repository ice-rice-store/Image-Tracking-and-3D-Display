using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 代码作者：小贺儿
/// 编码日期：2023年1月4日
/// 最后修改日期：2024年7月25日
/// 脚本挂载位置：彩绘唐人俑、铜狮雕塑、中国古代青铜器鼎物体
/// 实现功能：旋转模型交互
/// 备注：仅在打包发布后有效
/// </summary>
public class Rotate : MonoBehaviour
{
    //速度
    float xSpeed = 200f;
    void Update()
    {
        //如果触摸了屏幕
        if (Input.GetMouseButton(0))
        {
            //判断是几个手指触摸
            if (Input.touchCount == 1)
            {
                //第一个触摸到手指头 phase状态 Moved滑动
                if (Input.GetTouch(0).phase == TouchPhase.Moved)
                {
                    //根据你旋转的 模型物体 是要围绕哪一个轴旋转 Vector3.up是围绕Y旋转
                    transform.Rotate(-Vector3.up * Input.GetAxis("Mouse X") * xSpeed * Time.deltaTime);
                }
            }
        }
        // 如果手指双击
        if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            if (Input.GetTouch(0).tapCount == 2)
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
    }
}