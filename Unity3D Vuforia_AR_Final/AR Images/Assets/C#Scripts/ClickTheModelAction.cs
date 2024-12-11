using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia.ARFoundation;
/// <summary>
/// �������ߣ�С�ض�
/// �������ڣ�2023��1��4��
/// ����޸����ڣ�2024��7��25��
/// �ű�����λ�ã��й��Ŵ���ͭ���������µ�Mia_001138ab
/// ʵ�ֹ��ܣ����Mia_001138ab���ֶ�ӦUI
/// ��ע��
/// </summary>
public class ClickTheModelAction : MonoBehaviour
{
    public CanvasGroup imgCanvasGroup; //��˵ͼƬ
    public Button btnClose;            //�رհ�ť
    AudioSource clickAudio;
    Collider myCollider;

    IEnumerator myOpen;
    IEnumerator myClose;

    private void Awake()
    {
        clickAudio = GameObject.Find("��Ч").transform.Find("���").GetComponent<AudioSource>();
        myCollider = transform.Find("Model").GetComponent<Collider>();

        btnClose.onClick.AddListener(CloseTheUI);
    }

    private void Start()
    {
        BtnJieShao.Instance.btn.onClick.AddListener(ClickModel);
       
    }

    public void ClickModel()
    {
        if(myCollider.gameObject.activeSelf)
        {
            BtnJieShao.Instance.EnableBtn(false);
            myOpen = Open();
            StartCoroutine(myOpen);

            myCollider.enabled = false;
            clickAudio.Play();
        }
    }

    public void HideUI()
    {
        //ֹͣ����Э��
        if(myOpen != null)
        {
            StopCoroutine(myOpen);
        }
        if(myClose != null) 
        { 
            StopCoroutine(myClose);
        }

        //����ͼƬ
        if (imgCanvasGroup != null)
        {
            imgCanvasGroup.alpha = 0;
            imgCanvasGroup.GetComponent<Image>().enabled = false;
        }

        //���عرհ�ť
        if(btnClose!=null)
        {
            btnClose.image.enabled = false;
            btnClose.enabled = false;
        }

        //����ģ�͵��
        if(myCollider!=null)
            myCollider.enabled = true;
    }

    IEnumerator Open()
    {
        imgCanvasGroup.GetComponent<Image>().enabled = true;
        imgCanvasGroup.alpha += 0.25f;
        yield return new WaitForSeconds(0.1f);
        imgCanvasGroup.alpha += 0.25f;
        yield return new WaitForSeconds(0.1f);
        imgCanvasGroup.alpha += 0.25f;
        yield return new WaitForSeconds(0.1f);
        imgCanvasGroup.alpha += 0.25f;

        btnClose.image.enabled = true;
        btnClose.enabled = true;
    }


    void CloseTheUI()
    {
        myClose = Close();
        StartCoroutine(myClose);
    }

    public IEnumerator Close()
    {
        imgCanvasGroup.alpha -= 0.25f;
        yield return new WaitForSeconds(0.1f);
        imgCanvasGroup.alpha -= 0.25f;
        yield return new WaitForSeconds(0.1f);
        imgCanvasGroup.alpha -= 0.25f;
        yield return new WaitForSeconds(0.1f);
        imgCanvasGroup.alpha -= 0.25f;
        imgCanvasGroup.GetComponent<Image>().enabled = false;

        btnClose.image.enabled = false;
        btnClose.enabled = false;

        myCollider.enabled = true;

        BtnJieShao.Instance.EnableBtn(true);
    }

}
