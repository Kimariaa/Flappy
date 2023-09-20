using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float _maxTime;
    [SerializeField] private float _heightRange;
    [SerializeField] private GameObject _obj;

    private float _timer;

    private void Start()
    {
        Spawn();
        _maxTime = 4.5f - 1.5f * PlayerPrefs.GetInt("Diff");
        _heightRange = 1.5f + 0.5f * PlayerPrefs.GetInt("Diff");
    }

    private void Update()
    {
        if(!_obj.CompareTag("Player"))
        {
            if (_timer > _maxTime)
            {
                Spawn();
                _timer = 0;
            }

            _timer += Time.deltaTime;
        }
        
    }
    private void Spawn()
    {
        Vector3 spawnPos = transform.position + new Vector3(0, Random.Range(-_heightRange, _heightRange));
        GameObject obj = Instantiate(_obj, spawnPos, Quaternion.identity);
    }
}