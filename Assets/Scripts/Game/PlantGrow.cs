using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlantGrow : MonoBehaviour
{
    public Sprite[] cropsSprites = new Sprite[5];
    public int slowness = 1;
    public Image cropsRenderer;
    int maxstage;
    public int stage = -1;
    private void Start()
    {
        maxstage = 5 * slowness;
    }
    public void Grow()
    {
        if(stage == -1)
        {
            cropsRenderer.transform.localScale = Vector3.zero;
        }
        if(stage == 0)
        {
            cropsRenderer.transform.localScale = new Vector3(1,1,1);
        }
        if (stage < maxstage && stage >= 0)
        {
            if (stage % slowness == 0) cropsRenderer.sprite = cropsSprites[stage/slowness];
        }
        stage++;
        if (stage >= maxstage)
        {
            stage = 0;
        }
    }
}
