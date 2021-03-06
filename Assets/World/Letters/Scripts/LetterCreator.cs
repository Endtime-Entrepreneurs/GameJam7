using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using TMPro;

public class LetterCreator : MonoBehaviour
{
    public List<Person> People;

    public GameObject BannedActivitiesObject;
    
    public GameObject CurrentLetter;

    public GameObject BlackmailLetter;

    public GameObject RevolutionLetter;

    public TextMeshProUGUI RevolutionLetterText;

    public GameObject CurrentNotebook;

    public GameObject PersonSelector;

    public GameObject ActivitySelector;

    public Person SelectedPerson;

    public Activity SelectedActivity;

    public GameObject PlayerVariable;

    public GameObject Creator;

    public TextMeshProUGUI InkAmountText;

    public TextMeshProUGUI PaperAmountText;
    
    // Start is called before the first frame update
    void Start()
    {
        PlayerVariable = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SelectRevolutionLetter()
    {
        if(CurrentLetter != null)
        {
            CurrentLetter.SetActive(false);
        }
        CurrentLetter = RevolutionLetter;
        RevolutionLetter.SetActive(true);
        RevolutionLetterText.SetText($"\nViva\nLa\nRevolution\n\n-{Player.Name}");
    }

    public void OpenPersonSelector()
    {
        if(CurrentNotebook != null)
        {
            CurrentNotebook.SetActive(false);
        }
        CurrentNotebook = PersonSelector;
        PersonSelector.GetComponent<PersonSelectorBehavior>().SetPeople(People);
        PersonSelector.SetActive(true);
    }

    public void PersonSelected(Person person)
    {
        PersonSelector.SetActive(false);
        SelectedPerson = person;
        if(CurrentLetter.name == "BlackmailLetter")
        {
            CurrentLetter.GetComponent<BlackmailLetterBehavior>().SelectPerson(person);
            SelectedActivity = CurrentLetter.GetComponent<BlackmailLetterBehavior>().SelectedActivity;
        }
    }

    public void OpenActivitySelector()
    {
        if(CurrentNotebook != null)
        {
            CurrentNotebook.SetActive(false);
        }
        if(SelectedPerson != null)
        {
            CurrentNotebook = ActivitySelector;
            ActivitySelector.GetComponent<ActionSelectorBehavior>().SetActivities(SelectedPerson.SeenActivities.Where(
                    x => BannedActivitiesObject.GetComponent<BannedActivitiesBehavior>().BannedActivities.Contains(x)
                ).ToList());
            ActivitySelector.SetActive(true);
        }
    }

    public void ActivitySelected(Activity activity)
    {
        ActivitySelector.SetActive(false);
        SelectedActivity = activity;
        if(CurrentLetter.name == "BlackmailLetter")
        {
            CurrentLetter.GetComponent<BlackmailLetterBehavior>().SelectActivity(activity);
        }
    }

    public void CreateLetter()
    {
        if(CurrentLetter.name == "BlackmailLetter")
        {
            if(SelectedActivity != null && SelectedPerson != null)
            {
                Letter letter = new Letter();
                letter.Recieving = SelectedPerson;
                letter.ManipulationLevelIncrease = BannedActivitiesObject.GetComponent<BannedActivitiesBehavior>().GetBanLevel(SelectedActivity);
                var player = PlayerVariable.GetComponent<Player>();
                player.invScript.AddLetter(letter);
                player.invScript.Pens--;
                player.invScript.Paper--;
                player.PeopleKnown[letter.Recieving.Name].SeenActivities.Remove(SelectedActivity);
                Debug.Log("Wrote a letter to " + SelectedPerson.Name + " about " + SelectedActivity.Name + " affecting morale by " + letter.ManipulationLevelIncrease);

                // Check on writing letter achievement.
                AchievementItem achItem = player.achievementList.getItem(Achievement.MightierThanTheSword);
                if (!achItem.isDone)
                {
                    player.achievementList.makeAchievement(achItem);
                }



                LeaveCreator();
            }
        }
        else if(CurrentLetter.name == "RevolutionLetter")
        {
            PlayerVariable.GetComponent<Player>().Revolt();
            LeaveCreator();
        }
    }

    public void LeaveCreator()
    {
        Creator.SetActive(false);
        if(CurrentNotebook != null)
        {
            CurrentNotebook.SetActive(false);
            CurrentNotebook = null;
        }
        if(CurrentLetter != null)
        {
            CurrentLetter.SetActive(false);
            CurrentLetter = null;
        }
    }

    public void EnterCreator()
    {
        PlayerVariable = GameObject.Find("Player");
        CurrentLetter = BlackmailLetter;
        CurrentLetter.SetActive(true);
        BlackmailLetter.GetComponent<BlackmailLetterBehavior>().SelectPerson(null);
        People = PlayerVariable.GetComponent<Player>().PeopleKnown.Values.ToList();
        InkAmountText.text = $"{PlayerVariable.GetComponent<Player>().invScript.Pens}";
        PaperAmountText.text = $"{PlayerVariable.GetComponent<Player>().invScript.Paper}";
        Creator.SetActive(true);
    }
}
