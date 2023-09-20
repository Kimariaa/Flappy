using UnityEngine;

public class SetDifficulty : MonoBehaviour
{
    [SerializeField] private GameObject _birdButton;
    private void Awake()
    {
        if (!PlayerPrefs.HasKey("Diff")) { PlayerPrefs.SetInt("Diff", 1); }
    }

    public void DifficultyButton()
    {
        switch (_birdButton.name)
        {
            case "Easy":
                PlayerPrefs.SetInt("Diff", 0);
                break;
            case "Normal":
                PlayerPrefs.SetInt("Diff", 1);
                break;
            case "Hard":
                PlayerPrefs.SetInt("Diff", 2);
                break;
        }
    }
}
