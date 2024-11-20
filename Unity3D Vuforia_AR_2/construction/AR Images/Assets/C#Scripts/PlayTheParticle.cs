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
/// 
/// <summary>
/// ���ע�ͣ���֣��
/// ����޸����ڣ�2024��11��12��
/// </summary>
public class PlayTheParticle : MonoBehaviour
{
    public GameObject TargetTang;//���ڴ洢������ͬ��3Dģ�ͣ�����ٸ��ͭʨ�Ͷ���������
    public GameObject TargetLion;
    public GameObject TargetDing;

    private AudioSource scanSuccessAudio; ///�洢������Ч��ɨ��ɹ���������Ч��������
    private AudioSource generateAudio;
    private ParticleSystem particleEffect;//�洢��Ч������ϵͳ��������
    private GameObject targetObject;// ���ڱ��浱ǰѡ�е�3Dģ�Ͷ���

    private void Start()
    {
        scanSuccessAudio = GameObject.Find("ɨ��ɹ�").GetComponent<AudioSource>();//��ȡ��Ч����ͨ���������ڳ����в��� AudioSource ���
        generateAudio = GameObject.Find("����").GetComponent<AudioSource>();
    }

    public void Play()
    {
        switch (transform.tag)//���ݵ�ǰ����� tag��������ı�ǩ����ѡ����Ч����Ч��3Dģ�͡�ͨ�� switch ����жϴ��������ĸ�Ŀ�꣨����ٸ��ͭʨ�򶦣�
        {
            case "Tang People":
                particleEffect = GameObject.Find("��Ч(1)").GetComponent<ParticleSystem>();
                targetObject = TargetTang;
                StartCoroutine(PlaySequence());//��Ӧѡ������Ч����Ч������һ��Э�� PlaySequence ��ִ�в���˳��
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

    private IEnumerator PlaySequence()//����������𲥷���Ч����Ч������һ��ʱ��󼤻���Ӧ��3Dģ�͡�
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

    public void DisappearTheModel()//���ݲ�ͬ�� tag �ر���Ӧ��3Dģ�͡����磬���������ٸģ�ͣ�TargetTang ����Ϊ false��������ģ�͡�
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
