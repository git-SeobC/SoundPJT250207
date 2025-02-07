using UnityEngine;
using UnityEngine.UI;

public class BGMPlayScripts : MonoBehaviour
{
    public AudioSource backgroundMusic;
    public Button playBtn;
    private bool playing = false;
    public AudioClip bgm;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playBtn = GameObject.Find("PlayButton").GetComponent<Button>();
        backgroundMusic = GameObject.Find("BGM").GetComponent<AudioSource>();
        bgm = Resources.Load("ha-backrooms") as AudioClip;
        backgroundMusic.clip = bgm;

        playBtn.onClick.AddListener(PlayClick);

    }

    public void PlayClick()
    {
        Debug.Log("PlayClick");
        if (!playing)
        {
            Debug.Log("play");
            backgroundMusic.Play();
            playing = true;
        }
        else
        {
            Debug.Log("stop");
            backgroundMusic.Stop();
            playing = false;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
