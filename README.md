# SoundPJT250207
 25.02.07 Sound Track Project

```cs
//code test

using unityEngine;
public class Sample : MonoBehaviour
{
  void start()
  {
    Debug.Log("HELLO UNITY WORLD");
  }
}

```

### 오디오 믹서 (Audio Mixer)
- **오디오 소스에 대한 제어, 균형, 조정을 제공하는 도구** <br>
  믹서 만드는 방법 = Create -> Audio -> AudioMixer를 통해 Audio Group을 생성<br>
  최초 생성 시 Master 그룹이 존재<br>
---
  
![image](https://github.com/user-attachments/assets/a1f16d49-0db4-40c9-b5e2-9eb36fc44e0f) <br>
- 오디오 믹스 그룹 3개 만든 후에 Expose script 시키기 (3개 전부)  <br>
 \- ※ Attenuation 밑에 volume 우클릭 하면 나옴 <br>
 ![image](https://github.com/user-attachments/assets/b3a0af52-c531-483c-b614-b5322a3e3575) <br>
 \- Expose 시켜야 Script에서 조정 가능

---
![image](https://github.com/user-attachments/assets/280d463a-5d54-4288-a92a-98dd7107c682) <br>
Audio Mixer 우측에 해당 Expose Parameter를 클릭하여 Rename을 통해 이름 재설정, Script에서 해당 설정 이름으로 값 세팅

---
![image](https://github.com/user-attachments/assets/409e94b1-11f4-4b8c-bd7d-94cc74ae6f48) <br>
- Slider 작업 진행, Mixer 연결 작업
---
```
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
```
---
![image](https://github.com/user-attachments/assets/6772f637-d0e5-42d2-ab7a-cfe176aa6e54)<br>
- **Unity Recorder** 기능 -> Package Manager 에서 인스톨 필요
  - Window → General → recorder →  **Recorder window**
  - **Exit Play Mode** : 체크 되어있으면 녹화 끝나면 플레이도 끝
  - **Recording Mode** : Manual(사용자가 직접 녹화 설정 종료)
  - **Playback** : 녹화 중 일정 프레임 속도 유지
  - **Target FPS** : 녹화 FPS 지정
  - **Cap** : 설정한 FPS를 넘지않도록 제한
  - Add Recorder 우클릭 → **Move** : 나머지 설정은 기본 설정 그대로 사용하는 것 추천




```cs
// 유니티 에디터에서 GUI를 보여주는 시스템
// IMGUI : 디버그에서 사용

// UGUI : 일반적으로 사용하는 UI 도구

// UIElements : 에디터 기반으로 진행하는 도구
```



