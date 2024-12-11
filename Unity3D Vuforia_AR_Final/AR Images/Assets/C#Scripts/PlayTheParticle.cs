using System.Collections;
using UnityEngine;
/// <summary>
/// 代码作者：小贺儿
/// 编码日期：2023年1月4日
/// 最后修改日期：2024年7月25日
/// 脚本挂载位置：彩绘唐人俑、铜狮雕塑、中国古代青铜器鼎物体
/// 实现功能：扫描识别图出现特效、播放扫描成功音效、出现模型
/// 备注：注意脚本关联设置
/// </summary>
/// 
/// <summary>
/// 添加注释：严郑康
/// 最后修改日期：2024年11月12日
/// </summary>
public class PlayTheParticle : MonoBehaviour
{
    private AudioSource scanSuccessAudio; ///存储两个音效（扫描成功和生成音效）的引用
    private AudioSource generateAudio;
    private ParticleSystem particleEffect;//存储特效（粒子系统）的引用

    GameObject targetObject;// 用于保存当前选中的3D模型对象

    IEnumerator myPlaySequence;

    private void Awake()
    {
        targetObject = transform.Find("Model").gameObject;
        //targetObject.SetActive(false);
        particleEffect = transform.Find("texiao").GetComponent<ParticleSystem>();
    }

    private void Start()
    {
        scanSuccessAudio = GameObject.Find("扫描成功").GetComponent<AudioSource>();//获取音效对象，通过其名字在场景中查找 AudioSource 组件
        generateAudio = GameObject.Find("生成").GetComponent<AudioSource>();

    }

    public void Play()
    {
        myPlaySequence = PlaySequence();
        StartCoroutine(myPlaySequence);
    }

    private IEnumerator PlaySequence()//这个方法负责播放特效、音效，并在一定时间后激活相应的3D模型。
    {
        yield return new WaitForSeconds(0.7f);
        //print("播放扫描音乐");
        scanSuccessAudio.Play();
        yield return new WaitForSeconds(0.5f);
        //print("播放生成音乐和特效");
        generateAudio.Play();
        particleEffect.Play();
        yield return new WaitForSeconds(0.3f);
        //print("显示模型");
        targetObject.SetActive(true);
        BtnJieShao.Instance.ShowOrHideBtnJieShao(true);
        yield return new WaitForSeconds(1.7f);
        particleEffect.Stop();
        //print("特效停止");
    }


    public void DisappearTheModel()
    {
        //停止协程
        if(myPlaySequence != null)
            StopCoroutine(myPlaySequence);

        //停止音效
        if(scanSuccessAudio != null) 
            scanSuccessAudio.Stop();

        if (generateAudio!=null)
            generateAudio.Stop();

        //停止特效
        if(particleEffect != null)
            particleEffect.Stop();

        //隐藏模型
        if (targetObject!=null)
            targetObject.SetActive(false);
    }
}
