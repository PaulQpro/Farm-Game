using System.Collections;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SelectCrops : MonoBehaviour
{
    public PlantGrow PlantGrow;
    bool isPlanted = false;
    public void Grow()
    {
        if (isPlanted) { PlantGrow.Grow(); if (PlantGrow.stage == 0) isPlanted = false; }
        else { isPlanted = true; }
    }
}