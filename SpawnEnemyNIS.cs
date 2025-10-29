// Below spawning script is for a new unity Input System NIS

using UnityEngine;
#if ENABLE_INPUT_SYSTEM
using UnityEngine.InputSystem;
#endif

public class SpawnEnemy : MonoBehaviour
{
    public GameObject Enemy1;
    public Transform spawnLocation;

    void Update()
    {
#if ENABLE_INPUT_SYSTEM
        if (Keyboard.current != null && Keyboard.current.spaceKey.wasPressedThisFrame)
#else
        if (Input.GetKeyDown(KeyCode.Space))
#endif
        {
            if (Enemy1 != null)
            {
                var pos = spawnLocation ? spawnLocation.position : Vector3.zero;
                var rot = spawnLocation ? spawnLocation.rotation : Quaternion.identity;
                Instantiate(Enemy1, pos, rot);
                Debug.Log("Prefab Instantiated!");
            }
            else
            {
                Debug.LogWarning("Prefab is not assigned!");
            }
        }
    }
}
