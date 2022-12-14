using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmlandsBehaviour : MonoBehaviour
{
    public int[] data = new int[2];
    int[,] farmsnum = new int[3, 3]
    {
        {1,2,3},
        {4,5,6},
        {7,8,9}
    };
    public SpriteRenderer[] farms = new SpriteRenderer[9];
    public Sprite[] sprites = new Sprite[17];
    private void Start()
    {
        Check(0, 0);
    }
    public void Check(int x, int y)
    {
        try
        {
            Debug.Log($"{farmsnum[x,y]};;{farms[farmsnum[x, y]-1]}");
        }
        catch(IndexOutOfRangeException) { Debug.Log($"{x};{y};;;{farmsnum[x, y]}"); }

    }
}
