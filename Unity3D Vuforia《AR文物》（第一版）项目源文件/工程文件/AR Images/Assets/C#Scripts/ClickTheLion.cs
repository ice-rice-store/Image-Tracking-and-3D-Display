using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// �������ߣ�С�ض�
/// �������ڣ�2023��1��4��
/// ����޸����ڣ�2024��7��25��
/// �ű�����λ�ã�ͭʨ���������µ�FBX untitled
/// ʵ�ֹ��ܣ����FBX untitled���ֶ�ӦUI
/// ��ע��
/// </summary>
public class ClickTheLion : MonoBehaviour
{
    private void OnMouseDown()
    {
        StartCoroutine(Open());
        GameObject.Find("FBX untitled").GetComponent<BoxCollider>().enabled = false;
        GameObject.Find("���").GetComponent<AudioSource>().Play();
    }
    IEnumerator Open()
    {
        GameObject.Find("ͭʨ").GetComponent<Image>().enabled = true;
        GameObject.Find("ͭʨ").GetComponent<CanvasGroup>().alpha += 0.25f;
        yield return new WaitForSeconds(0.1f);
        GameObject.Find("ͭʨ").GetComponent<CanvasGroup>().alpha += 0.25f;
        yield return new WaitForSeconds(0.1f);
        GameObject.Find("ͭʨ").GetComponent<CanvasGroup>().alpha += 0.25f;
        yield return new WaitForSeconds(0.1f);
        GameObject.Find("ͭʨ").GetComponent<CanvasGroup>().alpha += 0.25f;
        GameObject.Find("ͭʨ").GetComponent<Image>().enabled = true;
        GameObject.Find("ͭʨ/�ص�(1)").GetComponent<Image>().enabled = true;
        GameObject.Find("ͭʨ/�ص�(1)").GetComponent<Button>().enabled = true;
    }
    public void CloseTheUI()
    {
        StartCoroutine(Close());
    }
    IEnumerator Close()
    {

        GameObject.Find("ͭʨ").GetComponent<CanvasGroup>().alpha -= 0.25f;
        yield return new WaitForSeconds(0.1f);
        GameObject.Find("ͭʨ").GetComponent<CanvasGroup>().alpha -= 0.25f;
        yield return new WaitForSeconds(0.1f);
        GameObject.Find("ͭʨ").GetComponent<CanvasGroup>().alpha -= 0.25f;
        yield return new WaitForSeconds(0.1f);
        GameObject.Find("ͭʨ").GetComponent<CanvasGroup>().alpha -= 0.25f;
        GameObject.Find("ͭʨ").GetComponent<Image>().enabled = false;
        GameObject.Find("ͭʨ/�ص�(1)").GetComponent<Image>().enabled = false;
        GameObject.Find("ͭʨ/�ص�(1)").GetComponent<Button>().enabled = false;
        GameObject.Find("FBX untitled").GetComponent<BoxCollider>().enabled = true;
    }
}
