using UnityEngine;
using UnityEngine.UI;

public class BGMPlayScripts : MonoBehaviour
{
    public AudioSource backgroundMusic;
    private Button playBtn;
    private bool playing = false;
    public AudioClip bgm;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playBtn = GameObject.Find("PlayButton").GetComponent<Button>();
        backgroundMusic = GameObject.Find("BGM").GetComponent<AudioSource>();
        bgm = Resources.Load("ha-undercurrent") as AudioClip;
        backgroundMusic.clip = bgm;

        playBtn.onClick.AddListener(PlayClick);

    }

    private void PlayClick()
    {
        if (playing)
        {
            backgroundMusic.Play();
        }
        else
        {
            backgroundMusic.Stop();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
