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
public class ClickTheDing : MonoBehaviour
{
    private void OnMouseDown()
    {
        StartCoroutine(Open());
        GameObject.Find("Mia_001138ab").GetComponent<SphereCollider>().enabled = false;
        GameObject.Find("点击").GetComponent<AudioSource>().Play();
    }
    IEnumerator Open()
    {
        GameObject.Find("青铜鼎").GetComponent<Image>().enabled = true;
        GameObject.Find("青铜鼎").GetComponent<CanvasGroup>().alpha += 0.25f;
        yield return new WaitForSeconds(0.1f);
        GameObject.Find("青铜鼎").GetComponent<CanvasGroup>().alpha += 0.25f;
        yield return new WaitForSeconds(0.1f);
        GameObject.Find("青铜鼎").GetComponent<CanvasGroup>().alpha += 0.25f;
        yield return new WaitForSeconds(0.1f);
        GameObject.Find("青铜鼎").GetComponent<CanvasGroup>().alpha += 0.25f;
        GameObject.Find("青铜鼎").GetComponent<Image>().enabled = true;
        GameObject.Find("青铜鼎/关掉(2)").GetComponent<Image>().enabled = true;
        GameObject.Find("青铜鼎/关掉(2)").GetComponent<Button>().enabled = true;
    }
    public void CloseTheUI()
    {
        StartCoroutine(Close());
    }
    IEnumerator Close()
    {

        GameObject.Find("青铜鼎").GetComponent<CanvasGroup>().alpha -= 0.25f;
        yield return new WaitForSeconds(0.1f);
        GameObject.Find("青铜鼎").GetComponent<CanvasGroup>().alpha -= 0.25f;
        yield return new WaitForSeconds(0.1f);
        GameObject.Find("青铜鼎").GetComponent<CanvasGroup>().alpha -= 0.25f;
        yield return new WaitForSeconds(0.1f);
        GameObject.Find("青铜鼎").GetComponent<CanvasGroup>().alpha -= 0.25f;
        GameObject.Find("青铜鼎").GetComponent<Image>().enabled = false;
        GameObject.Find("青铜鼎/关掉(2)").GetComponent<Image>().enabled = false;
        GameObject.Find("青铜鼎/关掉(2)").GetComponent<Button>().enabled = false;
        GameObject.Find("Mia_001138ab").GetComponent<SphereCollider>().enabled = true;
    }
}
