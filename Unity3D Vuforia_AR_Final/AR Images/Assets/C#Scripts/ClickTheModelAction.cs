using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia.ARFoundation;
/// <summary>
/// 代码作者：小贺儿
/// 编码日期：2023年1月4日
/// 最后修改日期：2024年7月25日
/// 脚本挂载位置：中国古代青铜器鼎物体下的Mia_001138ab
/// 实现功能：点击Mia_001138ab出现对应UI
/// 备注：
/// </summary>
public class ClickTheModelAction : MonoBehaviour
{
    public CanvasGroup imgCanvasGroup; //解说图片
    public Button btnClose;            //关闭按钮
    AudioSource clickAudio;
    Collider myCollider;

    IEnumerator myOpen;
    IEnumerator myClose;

    private void Awake()
    {
        clickAudio = GameObject.Find("音效").transform.Find("点击").GetComponent<AudioSource>();
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
        //停止两个协程
        if(myOpen != null)
        {
            StopCoroutine(myOpen);
        }
        if(myClose != null) 
        { 
            StopCoroutine(myClose);
        }

        //隐藏图片
        if (imgCanvasGroup != null)
        {
            imgCanvasGroup.alpha = 0;
            imgCanvasGroup.GetComponent<Image>().enabled = false;
        }

        //隐藏关闭按钮
        if(btnClose!=null)
        {
            btnClose.image.enabled = false;
            btnClose.enabled = false;
        }

        //允许模型点击
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
