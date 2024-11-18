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
    Vector2 oldPos1;
    Vector2 oldPos2;
    void Update()
    {
        if (Input.touchCount == 2)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Moved || Input.GetTouch(1).phase == TouchPhase.Moved)
            {
                Vector2 temPos1 = Input.GetTouch(0).position;
                Vector2 temPos2 = Input.GetTouch(1).position;

                if (isEnLarge(oldPos1, oldPos2, temPos1, temPos2))
                {
                    float oldScale = transform.localScale.x;
                    //�Ŵ�ı��� ���Ҫ�޸� ����:oldScale * 1.025f �޸ĳ� oldScale * 1.25f �����Լ������޸�
                    float newScale = oldScale * 1.025f;

                    transform.localScale = new Vector3(newScale, newScale, newScale);
                }
                else
                {
                    float oldScale = transform.localScale.x;
                    //��С�ı��� ���Ҫ�޸� ����:oldScale / 1.025f �޸ĳ� oldScale / 1.25f �����Լ������޸�
                    float newScale = oldScale / 1.025f;

                    transform.localScale = new Vector3(newScale, newScale, newScale);
                }

                oldPos1 = temPos1;
                oldPos2 = temPos2;

            }
        }
    }

    bool isEnLarge(Vector2 oP1, Vector2 oP2, Vector2 nP1, Vector2 nP2)
    {

        float length1 = Mathf.Sqrt((oP1.x - oP2.x) * (oP1.x - oP2.x) + (oP1.y - oP2.y) * (oP1.y - oP2.y));
        float length2 = Mathf.Sqrt((nP1.x - nP2.x) * (nP1.x - nP2.x) + (nP1.y - nP2.y) * (nP1.y - nP2.y));

        if (length1 < length2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}