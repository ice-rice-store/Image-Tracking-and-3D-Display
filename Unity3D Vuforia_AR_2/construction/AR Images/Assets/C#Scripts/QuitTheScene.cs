using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// �������ߣ�С�ض�
/// �������ڣ�2023��1��4��
/// ����޸����ڣ�2024��7��25��
/// �ű�����λ�ã�Canvas�µ��˳�����
/// ʵ�ֹ��ܣ���������
/// ��ע�����ڴ����������Ч
/// </summary>
public class QuitTheScene : MonoBehaviour
{
    
     public void Quit()
    {
        StartCoroutine(Close());
        GameObject.Find("Canvas(գ��)").GetComponent<RawImage>().enabled = true;
    }
    IEnumerator Close()
    {
        GameObject.Find("Canvas(գ��)").GetComponent<CanvasGroup>().alpha += 0.25f;
        yield return new WaitForSeconds(0.1f);
        GameObject.Find("Canvas(գ��)").GetComponent<CanvasGroup>().alpha += 0.25f;
        yield return new WaitForSeconds(0.1f);
        GameObject.Find("Canvas(գ��)").GetComponent<CanvasGroup>().alpha += 0.25f;
        yield return new WaitForSeconds(0.1f);
        GameObject.Find("Canvas(գ��)").GetComponent<CanvasGroup>().alpha += 0.25f;
        Application.Quit();
    }
}
