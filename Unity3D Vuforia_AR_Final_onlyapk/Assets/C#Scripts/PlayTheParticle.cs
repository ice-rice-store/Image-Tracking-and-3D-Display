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
    private AudioSource scanSuccessAudio; ///�洢������Ч��ɨ��ɹ���������Ч��������
    private AudioSource generateAudio;
    private ParticleSystem particleEffect;//�洢��Ч������ϵͳ��������

    GameObject targetObject;// ���ڱ��浱ǰѡ�е�3Dģ�Ͷ���

    IEnumerator myPlaySequence;

    private void Awake()
    {
        targetObject = transform.Find("Model").gameObject;
        //targetObject.SetActive(false);
        particleEffect = transform.Find("texiao").GetComponent<ParticleSystem>();
    }

    private void Start()
    {
        scanSuccessAudio = GameObject.Find("ɨ��ɹ�").GetComponent<AudioSource>();//��ȡ��Ч����ͨ���������ڳ����в��� AudioSource ���
        generateAudio = GameObject.Find("����").GetComponent<AudioSource>();

    }

    public void Play()
    {
        myPlaySequence = PlaySequence();
        StartCoroutine(myPlaySequence);
    }

    private IEnumerator PlaySequence()//����������𲥷���Ч����Ч������һ��ʱ��󼤻���Ӧ��3Dģ�͡�
    {
        yield return new WaitForSeconds(0.7f);
        //print("����ɨ������");
        scanSuccessAudio.Play();
        yield return new WaitForSeconds(0.5f);
        //print("�����������ֺ���Ч");
        generateAudio.Play();
        particleEffect.Play();
        yield return new WaitForSeconds(0.3f);
        //print("��ʾģ��");
        targetObject.SetActive(true);
        BtnJieShao.Instance.ShowOrHideBtnJieShao(true);
        yield return new WaitForSeconds(1.7f);
        particleEffect.Stop();
        //print("��Чֹͣ");
    }


    public void DisappearTheModel()
    {
        //ֹͣЭ��
        if(myPlaySequence != null)
            StopCoroutine(myPlaySequence);

        //ֹͣ��Ч
        if(scanSuccessAudio != null) 
            scanSuccessAudio.Stop();

        if (generateAudio!=null)
            generateAudio.Stop();

        //ֹͣ��Ч
        if(particleEffect != null)
            particleEffect.Stop();

        //����ģ��
        if (targetObject!=null)
            targetObject.SetActive(false);
    }
}
