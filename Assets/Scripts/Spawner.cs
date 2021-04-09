using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _template;
    [SerializeField] private float _spawnRate;

    private float _runningTime;
    private int _spawnIteration = 0;
    private Transform[] _spawnPoints;

    private void Start()
    {
        _spawnPoints = new Transform[transform.childCount];

        for (int i = 0; i < transform.childCount; i++)
            _spawnPoints[i] = transform.GetChild(i);
    }

    private void Update()
    {
        if (_runningTime <= _spawnRate)
        {
            _runningTime += Time.deltaTime;
        }
        else
        {
            _runningTime = 0f;
            Spawn();
        }
    }

    private void Spawn()
    {
        Instantiate(_template, _spawnPoints[_spawnIteration].position, Quaternion.identity);
        _spawnIteration++;

        if (_spawnIteration == _spawnPoints.Length)
            _spawnIteration = 0;
    }
}
