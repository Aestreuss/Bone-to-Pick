using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomSpawn : MonoBehaviour
{
    public GameObject itemPrefab;
    public float Radius = 1;

    public Button spawnButton;

    private bool cooldown = false;
    public float cooldownTime = 1f;

    void Start()
    {
        spawnButton.onClick.AddListener(SpawnOneBone);
    }

    void SpawnOneBone()
    {
       if ( cooldown == false)
        {
            Vector2 randomPos = Random.insideUnitSphere * Radius;
            Instantiate(itemPrefab, randomPos, Quaternion.identity);
            Invoke("ResetCooldown", cooldownTime);
            spawnButton.interactable = false;
            cooldown = true;
        }
    }

    void ResetCooldown()
    {
        cooldown = false;
        spawnButton.interactable = true;
    }

    private void OnDrawGizmos()
    {
        //to check the radius set
        Gizmos.color = Color.green;

        Gizmos.DrawWireSphere(this.transform.position, Radius);
    }
}

