using UnityEngine;

public class AudioSourceSample : MonoBehaviour
{
    // 0) �ν����Ϳ��� ���� �����ϴ� ���
    public AudioSource audioSourceBGM;

    // 1) AudioSourceSample ��ü�� ��ü������ ����� �ҽ��� ������ �ִ� ���
    //private AudioSource ownAudioSource;

    // 2) ������ ã�Ƽ� �����ϴ� ���
    public AudioSource audioSourceSFX;

    public AudioClip bgm; // ����� Ŭ���� ���� ����

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 1)�� ��� GetComponent<T>�� ���� �ش� ��ü�� ������ �ִ� ����� �ҽ� ���� ����
        //ownAudioSource = GetComponent<AudioSource>(); ������ BGM Object�� ���� �����ұ� ������ ���� �ȵ�

        // 2)�� ��� GameObject.Find().GetComponent<T> ���
        // GameObject.Find()�� ������ ã�� gameObject�� return�ϴ� ����� ������ ����. �� ���� gameObject��.
        // GameObject�̱� ������ GetComponent<T>�� �̾� �ۼ������� ������Ʈ�� ���� ������Ʈ�� ���� return
        // ���� AudioSource�� return ��.
        audioSourceSFX = GameObject.Find("SFX").GetComponent<AudioSource>();

        audioSourceBGM.clip = bgm;
        // ����� �ҽ��� Ŭ���� bgm���� �����մϴ�.

        // ����� �ҽ� ��ũ��Ʈ ���
        audioSourceBGM.Play(); // Ŭ�� ����
        //audioSourceBGM.Pause(); // �Ͻ�����
        //audioSourceSFX.PlayOneShot(bgm); // Ŭ�� �ϳ��� �Ѽ��� �÷���
        //audioSourceBGM.Stop(); // ����� Ŭ�� ��� ����
        //audioSourceBGM.UnPause(); // �Ͻ� ���� ����
        //audioSourceBGM.PlayDelayed(1.0f); // 1�� �ڿ� ���

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
