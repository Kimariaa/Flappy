using UnityEngine;

public class DifficultyController : MonoBehaviour
{
    [SerializeField] private GameObject _difficultyBird;

    public void SetActiveBird()
    {
        _difficultyBird.SetActive(!_difficultyBird.activeSelf);
    }

}
