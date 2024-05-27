using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CharacterManager : MonoBehaviour
{
    public CharacterDatabase characterDB;

    public Text nameText;
    public SpriteRenderer artworkSprite;

    private int selectedOption = 0;
    void Start()
    {
        if (PlayerPrefs.HasKey("selectedOption"))
        {
            selectedOption = 0;
        }
        else
        {
            Load();
        }


        UpdateCharacter(selectedOption);
    }

    // Update is called once per frame
    public void NextOption()
    {
        selectedOption++;

        if (selectedOption >= characterDB.CharacterCount) 
        { 
          selectedOption = 0;
        }

        UpdateCharacter(selectedOption);
    }

    public void BackOption()
    {
        selectedOption--;

        if(selectedOption < 0) 
        {
          selectedOption = characterDB.CharacterCount - 1;
        }
        UpdateCharacter(selectedOption);
        save();
    }
    public void UpdateCharacter(int selectedOption) 
    {
      Character character = characterDB.GetCharacter(selectedOption);
        artworkSprite.sprite = character.characterSprite;
        nameText.text = character.characterName;
    }

    private void Load()
    {
        selectedOption = PlayerPrefs.GetInt("selectedOption");
    }

    private void save() 
    {
        PlayerPrefs.SetInt("selectedOption", selectedOption);
    }

    public void ChangeScene(int sceneID)
    { 
       SceneManager.LoadScene(sceneID);
    }
}
