using UnityEngine;

public class SlidesObjLeft : MonoBehaviour
{
    private float _speed;

    private void Start()
    {
        _speed = 1f + 0.6f * PlayerPrefs.GetInt("Diff");
    }
    void Update()
    {
        transform.position += Vector3.left * _speed * Time.deltaTime;
    }

}
