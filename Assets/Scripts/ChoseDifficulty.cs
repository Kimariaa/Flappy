using UnityEngine;

public class ChoseDifficulty : MonoBehaviour
{
    [SerializeField] GameObject[] _difficulty = new GameObject[3];
    [SerializeField] private GameObject _birdGray;

    private void Start()
    {
        ChangeGrayBirdPos(_difficulty[PlayerPrefs.GetInt("Diff")]);
    }

    private void Update()
    {
        ChangeGrayBirdPos(_difficulty[PlayerPrefs.GetInt("Diff")]);
    }

    public void ChangeGrayBirdPos(GameObject pos)
    {
        _birdGray.transform.position = pos.transform.position;
    }
}
