using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �������ߣ�С�ض�
/// �������ڣ�2023��1��4��
/// ����޸����ڣ�2024��11��2��
/// �ű�����λ�ã��ʻ�����ٸ��ͭʨ���ܡ��й��Ŵ���ͭ��������
/// ʵ�ֹ��ܣ���תģ�ͽ���
/// ��ע�����ڴ����������Ч
/// </summary>
/// <summary>
/// �Ż�����֣��
/// �������ڣ�2024��11��2��
/// ����޸����ڣ�2024��11��2��
/// �Ż����ݹ��ܣ�
///     ����ԭ��ˮƽ��ת�Ļ����ϣ������ֱ������ת�Ĺ���
///     ���Ż���ת�ٶ�

/// </summary>
public class Rotate : MonoBehaviour
{
    // �ٶ�
    float xSpeed = 20f; // �޸�Ϊ0.1��
    float ySpeed = 200f;

    void Update()
    {
        // �����������Ļ
        if (Input.touchCount == 1 && !Scale.isScaling)
        {
            // ����ָ��������Y����ת
            if (Input.GetTouch(0).phase == TouchPhase.Moved)
            {
                transform.Rotate(-Vector3.up * Input.GetAxis("Mouse X") * ySpeed * Time.deltaTime);
            }
        }
        else if (Input.touchCount == 2 && !Scale.isScaling)
        {
            // ����˫ָ�������ж�������ָ�Ƿ�ͬһ�����򻬶�
            Vector2 touch0Delta = Input.GetTouch(0).deltaPosition;
            Vector2 touch1Delta = Input.GetTouch(1).deltaPosition;

            // �ж�������ָ�Ļ��������Ƿ�һ��
            if (Vector2.Dot(touch0Delta.normalized, touch1Delta.normalized) > 0)
            {
                // ���㻬������������ת����X����ת
                float deltaY = (touch0Delta.y + touch1Delta.y) * 0.1f; // ʹ��0.1�����ٶ�
                transform.Rotate(Vector3.right * deltaY);
            }
        }


        // �����ָ˫��
        if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            if (Input.GetTouch(0).tapCount == 2)
            {
                ResetScaleAndRotation();
            }
        }

    }

    private void ResetScaleAndRotation()
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
