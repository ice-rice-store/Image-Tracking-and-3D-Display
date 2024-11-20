using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// 代码作者：小贺儿
/// 编码日期：2023年1月4日
/// 最后修改日期：2024年7月25日
/// 脚本挂载位置：彩绘唐人俑物体下的untitled
/// 实现功能：点击untitled出现对应UI
/// 备注：
/// </summary>
public class ClickTheTang : MonoBehaviour
{
    private void OnMouseDown()
    {
        StartCoroutine(Open());
        GameObject.Find("untitled").GetComponent<CapsuleCollider>().enabled = false;
        GameObject.Find("点击").GetComponent<AudioSource>().Play();
    }
    IEnumerator Open()
    {
        GameObject.Find("唐人俑").GetComponent<Image>().enabled = true;
        GameObject.Find("唐人俑").GetComponent<CanvasGroup>().alpha += 0.25f;
        yield return new WaitForSeconds(0.1f);
        GameObject.Find("唐人俑").GetComponent<CanvasGroup>().alpha += 0.25f;
        yield return new WaitForSeconds(0.1f);
        GameObject.Find("唐人俑").GetComponent<CanvasGroup>().alpha += 0.25f;
        yield return new WaitForSeconds(0.1f);
        GameObject.Find("唐人俑").GetComponent<CanvasGroup>().alpha += 0.25f;
        GameObject.Find("唐人俑/关掉").GetComponent<Image>().enabled = true;
        GameObject.Find("唐人俑/关掉").GetComponent<Button>().enabled = true;
    }
    public void CloseTheUI()
    {
        StartCoroutine(Close());
    }
    IEnumerator Close()
    {

        GameObject.Find("唐人俑").GetComponent<CanvasGroup>().alpha -= 0.25f;
        yield return new WaitForSeconds(0.1f);
        GameObject.Find("唐人俑").GetComponent<CanvasGroup>().alpha -= 0.25f;
        yield return new WaitForSeconds(0.1f);
        GameObject.Find("唐人俑").GetComponent<CanvasGroup>().alpha -= 0.25f;
        yield return new WaitForSeconds(0.1f);
        GameObject.Find("唐人俑").GetComponent<CanvasGroup>().alpha -= 0.25f;
        GameObject.Find("唐人俑").GetComponent<Image>().enabled = false;
        GameObject.Find("唐人俑/关掉").GetComponent<Image>().enabled = false;
        GameObject.Find("唐人俑/关掉").GetComponent<Button>().enabled = false;
        GameObject.Find("untitled").GetComponent<CapsuleCollider>().enabled = true;
    }
}
