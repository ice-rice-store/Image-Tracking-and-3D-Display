using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// �������ߣ�С�ض�
/// �������ڣ�2023��1��4��
/// ����޸����ڣ�2024��7��25��
/// �ű�����λ�ã��ʻ�����ٸ��ͭʨ���ܡ��й��Ŵ���ͭ��������
/// ʵ�ֹ��ܣ���תģ�ͽ���
/// ��ע�����ڴ����������Ч
/// </summary>
public class Rotate : MonoBehaviour
{
    //�ٶ�
    float xSpeed = 200f;
    void Update()
    {
        //�����������Ļ
        if (Input.GetMouseButton(0))
        {
            //�ж��Ǽ�����ָ����
            if (Input.touchCount == 1)
            {
                //��һ����������ָͷ phase״̬ Moved����
                if (Input.GetTouch(0).phase == TouchPhase.Moved)
                {
                    //��������ת�� ģ������ ��ҪΧ����һ������ת Vector3.up��Χ��Y��ת
                    transform.Rotate(-Vector3.up * Input.GetAxis("Mouse X") * xSpeed * Time.deltaTime);
                }
            }
        }
        // �����ָ˫��
        if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            if (Input.GetTouch(0).tapCount == 2)
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
        }
    }
}