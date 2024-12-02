using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnJieShao : MonoBehaviour
{
    public static BtnJieShao Instance;

    public Button btn;

    private void Awake()
    {
        btn = GetComponent<Button>();
        Instance = this;
    }

    private void Start()
    {
        btn.gameObject.SetActive(false);
    }

    public void ShowOrHideBtnJieShao(bool isShow)
    {
        if(btn!=null)
            btn.gameObject.SetActive(isShow);
    }

    public void EnableBtn(bool isEnable)
    {
        if (btn != null)
            btn.enabled = isEnable;
    }

}
