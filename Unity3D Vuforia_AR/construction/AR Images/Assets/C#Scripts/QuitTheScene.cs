using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// 代码作者：小贺儿
/// 编码日期：2023年1月4日
/// 最后修改日期：2024年7月25日
/// 脚本挂载位置：Canvas下的退出物体
/// 实现功能：淡出程序
/// 备注：仅在打包发布后有效
/// </summary>
public class QuitTheScene : MonoBehaviour
{
    
     public void Quit()
    {
        StartCoroutine(Close());
        GameObject.Find("Canvas(眨眼)").GetComponent<RawImage>().enabled = true;
    }
    IEnumerator Close()
    {
        GameObject.Find("Canvas(眨眼)").GetComponent<CanvasGroup>().alpha += 0.25f;
        yield return new WaitForSeconds(0.1f);
        GameObject.Find("Canvas(眨眼)").GetComponent<CanvasGroup>().alpha += 0.25f;
        yield return new WaitForSeconds(0.1f);
        GameObject.Find("Canvas(眨眼)").GetComponent<CanvasGroup>().alpha += 0.25f;
        yield return new WaitForSeconds(0.1f);
        GameObject.Find("Canvas(眨眼)").GetComponent<CanvasGroup>().alpha += 0.25f;
        Application.Quit();
    }
}
