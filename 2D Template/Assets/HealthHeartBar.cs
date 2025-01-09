using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthHeartBar : MonoBehaviour
{
    public int health;
    public int maxHealth = 10;
    public int maxHealthRemainder;
    public int heartStatusRemainder;
    public GameObject heartPrefab;
    List<HealthHeart> hearts = new List<HealthHeart>();

    private void OnEnable()
    {
     
    }

    private void OnDiasable()
    {
      
    }

    public void Drawhearts()
    {
        ClearHearts();

        //determine how many hearts total
        //based off of max Health
        int maxHealthRemainder= maxHealth % 2; //1
        int heartsToMake = (int)(maxHealth / 2 + maxHealthRemainder);
        for (int i = 0; i < heartsToMake; i++) 
        {
            CreateEmptyHeart (); // make total hearts needed 
        }

        for(int i = 0; i < hearts.Count; i++)
        {
            int heartStatusRemainder = (int)Mathf.Clamp( health - (i*2), 0, 2);
        }
        //make 5 hearts 
    }

    public void CreateEmptyHeart()
    {
        GameObject newHeart = Instantiate(heartPrefab);
        newHeart.transform.SetParent(transform);

        HealthHeart heartComponent = newHeart.GetComponent<HealthHeart>();
        heartComponent.SetHeartImage(HeartStatus.Empty);
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
