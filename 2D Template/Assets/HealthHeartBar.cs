using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthHeartBar : MonoBehaviour
{
    public GameObject heartPrefab;
    public float Playerhealth, playerHealth;
    List<HealthHeart> hearts = new List<HealthHeart>();

    private void OnEnable()
    {
        PlayerHealth.OnPlayerDamaged += DrawHearts;
    }

    private void OnDiasable()
    {
        PlayerHealth.OnPlayerDamaged -= Drawhearts;
    }

    public void Drawhearts()
    {
        ClearHearts();

        //determine how many hearts total
        //based off of max Health
        float maxHealthRemainder = playerHealth.maxHealth % 2; //1
        int heartsToMake = (int)(playerHealth.maxHealth / 2 + maxHealthremainder);
        for (int i = 0; i < heartsToMake; i++) 
        {
            CreateEmptyHeart (); // make total hearts needed 
        }

        for(int i = 0; i < hearts.Count; i++)
        {
            int heartStausRemainder = (int)Mathf.Clamp(playerHealth.Health - (i*2), 0, 2);
        }
        //make 5 hearts 
    }

    public void CreateEmptyHeart()
    {
        GameObject newHeart = Instantiate(heartPrefab);
        newHeart.transform.SetParent(transform);

        HealthHeart heartComponent = newHeart.GetComponent<HealthHeart>();
        heartComponent.SetHeartImage(HealthHeart.HeartStatus.Empty);
        hearts.Add(heartComponent);
    }

    public void ClearHearts()
    {
        foreach(Transform t in transform)
        {
            Destroy(t.gameObject);
        }
        hearts = new List<HealthHeart> ();
    }

}
