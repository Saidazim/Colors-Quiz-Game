using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public GameObject soundOn, SoundOff;
    public Sprite green, red;
    public bool m1;

    void Start()
    {
        
        if (gameObject.name == "Sound")
        {
            if (PlayerPrefs.GetString("Sound") == "no")
            {
                soundOn.SetActive(false);
                SoundOff.SetActive(true);
            }
            else
            {
                soundOn.SetActive(true);
                SoundOff.SetActive(false);
            }
        }
        
    }
    void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().sprite = red;
    }

    void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().sprite = green;
    }

    void OnMouseUpAsButton()
    {
        if (PlayerPrefs.GetString("Sound") != "no")
            GameObject.Find("ClickAudio").GetComponent<AudioSource>().Play();

        switch (gameObject.name)
        {
            case "Play":
                SceneManager.LoadScene("play");
                break;
            case "Quit":
                Application.Quit();
                break;
            case "Restart":
                SceneManager.LoadScene("play");
                break;
            case "Home":
                SceneManager.LoadScene("main");
                break;
            case "Help":
                SceneManager.LoadScene("help");
                break;
            case "Close":
                SceneManager.LoadScene("main");
                break;
            case "Sound":
                if (PlayerPrefs.GetString("Sound") != "no")
                {
                    PlayerPrefs.SetString("Sound", "no");
                    soundOn.SetActive(false);
                    SoundOff.SetActive(true);
                }
                else
                {
                    PlayerPrefs.SetString("Sound", "yes");
                    soundOn.SetActive(true);
                    SoundOff.SetActive(false);
                }
                break;
        }
    }
}