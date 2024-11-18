using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// �������ߣ�С�ض�
/// �������ڣ�2023��1��4��
/// ����޸����ڣ�2024��7��25��
/// �ű�����λ�ã��ʻ�����ٸ��ͭʨ���ܡ��й��Ŵ���ͭ��������
/// ʵ�ֹ��ܣ���ԭģ��Transform������λ�á���ת������ֵ��
/// ��ע��
/// </summary>
public class ResetTheModelPosition : MonoBehaviour
{
    public void ResetTheModel()
    {
        if (transform.tag == "Tang People")
        {
            transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
            transform.localRotation = Quaternion.Euler(new Vector3(0f, -90f, 0f));
        }
        if (transform.tag == "Bronze Lion")
        {
            transform.localScale = new Vector3(0.07f, 0.07f, 0.07f);
            transform.localRotation = Quaternion.Euler(new Vector3(0f, 90f, 0f));
        }
        if (transform.tag == "Tripod")
        {
            transform.localScale = new Vector3(3.0f, 3.0f, 3.0f);
            transform.localRotation = Quaternion.Euler(new Vector3(0f, -90f, 0f));
        }
    }
    private void Update()
    {
        if (transform.tag == "Tang People")
        {
            transform.localPosition = new Vector3(0f, 0f, 0f);
        }
        if (transform.tag == "Bronze Lion")
        {
            transform.localPosition = new Vector3(0f, 0f, 0f);
        }
        if (transform.tag == "Tripod")
        {
            transform.localPosition = new Vector3(0f, 0f, 0f);
        }
    }
}
