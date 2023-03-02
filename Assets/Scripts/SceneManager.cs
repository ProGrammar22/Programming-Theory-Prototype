using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{

    public GameObject infoPanel;
    public GameObject cubeInfoText;
    public GameObject capsuleInfoText;
    public GameObject sphereInfoText;

    public void CloseButton()
    {
        cubeInfoText.SetActive(false);
        capsuleInfoText.SetActive(false);
        sphereInfoText.SetActive(false);
        infoPanel.SetActive(false);
    }
}
