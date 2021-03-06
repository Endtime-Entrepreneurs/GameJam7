using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievementList : MonoBehaviour
{
    public static List<AchievementItem> achievementList = new List<AchievementItem>();
    public Player player;

    public void Start()
    {
        createAchievementList();
    }

    public void createAchievementList()
    {
        AchievementItem Item1 = AchievementItem.CreateInstance<AchievementItem>();
        // Mike and Daniel support achievement
        Item1.AchievementType = Achievement.WinOverTheCreators;
        Item1.AchievementName = "Win over the creators";
        Item1.AchievementDescription = "Achieve full support of Mike and Daniel.";
        Item1.isDone = false;
        achievementList.Add(Item1);

        AchievementItem Item2 = AchievementItem.CreateInstance<AchievementItem>();
        // Airy support achievement
        Item2.AchievementType = Achievement.TameTheDragon;
        Item2.AchievementName = "Tame the dragon";
        Item2.AchievementDescription = "Achieve full support of Airy.";
        Item2.isDone = false;
        achievementList.Add(Item2);

        AchievementItem Item3 = AchievementItem.CreateInstance<AchievementItem>();
        // Don and Onna support achievement
        Item3.AchievementType = Achievement.ParentialApproval;
        Item3.AchievementName = "Parential approval";
        Item3.AchievementDescription = "Achieve full support of Don and Onna.";
        Item3.isDone = false;
        achievementList.Add(Item3);

        AchievementItem Item4 = AchievementItem.CreateInstance<AchievementItem>();
        // Guard caught achievement
        Item4.AchievementType = Achievement.CatchTheGuards;
        Item4.AchievementName = "Catch the guards";
        Item4.AchievementDescription = "Catch a guard in an illegal act.";
        Item4.isDone = false;
        achievementList.Add(Item4);

        AchievementItem Item5 = AchievementItem.CreateInstance<AchievementItem>();
        // George caught achievement
        Item5.AchievementType = Achievement.Hypocrisy;
        Item5.AchievementName = "Hypocrisy";
        Item5.AchievementDescription = "Catch George in an illegal act.";
        Item5.isDone = false;
        achievementList.Add(Item5);

        AchievementItem Item6 = AchievementItem.CreateInstance<AchievementItem>();
        // Manager George support achievement
        Item6.AchievementType = Achievement.ManageTheManager;
        Item6.AchievementName = "Manage the manager";
        Item6.AchievementDescription = "Achieve full support of George.";
        Item6.isDone = false;
        achievementList.Add(Item6);

        AchievementItem Item7 = AchievementItem.CreateInstance<AchievementItem>();
        // Writing letter achievement
        Item7.AchievementType = Achievement.MightierThanTheSword;
        Item7.AchievementName = "Mightier than the sword";
        Item7.AchievementDescription = "Write a letter.";
        Item7.isDone = false;
        achievementList.Add(Item7);

        AchievementItem Item8 = AchievementItem.CreateInstance<AchievementItem>();
        // Touching lava achievement
        Item8.AchievementType = Achievement.Burned;
        Item8.AchievementName = "Burned";
        Item8.AchievementDescription = "Touch the lava.";
        Item8.isDone = false;
        achievementList.Add(Item8);

        AchievementItem Item9 = AchievementItem.CreateInstance<AchievementItem>();
        // Enter Jail achievement
        Item9.AchievementType = Achievement.SightseeThePrison;
        Item9.AchievementName = "Sightsee the prison";
        Item9.AchievementDescription = "Enter the jail.";
        Item9.isDone = false;
        achievementList.Add(Item9);

        AchievementItem Item10 = AchievementItem.CreateInstance<AchievementItem>();
        // Enter Jail cell achievement
        Item10.AchievementType = Achievement.LockedIn;
        Item10.AchievementName = "Locked in";
        Item10.AchievementDescription = "Enter the jail cell.";
        Item10.isDone = false;
        achievementList.Add(Item10);

        AchievementItem Item11 = AchievementItem.CreateInstance<AchievementItem>();
        // Enter the manager House
        Item11.AchievementType = Achievement.AreYouAllowedInHere;
        Item11.AchievementName = "Are you allowed in here?";
        Item11.AchievementDescription = "Enter the manager's house.";
        Item11.isDone = false;
        achievementList.Add(Item11);

        AchievementItem Item12 = AchievementItem.CreateInstance<AchievementItem>();
        // Enter the printing press room
        Item12.AchievementType = Achievement.MeetThePress;
        Item12.AchievementName = "Meet the press";
        Item12.AchievementDescription = "Enter the printing press room.";
        Item12.isDone = false;
        achievementList.Add(Item12);

        AchievementItem Item13 = AchievementItem.CreateInstance<AchievementItem>();
        // Less than 10% support
        Item13.AchievementType = Achievement.WhiskedAway;
        Item13.AchievementName = "Whisked away";
        Item13.AchievementDescription = "Attempt a rebellion with marginal support.";
        Item13.isDone = false;
        achievementList.Add(Item13);

        AchievementItem Item14 = AchievementItem.CreateInstance<AchievementItem>();
        // 10 - 25% support
        Item14.AchievementType = Achievement.Isolation;
        Item14.AchievementName = "Isolation";
        Item14.AchievementDescription = "Attempt a rebellions with a small amount of support.";
        Item14.isDone = false;
        achievementList.Add(Item14);

        AchievementItem Item15 = AchievementItem.CreateInstance<AchievementItem>();
        // 25% - 40% support
        Item15.AchievementType = Achievement.Executed;
        Item15.AchievementName = "Executed";
        Item15.AchievementDescription = "Attempt a rebellion with moderate support.";
        Item15.isDone = false;
        achievementList.Add(Item15);

        AchievementItem Item16 = AchievementItem.CreateInstance<AchievementItem>();
        // 40 - 60% support
        Item16.AchievementType = Achievement.BatteredButFree;
        Item16.AchievementName = "Battered but free";
        Item16.AchievementDescription = "Attempt a rebellion with sufficient support.";
        Item16.isDone = false;
        achievementList.Add(Item16);

        AchievementItem Item17 = AchievementItem.CreateInstance<AchievementItem>();
        // 60 - 99% support
        Item17.AchievementType = Achievement.Victorious;
        Item17.AchievementName = "Victorious";
        Item17.AchievementDescription = "Attempt a rebellion with major support.";
        Item17.isDone = false;
        achievementList.Add(Item17);

        AchievementItem Item18 = AchievementItem.CreateInstance<AchievementItem>();
        // 100% support
        Item18.AchievementType = Achievement.SilverTongue;
        Item18.AchievementName = "Silver tongue";
        Item18.AchievementDescription = "Attempt a rebellion with complete support.";
        Item18.isDone = false;
        achievementList.Add(Item18);

        AchievementItem Item19 = AchievementItem.CreateInstance<AchievementItem>();
        // Hoard at least 10 pens and pieces of paper
        Item19.AchievementType = Achievement.Hoarder;
        Item19.AchievementName = "Hoarder";
        Item19.AchievementDescription = "Hold at least 10 pens and pieces of paper.";
        Item19.isDone = false;
        achievementList.Add(Item19);

        AchievementItem Item20 = AchievementItem.CreateInstance<AchievementItem>();
        // Pee in the bushes
        Item20.AchievementType = Achievement.Aaaaaaaaaah;
        Item20.AchievementName = "Aaaaaaaaaah";
        Item20.AchievementDescription = "Pee in the bushes.";
        Item20.isDone = false;
        achievementList.Add(Item20);

    }

    // Searches for an achievement by its position in the list.
    public AchievementItem getItem(int number)
    {
        AchievementItem Item = null;
        if (number < achievementList.Count && number>=0)
        {
            Item = achievementList[number];
        }
        return Item;
    }

    // Searches for an achievement by string name
    // if found, it returns the achievement, if not, it returns null.
    public AchievementItem getItem(Achievement ach)
    {
        AchievementItem Item = null;
        bool found = false;
        for (int i=0; i<achievementList.Count && !found; i++)
        {
            if (achievementList[i].AchievementType == ach)
            {
                Item = achievementList[i];
                found = true;
            }
        }
        return Item;
    }

    public void makeAchievement(AchievementItem item)
    {
        if (!item.isDone)
        {
            item.isDone = true;
            awardAchievement(item);
        }
    }

    private void awardAchievement(AchievementItem item)
    {
        if (player != null)
        {
            player.NPCInfoUI.AchievementInfo(item);
            player.log.addItem("Achievement", $"New Achievement:  {item.AchievementName}\nDescription:   {item.AchievementDescription}");
        }
        else
        {
            Debug.Log("Made achievement " + item.AchievementName);
        }
        // do something!
    }
}
