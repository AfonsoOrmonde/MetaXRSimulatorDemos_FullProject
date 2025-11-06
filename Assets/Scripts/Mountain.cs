using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mountain : MonoBehaviour
{
    private Vector3 mountainRelativeToPlayer;
    [SerializeField]
    private GameObject playerRig;
    [SerializeField]
    private Material skyboxEarlyDay;
    void Start()
    {
        mountainRelativeToPlayer = new Vector3(playerRig.transform.position.x - this.transform.position.x,
        playerRig.transform.position.y - this.transform.position.y,
        playerRig.transform.position.z - this.transform.position.z);
        ChangeSkyBox(skyboxEarlyDay);
    }

    public void ChangeSkyBox(Material skybox)
    {
        RenderSettings.skybox = skybox;
    }
    
    public void ResetGame()
    {
        Scene scene = SceneManager.GetActiveScene(); 
        SceneManager.LoadScene(scene.name);
    }
}
