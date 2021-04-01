using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnersController: MonoBehaviour
{
    [SerializeField] private float _spawnRate;

    private float _runningTime;
    private int _spawnIteration = 0;
    private Spawner[] _spawners;

    private void Start()
    {
        _spawners = gameObject.GetComponentsInChildren<Spawner>();
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
        _spawners[_spawnIteration].Spawn();
        _spawnIteration++;

        if (_spawnIteration == _spawners.Length)
            _spawnIteration = 0;
    }
}
