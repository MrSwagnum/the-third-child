using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    public GameObject _enemy;
   

    void Update()
    {
        if (_enemy == null)
        {
            _enemy = Instantiate(enemyPrefab) as GameObject;
            _enemy.transform.position = new Vector3(25, 4, 0);

           
            float angle = Random.Range(0, 360);
            _enemy.transform.Rotate(0, angle, 0);

            
            
            

            
            
        }
    }
}