using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// �������ߣ�С�ض�
/// �������ڣ�2023��1��4��
/// ����޸����ڣ�2024��7��25��
/// �ű�����λ�ã��й��Ŵ���ͭ���������µ�Mia_001138ab
/// ʵ�ֹ��ܣ����Mia_001138ab���ֶ�ӦUI
/// ��ע��
/// </summary>
public class ClickTheDing : MonoBehaviour
{
    private void OnMouseDown()
    {
        StartCoroutine(Open());
        GameObject.Find("Mia_001138ab").GetComponent<SphereCollider>().enabled = false;
        GameObject.Find("���").GetComponent<AudioSource>().Play();
    }
    IEnumerator Open()
    {
        GameObject.Find("��ͭ��").GetComponent<Image>().enabled = true;
        GameObject.Find("��ͭ��").GetComponent<CanvasGroup>().alpha += 0.25f;
        yield return new WaitForSeconds(0.1f);
        GameObject.Find("��ͭ��").GetComponent<CanvasGroup>().alpha += 0.25f;
        yield return new WaitForSeconds(0.1f);
        GameObject.Find("��ͭ��").GetComponent<CanvasGroup>().alpha += 0.25f;
        yield return new WaitForSeconds(0.1f);
        GameObject.Find("��ͭ��").GetComponent<CanvasGroup>().alpha += 0.25f;
        GameObject.Find("��ͭ��").GetComponent<Image>().enabled = true;
        GameObject.Find("��ͭ��/�ص�(2)").GetComponent<Image>().enabled = true;
        GameObject.Find("��ͭ��/�ص�(2)").GetComponent<Button>().enabled = true;
    }
    public void CloseTheUI()
    {
        StartCoroutine(Close());
    }
    IEnumerator Close()
    {

        GameObject.Find("��ͭ��").GetComponent<CanvasGroup>().alpha -= 0.25f;
        yield return new WaitForSeconds(0.1f);
        GameObject.Find("��ͭ��").GetComponent<CanvasGroup>().alpha -= 0.25f;
        yield return new WaitForSeconds(0.1f);
        GameObject.Find("��ͭ��").GetComponent<CanvasGroup>().alpha -= 0.25f;
        yield return new WaitForSeconds(0.1f);
        GameObject.Find("��ͭ��").GetComponent<CanvasGroup>().alpha -= 0.25f;
        GameObject.Find("��ͭ��").GetComponent<Image>().enabled = false;
        GameObject.Find("��ͭ��/�ص�(2)").GetComponent<Image>().enabled = false;
        GameObject.Find("��ͭ��/�ص�(2)").GetComponent<Button>().enabled = false;
        GameObject.Find("Mia_001138ab").GetComponent<SphereCollider>().enabled = true;
    }
}
