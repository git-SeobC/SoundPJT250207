using UnityEngine;

public class AudioSourceSample : MonoBehaviour
{
    // 0) 인스펙터에서 직접 연결하는 경우
    public AudioSource audioSourceBGM;

    // 1) AudioSourceSample 객체가 자체적으로 오디오 소스를 가지고 있는 경우
    //private AudioSource ownAudioSource;

    // 2) 씬에서 찾아서 연결하는 경우
    public AudioSource audioSourceSFX;

    public AudioClip bgm; // 오디오 클립에 대한 연결

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 1)의 경우 GetComponent<T>를 통해 해당 객체가 가지고 있는 오디오 소스 연결 가능
        //ownAudioSource = GetComponent<AudioSource>(); 지금은 BGM Object로 따로 빼놓았기 때문에 연결 안됨

        // 2)의 경우 GameObject.Find().GetComponent<T> 사용
        // GameObject.Find()는 씬에서 찾은 gameObject를 return하는 기능을 가지고 있음. 이 값은 gameObject임.
        // GameObject이기 때문에 GetComponent<T>를 이어 작성함으로 오브젝트가 가진 컴포넌트의 값을 return
        // 따라서 AudioSource가 return 됨.
        audioSourceSFX = GameObject.Find("SFX").GetComponent<AudioSource>();

        audioSourceBGM.clip = bgm;
        // 오디오 소스의 클립을 bgm으로 설정합니다.

        // 오디오 소스 스크립트 기능
        audioSourceBGM.Play(); // 클립 실행
        //audioSourceBGM.Pause(); // 일시정지
        //audioSourceSFX.PlayOneShot(bgm); // 클립 하나를 한순간 플레이
        //audioSourceBGM.Stop(); // 오디오 클립 재생 중지
        //audioSourceBGM.UnPause(); // 일시 정지 해제
        //audioSourceBGM.PlayDelayed(1.0f); // 1초 뒤에 재생

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
