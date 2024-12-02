using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �������ߣ�С�ض�
/// �������ڣ�2023��1��4��
/// ����޸����ڣ�2024��7��25��
/// �ű�����λ�ã��ʻ�����ٸ��ͭʨ���ܡ��й��Ŵ���ͭ��������
/// ʵ�ֹ��ܣ�����ģ�ͽ���
/// ��ע�����ڴ����������Ч
/// </summary>
public class Scale : MonoBehaviour
{
    public static bool isScaling; // ״̬��־
    Vector2 oldPos1;
    Vector2 oldPos2;

    void Update()
    {
        if (Input.touchCount == 2)
        {
            Vector2 temPos1 = Input.GetTouch(0).position;
            Vector2 temPos2 = Input.GetTouch(1).position;

            // �ж���ָ�Ƿ��෴�����ƶ�
            Vector2 deltaPos1 = Input.GetTouch(0).deltaPosition;
            Vector2 deltaPos2 = Input.GetTouch(1).deltaPosition;

            if (Input.GetTouch(0).phase == TouchPhase.Moved || Input.GetTouch(1).phase == TouchPhase.Moved)
            {
                // ������ָ�����ĽǶ�
                float angle1 = Vector2.SignedAngle(Vector2.up, deltaPos1);
                float angle2 = Vector2.SignedAngle(Vector2.up, deltaPos2);

                // �ж�������ָ�Ļ��������Ƿ��෴
                if (Mathf.Abs(angle1 - angle2) > 90) // ����ǶȲ����90�ȣ������෴
                {
                    isScaling = true; // ��ʼ����
                    if (isEnLarge(oldPos1, oldPos2, temPos1, temPos2))
                    {
                        float oldScale = transform.localScale.x;
                        float newScale = oldScale * 1.025f; // �Ŵ�

                        transform.localScale = new Vector3(newScale, newScale, newScale);
                    }
                    else
                    {
                        float oldScale = transform.localScale.x;
                        float newScale = oldScale / 1.025f; // ��С

                        transform.localScale = new Vector3(newScale, newScale, newScale);
                    }

                    oldPos1 = temPos1;
                    oldPos2 = temPos2;
                }
            }
        }
        else
        {
            isScaling = false; // ��������
        }
    }

    bool isEnLarge(Vector2 oP1, Vector2 oP2, Vector2 nP1, Vector2 nP2)
    {
        float length1 = Mathf.Sqrt((oP1.x - oP2.x) * (oP1.x - oP2.x) + (oP1.y - oP2.y) * (oP1.y - oP2.y));
        float length2 = Mathf.Sqrt((nP1.x - nP2.x) * (nP1.x - nP2.x) + (nP1.y - nP2.y) * (nP1.y - nP2.y));

        return length1 < length2; // �����Ƿ�Ŵ�
    }
}
