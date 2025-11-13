using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterManager : MonoBehaviour
{
    public int index = 0;  // 회사원으로 고정
    public DSLManager dslManager;
    AudioSource sound;
    public Image characterImage;
    public Text characterName;

    private void Awake() {
        index = 0;  // 항상 회사원 (인덱스 0)
        sound = GetComponent<AudioSource>();
        sound.mute = !dslManager.GetSettingOn("SoundBtn");
        DisplayCharacter();
    }

    // 회사원 캐릭터 정보 표시
    private void DisplayCharacter()
    {
        characterImage.sprite = dslManager.characterSprite[0];
        characterName.text = "회사원";
    }
}
