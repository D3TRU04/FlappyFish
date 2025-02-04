using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    private int scoreCnt;

    public void gameOver()
    {
        Debug.Log("GAME OVER!!! ");
    }

    // Update is called once per frame
    public void scoreUpdater()
    {
        scoreCnt++;
    }
}
