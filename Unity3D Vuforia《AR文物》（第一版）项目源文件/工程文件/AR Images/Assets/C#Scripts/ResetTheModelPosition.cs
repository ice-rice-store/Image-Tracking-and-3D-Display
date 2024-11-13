using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 代码作者：小贺儿
/// 编码日期：2023年1月4日
/// 最后修改日期：2024年7月25日
/// 脚本挂载位置：彩绘唐人俑、铜狮雕塑、中国古代青铜器鼎物体
/// 实现功能：复原模型Transform参数（位置、旋转、缩放值）
/// 备注：
/// </summary>
public class ResetTheModelPosition : MonoBehaviour
{
    public void ResetTheModel()
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
    private void Update()
    {
        if (transform.tag == "Tang People")
        {
            transform.localPosition = new Vector3(0f, 0f, 0f);
        }
        if (transform.tag == "Bronze Lion")
        {
            transform.localPosition = new Vector3(0f, 0f, 0f);
        }
        if (transform.tag == "Tripod")
        {
            transform.localPosition = new Vector3(0f, 0f, 0f);
        }
    }
}
