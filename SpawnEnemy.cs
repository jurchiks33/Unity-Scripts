// This script is using old UnityEngine.Input API
// To use in new version you need to 
// Edit -> Project Settings -> Player - Other Settings
// Activate Input Handling -> set to Both or Input Manager (Old)

using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject Enemy1;
    public Transform spawnLocation;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Enemy1 != null)
            {
                Vector3 spawnPos = spawnLocation != null ? spawnLocation.position : Vector3.zero;
                Quaternion spawnRot = spawnLocation != null ? spawnLocation.rotation : Quaternion.identity;

                Instantiate(Enemy1, spawnPos, spawnRot);
                Debug.Log("Prefab Initiates!");
            }
            else
            {
                Debug.LogWarning("Prefab is not assigned!");
            }
        }
    }
}