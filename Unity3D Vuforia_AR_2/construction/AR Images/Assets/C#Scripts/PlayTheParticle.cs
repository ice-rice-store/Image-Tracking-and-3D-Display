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
    public GameObject TargetTang;//用于存储三个不同的3D模型（唐人俑、铜狮和鼎）的引用
    public GameObject TargetLion;
    public GameObject TargetDing;

    private AudioSource scanSuccessAudio; ///存储两个音效（扫描成功和生成音效）的引用
    private AudioSource generateAudio;
    private ParticleSystem particleEffect;//存储特效（粒子系统）的引用
    private GameObject targetObject;// 用于保存当前选中的3D模型对象

    private void Start()
    {
        scanSuccessAudio = GameObject.Find("扫描成功").GetComponent<AudioSource>();//获取音效对象，通过其名字在场景中查找 AudioSource 组件
        generateAudio = GameObject.Find("生成").GetComponent<AudioSource>();
    }

    public void Play()
    {
        switch (transform.tag)//根据当前对象的 tag（即物体的标签）来选择特效、音效和3D模型。通过 switch 语句判断触发的是哪个目标（唐人俑、铜狮或鼎）
        {
            case "Tang People":
                particleEffect = GameObject.Find("特效(1)").GetComponent<ParticleSystem>();
                targetObject = TargetTang;
                StartCoroutine(PlaySequence());//对应选择了特效、音效后，启动一个协程 PlaySequence 来执行播放顺序
                break;
            case "Bronze Lion":
                particleEffect = GameObject.Find("特效(2)").GetComponent<ParticleSystem>();
                targetObject = TargetLion;
                StartCoroutine(PlaySequence());
                break;
            case "Tripod":
                particleEffect = GameObject.Find("特效(3)").GetComponent<ParticleSystem>();
                targetObject = TargetDing;
                StartCoroutine(PlaySequence());
                break;
        }
    }

    private IEnumerator PlaySequence()//这个方法负责播放特效、音效，并在一定时间后激活相应的3D模型。
    {
        yield return new WaitForSeconds(0.7f);
        scanSuccessAudio.Play();
        yield return new WaitForSeconds(0.5f);
        generateAudio.Play();
        particleEffect.Play();
        yield return new WaitForSeconds(0.3f);
        targetObject.SetActive(true);
        yield return new WaitForSeconds(1.7f);
        particleEffect.Stop();
    }

    public void DisappearTheModel()//根据不同的 tag 关闭相应的3D模型。比如，如果是唐人俑模型，TargetTang 被设为 false，即隐藏模型。
    {
        switch (transform.tag)
        {
            case "Tang People":
                TargetTang.SetActive(false);
                break;
            case "Bronze Lion":
                TargetLion.SetActive(false);
                break;
            case "Tripod":
                TargetDing.SetActive(false);
                break;
        }
    }
}
