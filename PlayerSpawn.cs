using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    [SerializeField] private GameObject _objectPrefab; // Префаб объекта, который нужно заспавнить.
    [SerializeField] private Vector3[] _spawnPointObject; // Значения указать в инспекторе, столько сколько нужно.
    [SerializeField] private int _spawnScore;

    private GameObject _objectClon = null;

    public void SpawnObject() //Спавн объекта
    {
         for (int i = 0; i < _spawnScore; i++)
         {
            _objectClon = Instantiate(_objectPrefab, _spawnPointObject[Random.Range(0, _spawnPointObject.Length)], Quaternion.identity);
         }
    }

    private void OnTriggerEnter(Collider collision) // Этот метод сработает на триггер и заспавнит объект если его нет.
    {
        if (_objectClon != null)
            return;
        SpawnObject();
    }
   

    
    
}
