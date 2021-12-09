using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LoadCharacter : MonoBehaviour
{
    public GameObject[] charactersPrefabs;
    public GameObject spawnPoint;

    void Start()
    {
        int selectedCharacter = PlayerPrefs.GetInt("selectedCharacter");
        GameObject prefab = charactersPrefabs[selectedCharacter];
        GameObject clone = Instantiate(prefab, spawnPoint.transform.position, Quaternion.identity);
    }

}
