using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// 代码作者：小贺儿
/// 编码日期：2023年1月4日
/// 最后修改日期：2024年7月25日
/// 脚本挂载位置：铜狮雕塑物体下的FBX untitled
/// 实现功能：点击FBX untitled出现对应UI
/// 备注：
/// </summary>
public class ClickTheLion : MonoBehaviour
{
    private void OnMouseDown()
    {
        StartCoroutine(Open());
        GameObject.Find("FBX untitled").GetComponent<BoxCollider>().enabled = false;
        GameObject.Find("点击").GetComponent<AudioSource>().Play();
    }
    IEnumerator Open()
    {
        GameObject.Find("铜狮").GetComponent<Image>().enabled = true;
        GameObject.Find("铜狮").GetComponent<CanvasGroup>().alpha += 0.25f;
        yield return new WaitForSeconds(0.1f);
        GameObject.Find("铜狮").GetComponent<CanvasGroup>().alpha += 0.25f;
        yield return new WaitForSeconds(0.1f);
        GameObject.Find("铜狮").GetComponent<CanvasGroup>().alpha += 0.25f;
        yield return new WaitForSeconds(0.1f);
        GameObject.Find("铜狮").GetComponent<CanvasGroup>().alpha += 0.25f;
        GameObject.Find("铜狮").GetComponent<Image>().enabled = true;
        GameObject.Find("铜狮/关掉(1)").GetComponent<Image>().enabled = true;
        GameObject.Find("铜狮/关掉(1)").GetComponent<Button>().enabled = true;
    }
    public void CloseTheUI()
    {
        StartCoroutine(Close());
    }
    IEnumerator Close()
    {

        GameObject.Find("铜狮").GetComponent<CanvasGroup>().alpha -= 0.25f;
        yield return new WaitForSeconds(0.1f);
        GameObject.Find("铜狮").GetComponent<CanvasGroup>().alpha -= 0.25f;
        yield return new WaitForSeconds(0.1f);
        GameObject.Find("铜狮").GetComponent<CanvasGroup>().alpha -= 0.25f;
        yield return new WaitForSeconds(0.1f);
        GameObject.Find("铜狮").GetComponent<CanvasGroup>().alpha -= 0.25f;
        GameObject.Find("铜狮").GetComponent<Image>().enabled = false;
        GameObject.Find("铜狮/关掉(1)").GetComponent<Image>().enabled = false;
        GameObject.Find("铜狮/关掉(1)").GetComponent<Button>().enabled = false;
        GameObject.Find("FBX untitled").GetComponent<BoxCollider>().enabled = true;
    }
}
