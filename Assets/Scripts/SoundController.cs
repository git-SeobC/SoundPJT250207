using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

// 유니티 에디터에서 GUI를 보여주는 시스템
// IMGUI : 디버그에서 사용

// UGUI : 일반적으로 사용하는 UI 도구

// UIElements : 에디터 기반으로 진행하는 도구



// 슬라이더(Slider)는 UI

// SliderJoint2D
// Rigidbody 물리 제어를 받은 게임 오브젝트가 공간에서 선을 따라 미끄러지게 하는 설정을 할 때 사용
// ex) 미닫이문

public class SoundController : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;
    [SerializeField] private Slider volumeSliderMaster;
    [SerializeField] private Slider volumeSliderBGM;
    [SerializeField] private Slider volumeSliderSFX;


    // 자주 사용되는 Mathf 함수
    // 1. Mathf.Deg2Rad
    // : degree(60분법)을 통해 radian(호도법)을 계산 => 각도 계산
    // PI / 180 , PI * 2 / 360

    // 2. Mathf.Rad2Deg
    // : radian 값을 degree로
    // 360 / (PI * 2)
    // 1 rad = 60º

    // 3. Mathf.Abs
    // : 절대 값 계산

    // 4. Mathf.Atan
    // : 아크 탄젠트 값 계산

    // 5. Mathf.Ceil
    // : 소수점 올림 계산

    // 6. Mathf.Clamp(value, min, max)
    // : value를 min 과 max 사이의 값으로 고정

    // 7. Mathf.Log10
    // : 베이스가 10으로 지정되어있는 수의 로그를 반환해주는 기능
    // ex) Mathf.Log10(100)

    // 이번 예제에서 오디오 믹서의 최대 ~ 최대 볼륨 값 때문에 로그 함수 사용
    // 최소가 -80, 최대가 0
    // 그래서 수치 변경시 Mathf.Log10(슬라이더 수치) * 20 을 통해 범위를 설정하고,
    // 슬라이더 최소 값이 0.0001일 경우 -80이, 1일 경우 0이 계산됨.


    private void Awake()
    {
        volumeSliderMaster.onValueChanged.AddListener(SetMaster);
        volumeSliderBGM.onValueChanged.AddListener(SetBGM);
        volumeSliderSFX.onValueChanged.AddListener(SetSFX);
    }

    private void SetSFX(float volume)
    {
        audioMixer.SetFloat("SFX", Mathf.Log10(volume) * 20);
    }

    private void SetBGM(float volume)
    {
        audioMixer.SetFloat("BGM", Mathf.Log10(volume) * 20);
    }

    private void SetMaster(float volume)
    {
        // 오디오믹서가 가지고 있는 파라미터(Expose)의 수치를 설정하는 기능
        audioMixer.SetFloat("Master", Mathf.Log10(volume) * 20);

    }
}
