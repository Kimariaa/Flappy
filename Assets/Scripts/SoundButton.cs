using UnityEngine;
using UnityEngine.UI;

public class SoundButton : MonoBehaviour
{
    [SerializeField]private Sprite _musicOn;
    [SerializeField]private Sprite _musicOff;

    public Image _musicButton;
    [SerializeField] private AudioSource _music;

    private void Awake()
    {
        if (!PlayerPrefs.HasKey("music")) { PlayerPrefs.SetInt("music", 1); }
    }

    private void Start()
    {
        _musicButton.GetComponent<AudioSource>().volume = PlayerPrefs.GetInt("music");
        if (PlayerPrefs.GetInt("music") == 0) { _musicButton.GetComponent<Image>().sprite = _musicOff; }
    }

    public void ChangeVolume()
    {
        if (_musicButton.GetComponent<AudioSource>().volume == 1)
        {
            _musicButton.GetComponent<Image>().sprite = _musicOff;
            PlayerPrefs.SetInt("music", 0);
            _musicButton.GetComponent<AudioSource>().volume = 0;
        }
        else
        {
            _musicButton.GetComponent<Image>().sprite = _musicOn;
            PlayerPrefs.SetInt("music", 1);
            _musicButton.GetComponent<AudioSource>().volume = 1;
        }
    }
}
