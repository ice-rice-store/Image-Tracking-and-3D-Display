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
public class ClickTheModel : MonoBehaviour
{

    ClickTheModelAction clickAction;

    private void Awake()
    {
        clickAction = transform.parent.GetComponent<ClickTheModelAction>();
    }

    //���ģ������
    //private void OnMouseDown()
    //{
    //    clickAction.ClickModel();
    //}
}
