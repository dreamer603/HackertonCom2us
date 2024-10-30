using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeUIManager : MonoBehaviour
{
    public GameObject[] gameBanners;

    public GameObject startButton;

    private int _nextGame;
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < gameBanners.Length; i++)
        {
            gameBanners[i].SetActive(false);
        }
        startButton.SetActive(false);
    }

    public void OnClickGameIcon(int index)
    {
        if (_nextGame != null)
        {
            gameBanners[_nextGame].SetActive(false);
        }

        _nextGame = index;
        gameBanners[_nextGame].SetActive(true);
        startButton.SetActive(true);
    }

    public void OnClickStartButton()
    {
        switch (_nextGame)
        {
            case 0:
                SceneManager.LoadScene("PumpkinScene");
                break;
            case 1:
                SceneManager.LoadScene("FishGame");
                break;
            case 2:
                SceneManager.LoadScene("ChangeShapeMiniGame");
                break;
            default:
                Debug.Log("구현 예정");
                break;
        }
    }
}
