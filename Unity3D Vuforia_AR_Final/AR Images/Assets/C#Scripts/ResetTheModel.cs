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
[DefaultExecutionOrder(100)]
public class ResetTheModel : MonoBehaviour
{
    Vector3 pos;
    Vector3 rot;
    Vector3 scale;

    private void Awake()
    {
        pos = this.transform.localPosition;
        rot = this.transform.localEulerAngles;
        scale = this.transform.localScale;
        print("scale:" + scale);
        print("rot:" + rot);

        this.gameObject.SetActive(false);
    }

    public void ResetModel()
    {
        this.transform.localPosition = pos;
        this.transform.localEulerAngles = rot;
        this.transform.localScale = scale;

    }

    //private void Update()
    //{
    //    if (transform.tag == "Tang People")
    //    {
    //        transform.localPosition = new Vector3(0f, 0f, 0f);
    //    }
    //    if (transform.tag == "Bronze Lion")
    //    {
    //        transform.localPosition = new Vector3(0f, 0f, 0f);
    //    }
    //    if (transform.tag == "Tripod")
    //    {
    //        transform.localPosition = new Vector3(0f, 0f, 0f);
    //    }
    //}
}
