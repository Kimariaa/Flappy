using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    private AudioSource _pointSource;

    private void Start()
    {
        if (_pointSource == null)
        {
            _pointSource = GetComponent<AudioSource>();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ScoreScript.instance.UpdateScore();
            _pointSource.Play();
        }
        
    }
}
