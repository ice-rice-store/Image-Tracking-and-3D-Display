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
[DefaultExecutionOrder(100)]
public class ResetTheModel : MonoBehaviour
{
    Vector3 pos;
    Vector3 rot;
    Vector3 scale;

    private void Awake()
    {
        pos = this.transform.localPosition;
        rot = this.transform.localEulerAngles;
        scale = this.transform.localScale;
        print("scale:" + scale);
        print("rot:" + rot);

        this.gameObject.SetActive(false);
    }

    public void ResetModel()
    {
        this.transform.localPosition = pos;
        this.transform.localEulerAngles = rot;
        this.transform.localScale = scale;

    }

    //private void Update()
    //{
    //    if (transform.tag == "Tang People")
    //    {
    //        transform.localPosition = new Vector3(0f, 0f, 0f);
    //    }
    //    if (transform.tag == "Bronze Lion")
    //    {
    //        transform.localPosition = new Vector3(0f, 0f, 0f);
    //    }
    //    if (transform.tag == "Tripod")
    //    {
    //        transform.localPosition = new Vector3(0f, 0f, 0f);
    //    }
    //}
}
