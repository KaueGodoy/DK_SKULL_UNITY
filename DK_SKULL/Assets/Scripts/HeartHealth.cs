using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartHealth : MonoBehaviour
{
    [SerializeField] public int health;
    [SerializeField] public int numOfHearts;

    [SerializeField] public Image[] hearts;

    [SerializeField] public Sprite fullHeart;
    [SerializeField] public Sprite emptyHeart;

    private void Update()
    {
        // sets max health possible to the number of hearts that exist
        if(health > numOfHearts)
        {
            health = numOfHearts;
        }

        for (int i = 0; i < hearts.Length; i++)
        {
            // shows the current health with the fullHeart sprite 
            // starts from 0, if health = 3, 0 1 2 elements from array will use the fullHeart sprite
            // else it will use the emptyHeart sprite indicating there is no hp
            if(i < health)
            {
                hearts[i].sprite = fullHeart;
            } else
            {
                hearts[i].sprite = emptyHeart;
            }

            // shows only the selected amount of hearts from the array 
            // if array has 8 hearts but max health = 4 it will only show 4 hearts
            if (i < numOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }

    }

}
