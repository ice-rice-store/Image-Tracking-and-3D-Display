using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// �������ߣ�С�ض�
/// �������ڣ�2023��1��4��
/// ����޸����ڣ�2024��7��25��
/// �ű�����λ�ã��ʻ�����ٸ�����µ�untitled
/// ʵ�ֹ��ܣ����untitled���ֶ�ӦUI
/// ��ע��
/// </summary>
public class ClickTheTang : MonoBehaviour
{
    private void OnMouseDown()
    {
        StartCoroutine(Open());
        GameObject.Find("untitled").GetComponent<CapsuleCollider>().enabled = false;
        GameObject.Find("���").GetComponent<AudioSource>().Play();
    }
    IEnumerator Open()
    {
        GameObject.Find("����ٸ").GetComponent<Image>().enabled = true;
        GameObject.Find("����ٸ").GetComponent<CanvasGroup>().alpha += 0.25f;
        yield return new WaitForSeconds(0.1f);
        GameObject.Find("����ٸ").GetComponent<CanvasGroup>().alpha += 0.25f;
        yield return new WaitForSeconds(0.1f);
        GameObject.Find("����ٸ").GetComponent<CanvasGroup>().alpha += 0.25f;
        yield return new WaitForSeconds(0.1f);
        GameObject.Find("����ٸ").GetComponent<CanvasGroup>().alpha += 0.25f;
        GameObject.Find("����ٸ/�ص�").GetComponent<Image>().enabled = true;
        GameObject.Find("����ٸ/�ص�").GetComponent<Button>().enabled = true;
    }
    public void CloseTheUI()
    {
        StartCoroutine(Close());
    }
    IEnumerator Close()
    {

        GameObject.Find("����ٸ").GetComponent<CanvasGroup>().alpha -= 0.25f;
        yield return new WaitForSeconds(0.1f);
        GameObject.Find("����ٸ").GetComponent<CanvasGroup>().alpha -= 0.25f;
        yield return new WaitForSeconds(0.1f);
        GameObject.Find("����ٸ").GetComponent<CanvasGroup>().alpha -= 0.25f;
        yield return new WaitForSeconds(0.1f);
        GameObject.Find("����ٸ").GetComponent<CanvasGroup>().alpha -= 0.25f;
        GameObject.Find("����ٸ").GetComponent<Image>().enabled = false;
        GameObject.Find("����ٸ/�ص�").GetComponent<Image>().enabled = false;
        GameObject.Find("����ٸ/�ص�").GetComponent<Button>().enabled = false;
        GameObject.Find("untitled").GetComponent<CapsuleCollider>().enabled = true;
    }
}
