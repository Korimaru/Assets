using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {

    private int hp;
    private bool isAlive;
    private string name;

    public void IncrementHP(int amount)
    {
        hp += amount;
        if (hp <= 0)
            isAlive = false;
    }
    public void DecrementHP(int amount)
    {
        hp -= amount;
        if (hp <= 0)
            isAlive = false;
    }

}
