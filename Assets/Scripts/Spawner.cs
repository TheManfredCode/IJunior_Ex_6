using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Template;

    [SerializeField] private float _spawnRate;
    private float _runningTime;
    private Transform _transform;

    private void Start()
    {
        _transform = GetComponent<Transform>();
    }

    private void Update()
    {
        if (_runningTime <= _spawnRate)
        {
            _runningTime += Time.deltaTime;
        }
        else
        {
            Instantiate(Template, _transform.position, Quaternion.identity);
            _runningTime = 0f;
        }
    }
}
