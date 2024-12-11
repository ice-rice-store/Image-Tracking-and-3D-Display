using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// 代码作者：小贺儿
/// 编码日期：2023年1月4日
/// 最后修改日期：2024年7月25日
/// 脚本挂载位置：中国古代青铜器鼎物体下的Mia_001138ab
/// 实现功能：点击Mia_001138ab出现对应UI
/// 备注：
/// </summary>
public class ClickTheModel : MonoBehaviour
{

    ClickTheModelAction clickAction;

    private void Awake()
    {
        clickAction = transform.parent.GetComponent<ClickTheModelAction>();
    }

    //点击模型屏蔽
    //private void OnMouseDown()
    //{
    //    clickAction.ClickModel();
    //}
}
