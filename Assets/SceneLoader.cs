
using UnityEngine;
using UnityEngine.SceneManagement;//Unity�G���W���̃V�[���Ǘ��v���O�����𗘗p����

public class SceneLoader : MonoBehaviour //SceneLoader�Ƃ������O�ɂ��܂�
{
    public void Start_button(string Sceneneme) //string_button�Ƃ������O�ɂ��܂�
    {
        SceneManager.LoadScene(Sceneneme);//second���Ăяo���܂�
    }
}