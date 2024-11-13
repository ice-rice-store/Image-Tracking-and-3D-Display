using System.Collections;
using UnityEngine;
/// <summary>
/// �������ߣ�С�ض�
/// �������ڣ�2023��1��4��
/// ����޸����ڣ�2024��7��25��
/// �ű�����λ�ã��ʻ�����ٸ��ͭʨ���ܡ��й��Ŵ���ͭ��������
/// ʵ�ֹ��ܣ�ɨ��ʶ��ͼ������Ч������ɨ��ɹ���Ч������ģ��
/// ��ע��ע��ű���������
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
        scanSuccessAudio = GameObject.Find("ɨ��ɹ�").GetComponent<AudioSource>();
        generateAudio = GameObject.Find("����").GetComponent<AudioSource>();
    }

    public void Play()
    {
        switch (transform.tag)
        {
            case "Tang People":
                particleEffect = GameObject.Find("��Ч(1)").GetComponent<ParticleSystem>();
                targetObject = TargetTang;
                StartCoroutine(PlaySequence());
                break;
            case "Bronze Lion":
                particleEffect = GameObject.Find("��Ч(2)").GetComponent<ParticleSystem>();
                targetObject = TargetLion;
                StartCoroutine(PlaySequence());
                break;
            case "Tripod":
                particleEffect = GameObject.Find("��Ч(3)").GetComponent<ParticleSystem>();
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
