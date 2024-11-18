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
public class PlayTheParticle : MonoBehaviour
{
    public GameObject TargetTang;
    public GameObject TargetLion;
    public GameObject TargetDing;

    private AudioSource scanSuccessAudio;
    private AudioSource generateAudio;
    private ParticleSystem particleEffect;
    private GameObject targetObject;

    private void Start()
    {
        scanSuccessAudio = GameObject.Find("扫描成功").GetComponent<AudioSource>();
        generateAudio = GameObject.Find("生成").GetComponent<AudioSource>();
    }

    public void Play()
    {
        switch (transform.tag)
        {
            case "Tang People":
                particleEffect = GameObject.Find("特效(1)").GetComponent<ParticleSystem>();
                targetObject = TargetTang;
                StartCoroutine(PlaySequence());
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

    private IEnumerator PlaySequence()
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

    public void DisappearTheModel()
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
