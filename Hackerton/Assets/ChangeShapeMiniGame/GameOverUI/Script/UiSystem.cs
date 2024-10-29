using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiSystem : MonoBehaviour
{
    public static GameObject modal;
    private void Start()
    {
        modal = GameObject.FindWithTag("modal");
        modal.SetActive(false);
    }
    public static void GoodGame()
    {
        modal.SetActive(true);
    }
    public void ToMain()
    {
        SceneManager.LoadScene(0); //사실 이부분은 아직 대체할 메인 신이 없어서 넣어놓은 부분입니다. 메인신 생성 후 변경 바랍니다.
    }

    public void ReStart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);//각 게임들의 초기화 상태를 몰라서 그냥 씬을 재생성하는 방식으로 짯습니다.. 수정사항 생기면 말씀해주세요
    }
}
