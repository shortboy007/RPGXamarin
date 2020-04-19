using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RPGXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainGamePage : ContentPage
    {
        public MainGamePage()
        {
            InitializeComponent();
        }

        public static int fighterHealth = 200;
        public static int fighterRage = 100;
        public static int thiefHealth = 100;
        public static int thiefEnergy = 100;
        public static int blackBeltHealth = 100;
        public static int blackBeltChi = 100;
        public static int redMageHealth = 100;
        public static int redMageMagic = 100;
        public static int blackMageHealth = 100;
        public static int blackMageMagic = 100;
        public static int whiteMageHealth = 100;
        public static int whiteMageMagic = 100;
        public static int goldAmount = 0;

        public static int specialAttackCost = 25;

        public int fighterCurrentHealth = fighterHealth;
        public int fighterCurrentRage = fighterRage;
        public int thiefCurrentHealth = thiefHealth;
        public int thiefCurrentEnergy = thiefEnergy;
        public int blackBeltCurrentHealth = blackBeltHealth;
        public int blackBeltCurrentChi = blackBeltChi;
        public int redMageCurrentHealth = redMageHealth;
        public int redMageCurrentMagic = redMageMagic;
        public int blackMageCurrentHealth = blackMageHealth;
        public int blackMageCurrentMagic = blackMageMagic;
        public int whiteMageCurrentHealth = whiteMageHealth;
        public int whiteMageCurrentMagic = whiteMageMagic;
        public int currentGoldAmount = goldAmount;



        public int monsterEncountered;
        public int monsterHealth;
        public int monsterDamage;
        public int swordDamage;
        public int daggerDamage;
        public int fistDamage;
        public int staffDamage;
        public int rageAttackDamage;
        public int pilferAttackDamage;
        public int pummelAttackDamage;
        public int fireBallDamage;
        public int darkDamage;
        public int lightningDamage;
        public int harmDamage;
        public int playerHit;
        public int monsterHit;
        public int runAway;
        public int lootedGold;
        public Random randomMonster;
        public Random randomMonsterDamage;
        public Random randomMonsterHealth;
        public Random randomSword;
        public Random randomDagger;
        public Random randomFist;
        public Random randomStaff;
        public Random playerHitRandom;
        public Random monsterHitRandom;
        public Random runAwayRandom;
        public Random randomGold;

        public bool fighterChosen = false;
        public bool thiefChosen = false;
        public bool blackBeltChosen = false;
        public bool redMageChosen = false;
        public bool blackMageChosen = false;
        public bool whiteMageChosen = false;

        public bool monsterDead = false;
        public bool playerHitMonster = false;
        public bool monsterHitPlayer = false;
        public bool hasMagic = true;

        //These methods are all called when the respective button is tapped on by the player. 
        //They show or hide objects on the screen which are relevant to the chosen character such as health or magic.

        public void FighterChosenButton_Clicked(object sender, EventArgs e)
        {
            ShowNameScreen();
            HideCharacters();
            fighterChosen = true;
            GameFighterImage.IsVisible = true;
            GameCharacterHealthText.IsVisible = true;
            GameCharacterMagicText.IsVisible = true;
            GameCharacterHealthText.Text = "Health: " + fighterCurrentHealth;
            GameCharacterMagicText.Text = "Rage: " + fighterRage;
        }

        public void ThiefChosenButton_Clicked(object sender, EventArgs e)
        {
            ShowNameScreen();
            HideCharacters();
            thiefChosen = true;
            GameThiefImage.IsVisible = true;
            GameCharacterHealthText.IsVisible = true;
            GameCharacterMagicText.IsVisible = true;
            GameCharacterHealthText.Text = "Health: " + thiefCurrentHealth;
            GameCharacterMagicText.Text = "Energy: " + thiefEnergy;
        }

        public void BlackBeltChosenButton_Clicked(object sender, EventArgs e)
        {
            ShowNameScreen();
            HideCharacters();
            blackBeltChosen = true;
            GameBlackBeltImage.IsVisible = true;
            GameCharacterHealthText.IsVisible = true;
            GameCharacterMagicText.IsVisible = true;
            GameCharacterHealthText.Text = "Health: " + blackBeltCurrentHealth;
            GameCharacterMagicText.Text = "Chi: " + blackBeltChi;
        }

        public void RedMageChosenButton_Clicked(object sender, EventArgs e)
        {
            ShowNameScreen();
            HideCharacters();
            redMageChosen = true;
            GameRedMageImage.IsVisible = true;
            GameCharacterHealthText.IsVisible = true;
            GameCharacterMagicText.IsVisible = true;
            GameCharacterHealthText.Text = "Health: " + redMageCurrentHealth;
            GameCharacterMagicText.Text = "Magic: " + redMageMagic;
        }

        public void BlackMageChosenButton_Clicked(object sender, EventArgs e)
        {
            ShowNameScreen();
            HideCharacters();
            blackMageChosen = true;
            GameBlackMageImage.IsVisible = true;
            GameCharacterHealthText.IsVisible = true;
            GameCharacterMagicText.IsVisible = true;
            GameCharacterHealthText.Text = "Health: " + blackMageCurrentHealth;
            GameCharacterMagicText.Text = "Magic: " + blackMageMagic;
        }

        public void WhiteMageChosenButton_Clicked(object sender, EventArgs e)
        {
            ShowNameScreen();
            HideCharacters();
            whiteMageChosen= true;
            GameWhiteMageImage.IsVisible = true;
            GameCharacterHealthText.IsVisible = true;
            GameCharacterMagicText.IsVisible = true;
            GameCharacterHealthText.Text = "Health: " + whiteMageCurrentHealth;
            GameCharacterMagicText.Text = "Magic: " + whiteMageMagic;
        }

        //This method hides the character choose screen and shows the character naming screen.
        public void ShowNameScreen()
        {
            GameChooseCharacterText.IsVisible = false;
            GameCharacterNameText.IsVisible = true;
            GameCharacterNameInstructionsText.IsVisible = true;
            GameCharacterNameInputTextBox.IsVisible = true;
            GameCharacterNameChosenButton.IsVisible = true;
        }

        //This method hides all character images and buttons.
        public void HideCharacters()
        {
            GameFighterImage.IsVisible = false;
            GameThiefImage.IsVisible = false;
            GameBlackBeltImage.IsVisible = false;
            GameRedMageImage.IsVisible = false;
            GameBlackMageImage.IsVisible = false;
            GameWhiteMageImage.IsVisible = false;

            FighterChosenButton.IsVisible = false;
            ThiefChosenButton.IsVisible = false;
            BlackBeltChosenButton.IsVisible = false;
            RedMageChosenButton.IsVisible = false;
            BlackMageChosenButton.IsVisible = false;
            WhiteMageChosenButton.IsVisible = false;
        }

        //This method hides all monster images.
        public void hideMonsters()
        {
            GameSnakeImage.IsVisible = false;
            GameSpiderImage.IsVisible = false;
            GameBirdImage.IsVisible = false;
            GameWolfImage.IsVisible = false;
            GameImpImage.IsVisible = false;
            GameVikingImage.IsVisible = false;
            GameOgreImage.IsVisible = false;
            GameSkeletonImage.IsVisible = false;
            GameGatorImage.IsVisible = false;
            GameWizardImage.IsVisible = false;
        }

        //This method shows the battle command screen and displays different buttons depending on what character is chosen. 
        //When the character is chosen, a boolean relevant to that character is set to true. This tells the app what buttons and images to show.
        public void showBattleCommands()
        {
            GameExploreButton.IsVisible = false;
            GameAttackButton.IsVisible = true;
            GameDefendButton.IsVisible = true;
            GameRunAwayButton.IsVisible = true;
            GameMonsterAttackRoundButton.IsVisible = false;
            GameRestButton.IsVisible = false;

            if(fighterChosen)
            {
                GameRageAttackButton.IsVisible = true;
            }
            if(thiefChosen)
            {
                GamePilferAttackButton.IsVisible = true;
            }
            if(blackBeltChosen)
            {
                GamePummelAttackButton.IsVisible = true;
            }
            if(redMageChosen)
            {
                GameFireBallAttackButton.IsVisible = true;
                GameLightningAttackButton.IsVisible = true;
            }
            if(blackMageChosen)
            {
                GameFireBallAttackButton.IsVisible = true;
                GameLightningAttackButton.IsVisible = true;
                GameDarknessAttackButton.IsVisible = true;
            }
            if(whiteMageChosen)
            {
                GameHarmAttackButton.IsVisible = true;
                GameLightningAttackButton.IsVisible = true;
            }
        }

        //This method hides battle related buttons.
        public void hideBattleCommands()
        {
            GameExploreButton.IsVisible = true;
            GameAttackButton.IsVisible = false;
            GameDefendButton.IsVisible = false;
            GameRunAwayButton.IsVisible = false;
            GameMonsterAttackRoundButton.IsVisible = false;
            GameRestButton.IsVisible = true;
            GameRageAttackButton.IsVisible = false;
            GamePilferAttackButton.IsVisible = false;
            GamePummelAttackButton.IsVisible = false;
            GameFireBallAttackButton.IsVisible = false;
            GameLightningAttackButton.IsVisible = false;
            GameDarknessAttackButton.IsVisible = false;
            GameHarmAttackButton.IsVisible = false;
        }

        //This method hides the battle commands and is called after the player taps a button during battle. It allows the monster to take an attack round.
        public void showNextButton()
        {
            GameExploreButton.IsVisible = false;
            GameAttackButton.IsVisible = false;
            GameDefendButton.IsVisible = false;
            GameRunAwayButton.IsVisible = false;
            GameMonsterAttackRoundButton.IsVisible = true;
            GameRageAttackButton.IsVisible = false;
            GamePilferAttackButton.IsVisible = false;
            GamePummelAttackButton.IsVisible = false;
            GameFireBallAttackButton.IsVisible = false;
            GameLightningAttackButton.IsVisible = false;
            GameDarknessAttackButton.IsVisible = false;
            GameHarmAttackButton.IsVisible = false;
        }

        //This method randomly sets the monster's health between 50 and 100.
        public void setMonsterHealth()
        {
            Random randomMonsterHealth = new Random();

            monsterHealth = randomMonsterHealth.Next(50, 100);

            GameMonsterHealthText.Text = "Monster Health: " + monsterHealth;
        }

        //This method handles the monster's attack round by choosing a number from a range of numbers for how much damage the monster does and whether the monster hits the player.
        public void monsterAttacks()
        {
            Random randomMonsterDamage = new Random();

            monsterDamage = randomMonsterDamage.Next(1, 25);

            Random monsterHitRandom = new Random();

            monsterHit = monsterHitRandom.Next(0, 10);

            if (fighterChosen)
            {
                if (monsterHit >= 5)
                {
                    
                    fighterCurrentHealth = fighterCurrentHealth - monsterDamage;
                    GameExpositionText.Text = "The enemy hits you!";
                    GameMonsterDamageText.Text = "Monster Damage: " + monsterDamage;
                    GameCharacterHealthText.Text = "Health: " + fighterCurrentHealth;
                }
                if (monsterHit <= 4)
                {
                    GameExpositionText.Text = "The enemy misses you!";
                }
            }

            if (thiefChosen)
            {
                if (monsterHit >= 5)
                {
                    thiefCurrentHealth = thiefCurrentHealth - monsterDamage;
                    GameExpositionText.Text = "The enemy hits you!";
                    GameMonsterDamageText.Text = "Monster Damage: " + monsterDamage;
                    GameCharacterHealthText.Text = "Health: " + thiefCurrentHealth;
                }
                if (monsterHit <= 4)
                {
                    GameExpositionText.Text = "The enemy misses you!";
                }
            }

            if (blackBeltChosen)
            {
                if (monsterHit >= 5)
                {
                    blackBeltCurrentHealth = blackBeltCurrentHealth - monsterDamage;
                    GameExpositionText.Text = "The enemy hits you!";
                    GameMonsterDamageText.Text = "Monster Damage: " + monsterDamage;
                    GameCharacterHealthText.Text = "Health: " + blackBeltCurrentHealth;
                }
                if (monsterHit <= 4)
                {
                    GameExpositionText.Text = "The enemy misses you!";
                }
            }

            if (redMageChosen)
            {
                if (monsterHit >= 5)
                {
                    redMageCurrentHealth = redMageCurrentHealth - monsterDamage;
                    GameExpositionText.Text = "The enemy hits you!";
                    GameMonsterDamageText.Text = "Monster Damage: " + monsterDamage;
                    GameCharacterHealthText.Text = "Health: " + redMageCurrentHealth;
                }
                if (monsterHit <= 4)
                {
                    GameExpositionText.Text = "The enemy misses you!";
                }
            }

            if (blackMageChosen)
            {
                if (monsterHit >= 5)
                {
                    blackMageCurrentHealth = blackMageCurrentHealth - monsterDamage;
                    GameExpositionText.Text = "The enemy hits you!";
                    GameMonsterDamageText.Text = "Monster Damage: " + monsterDamage;
                    GameCharacterHealthText.Text = "Health: " + blackMageCurrentHealth;
                }
                if (monsterHit <= 4)
                {
                    GameExpositionText.Text = "The enemy misses you!";
                }
            }

            if (whiteMageChosen)
            {
                if (monsterHit >= 5)
                {
                    whiteMageCurrentHealth = whiteMageCurrentHealth - monsterDamage;
                    GameExpositionText.Text = "The enemy hits you!";
                    GameMonsterDamageText.Text = "Monster Damage: " + monsterDamage;
                    GameCharacterHealthText.Text = "Health: " + whiteMageCurrentHealth;
                }
                if (monsterHit <= 4)
                {
                    GameExpositionText.Text = "The enemy misses you!";
                }
            }

        }

        //This method checks to see if the monster's health is below or equal to zero. If it is, the monsters and battle commands are hidden.
        //The rest screen is then shown where the player can either explore or rest.
        public void isMonsterDead()
        {
            if (monsterHealth <= 0)
            {
                hideMonsters();
                hideBattleCommands();
            }
            else
            {
                showNextButton();
            }
        }

        //This method hides the character naming instructions and shows the exposition text which sets up the story.
        public void GameCharacterNameChosenButton_Clicked(object sender, EventArgs e)
        {
            GameCharacterNameInstructionsText.IsVisible = false;
            GameCharacterNameText.Text = GameCharacterNameInputTextBox.Text;
            GameCharacterNameInputTextBox.IsVisible = false;
            GameExpositionText.IsVisible = true;
            GameCharacterNameChosenButton.IsVisible = false;
            GameStartAdventureButton.IsVisible = true;
        }

        //This method changes the exposition text and hides the start adventure button. It also shows the explore button.
        public void GameStartAdventureButton_Clicked(object sender, EventArgs e)
        {
            GameExpositionText.Text = "Now that you have chosen a character, You may begin your journey.";
            GameStartAdventureButton.IsVisible = false;
            GameExploreButton.IsVisible = true;
        }

        //This method chooses a number between 1 and 11 when the button is tapped and depending on the number which is chosen, a specified monster's image is shown on the screen.
        //Either a monster is shown on the screen, or a random scenario is chosen such as the player encountering an empty room.
        public void GameExploreButton_Clicked(object sender, EventArgs e)
        {
            hideMonsters();
            showBattleCommands();
            setMonsterHealth();

            GameMonsterHealthText.IsVisible = true;
            GamePlayerDamageText.IsVisible = true;
            GameMonsterDamageText.IsVisible = true;

            Random randomMonster = new Random();

            monsterEncountered = randomMonster.Next(11);

            if (monsterEncountered == 0)
            {
                GameExpositionText.Text = "You encounter nothing but an empty hallway.";
                hideBattleCommands();
            }
            //snake
            else if (monsterEncountered == 1)
            {
                GameExpositionText.Text = "You encounter a viscious snake!";
                GameSnakeImage.IsVisible = true;
            }
            //spider
            else if (monsterEncountered == 2)
            {
                GameExpositionText.Text = "You encounter a gigantic spider!";
                GameSpiderImage.IsVisible = true;
            }
            //bird
            else if (monsterEncountered == 3)
            {
                GameExpositionText.Text = "You encounter a rather violent bird!";
                GameBirdImage.IsVisible = true;
            }
            //wolf
            else if (monsterEncountered == 4)
            {
                GameExpositionText.Text = "You encounter a snarling wolf!";
                GameWolfImage.IsVisible = true;
            }
            //imp
            else if (monsterEncountered == 5)
            {
                GameExpositionText.Text = "You encounter an agile imp!";
                GameImpImage.IsVisible = true;
            }
            //viking
            else if (monsterEncountered == 6)
            {
                GameExpositionText.Text = "You encounter a battle-hardened viking!";
                GameVikingImage.IsVisible = true;
            }
            //ogre
            else if (monsterEncountered == 7)
            {
                GameExpositionText.Text = "You encounter a big, stupid, ugly, ogre!";
                GameOgreImage.IsVisible = true;
            }
            //skeleton
            else if (monsterEncountered == 8)
            {
                GameExpositionText.Text = "You encounter a bone-rattling skeleton!";
                GameSkeletonImage.IsVisible = true;
            }
            //gator
            else if (monsterEncountered == 9)
            {
                GameExpositionText.Text = "You encounter a mutant sewer gator!";
                GameGatorImage.IsVisible = true;
            }
            //wizard
            else if (monsterEncountered == 10)
            {
                GameExpositionText.Text = "You encounter a mighty wizard!";
                GameWizardImage.IsVisible = true;
            }
        }

        //This method handles the player's attack round by choosing a number from a range of numbers for how much damage the player does and whether the player hits the monster.
        public void GameAttackButton_Clicked(object sender, EventArgs e)
        {
            Random playerHitRandom = new Random();
            Random randomSword = new Random();
            Random randomDagger = new Random();
            Random randomFist = new Random();
            Random randomStaff = new Random();

            playerHit = playerHitRandom.Next(0,10);
            swordDamage = randomSword.Next(30,50);
            daggerDamage = randomDagger.Next(10, 30);
            fistDamage = randomFist.Next(20, 40);
            staffDamage = randomStaff.Next(10, 20);

            if (fighterChosen)
            {
                if (playerHit >= 3)
                {
                    GamePlayerDamageText.Text = "Player Damage: " + swordDamage;
                    monsterHealth = monsterHealth - swordDamage;
                    GameMonsterHealthText.Text = "Monster Health: " + monsterHealth;
                    GameExpositionText.Text = "You strike the enemy with a sword!";
                }
                if (playerHit <= 2)
                {
                    GameExpositionText.Text = "You miss the enemy with a sword!";
                }
            }

            if (thiefChosen)
            {
                if (playerHit >= 3)
                {
                    GamePlayerDamageText.Text = "Dagger Damage: " + daggerDamage;
                    monsterHealth = monsterHealth - daggerDamage;
                    GameMonsterHealthText.Text = "Monster Health: " + monsterHealth;
                    GameExpositionText.Text = "You strike the enemy with a dagger!";
                }
                if (playerHit <= 2)
                {
                    GameExpositionText.Text = "You miss the enemy with a dagger!";
                }
            }

            if (blackBeltChosen)
            {
                if (playerHit >= 3)
                {
                    GamePlayerDamageText.Text = "Fist Damage: " + fistDamage;
                    monsterHealth = monsterHealth - fistDamage;
                    GameMonsterHealthText.Text = "Monster Health: " + monsterHealth;
                    GameExpositionText.Text = "You strike the enemy with a fist!";
                }
                if (playerHit <= 2)
                {
                    GameExpositionText.Text = "You miss the enemy with a fist!";
                }
            }

            if (redMageChosen)
            {
                if (playerHit >= 3)
                {
                    GamePlayerDamageText.Text = "Staff Damage: " + staffDamage;
                    monsterHealth = monsterHealth - staffDamage;
                    GameMonsterHealthText.Text = "Monster Health: " + monsterHealth;
                    GameExpositionText.Text = "You strike the enemy with a staff!";
                }
                if (playerHit <= 2)
                {
                    GameExpositionText.Text = "You miss the enemy with a staff!";
                }
            }

            if (blackMageChosen)
            {
                if (playerHit >= 3)
                {
                    GamePlayerDamageText.Text = "Staff Damage: " + staffDamage;
                    monsterHealth = monsterHealth - staffDamage;
                    GameMonsterHealthText.Text = "Monster Health: " + monsterHealth;
                    GameExpositionText.Text = "You strike the enemy with a staff!";
                }
                if (playerHit <= 2)
                {
                    GameExpositionText.Text = "You miss the enemy with a staff!";
                }
            }

            if (whiteMageChosen)
            {
                if (playerHit >= 3)
                {
                    GamePlayerDamageText.Text = "Staff Damage: " + staffDamage;
                    monsterHealth = monsterHealth - staffDamage;
                    GameMonsterHealthText.Text = "Monster Health: " + monsterHealth;
                    GameExpositionText.Text = "You strike the enemy with a staff!";
                }
                if (playerHit <= 2)
                {
                    GameExpositionText.Text = "You miss the enemy with a staff!";
                }
            }

            isMonsterDead();

        }

        //This method adds 25 points to the character's specific power type.
        public void GameDefendButton_Clicked(object sender, EventArgs e)
        {
            showNextButton();

            if(fighterChosen)
            {
                fighterCurrentRage = fighterCurrentRage + 25;
                GameCharacterMagicText.Text = "Rage: " + fighterCurrentRage;
            }

            if (thiefChosen)
            {
                thiefCurrentEnergy = thiefCurrentEnergy + 25;
                GameCharacterMagicText.Text = "Energy: " + thiefCurrentEnergy;
            }
            
            if(blackBeltChosen)
            {
            blackBeltCurrentChi = blackBeltCurrentChi + 25;
                GameCharacterMagicText.Text = "Chi: " + blackBeltCurrentChi;
            }

            if (redMageChosen)
            {
                redMageCurrentMagic = redMageCurrentMagic + 25;
                GameCharacterMagicText.Text = "Magic: " + redMageCurrentMagic;
            }
            
            if(blackMageChosen)
            {
                blackMageCurrentMagic = blackMageCurrentMagic + 25;
                GameCharacterMagicText.Text = "Magic: " + blackMageCurrentMagic;
            }

            if (whiteMageChosen)
            {
                whiteMageCurrentMagic = whiteMageCurrentMagic + 25;
                GameCharacterMagicText.Text = "Magic: " + whiteMageCurrentMagic;
            }                   

            if (fighterCurrentRage >= fighterRage && fighterChosen)
            {
                fighterCurrentRage = fighterRage;
                GameCharacterMagicText.Text = "Rage: " + fighterCurrentRage;
            }
            if (thiefCurrentEnergy >= thiefEnergy && thiefChosen)
            {
                thiefCurrentEnergy = thiefEnergy;
                GameCharacterMagicText.Text = "Energy: " + thiefCurrentEnergy;
            }
            if (blackBeltCurrentChi >= blackBeltChi && blackBeltChosen)
            {
                blackBeltCurrentChi = blackBeltChi;
                GameCharacterMagicText.Text = "Chi: " + blackBeltCurrentChi;
            }
            if (redMageCurrentMagic >= redMageMagic && redMageChosen)
            {
                redMageCurrentMagic = redMageMagic;
                GameCharacterMagicText.Text = "Magic: " + redMageCurrentMagic;
            }
            if (blackMageCurrentMagic >= blackMageMagic && blackMageChosen)
            {
                blackMageCurrentMagic = blackMageMagic;
                GameCharacterMagicText.Text = "Magic: " + blackMageCurrentMagic;
            }
            if (whiteMageCurrentMagic >= whiteMageMagic && whiteMageChosen)
            {
                whiteMageCurrentMagic = whiteMageMagic;
                GameCharacterMagicText.Text = "Magic: " + whiteMageCurrentMagic;
            }
            GameExpositionText.Text = "You concentrate hard and regain some power!";
        }

        //This method determines whether or not a player can run away by choosing a random value. If a value is above or below a certain number, the player either fails or successfully runs. 
        public void GameRunAwayButton_Clicked(object sender, EventArgs e)
        {
            Random runAwayRandom = new Random();

            runAway = runAwayRandom.Next(0, 10);

            if (runAway >= 5)
            {
                GameExpositionText.Text = "You bravely ran away!";
                hideBattleCommands();
                hideMonsters();
            }
            if (runAway <= 4)
            {
                GameExpositionText.Text = "You couldn't get away!";
                showNextButton();
            }
        }

        //This method calls the method which handles monster attacks and then shows the player's battle commands.
        public void GameMonsterAttackRoundButton_Clicked(object sender, EventArgs e)
        {
            monsterAttacks();

            showBattleCommands();
        }

        //This method fully restores the health of the player's character as well as their specific power type.
        public void GameRestButton_Clicked(object sender, EventArgs e)
        {
            fighterCurrentHealth = fighterCurrentHealth + 100;
            thiefCurrentHealth = thiefCurrentHealth + 100;
            blackBeltCurrentHealth = blackBeltCurrentHealth + 100;
            redMageCurrentHealth = redMageCurrentHealth + 100;
            blackMageCurrentHealth = blackMageCurrentHealth + 100;
            whiteMageCurrentHealth = whiteMageCurrentHealth + 100;

            fighterCurrentRage = fighterCurrentRage + 100;
            thiefCurrentEnergy = thiefCurrentEnergy + 100;
            blackBeltCurrentChi = blackBeltCurrentChi + 100;
            redMageCurrentMagic = redMageCurrentMagic + 100;
            blackMageCurrentMagic = blackMageCurrentMagic + 100;
            whiteMageCurrentMagic = whiteMageCurrentMagic + 100;

            if(fighterCurrentHealth >= fighterHealth && fighterChosen)
            {
                fighterCurrentHealth = fighterHealth;
                GameCharacterHealthText.Text = "Health: " + fighterCurrentHealth;
            }
            if (thiefCurrentHealth >= thiefHealth && thiefChosen)
            {
                thiefCurrentHealth = thiefHealth;
                GameCharacterHealthText.Text = "Health: " + thiefCurrentHealth;
            }
            if (blackBeltCurrentHealth >= blackBeltHealth && blackBeltChosen)
            {
                blackBeltCurrentHealth = blackBeltHealth;
                GameCharacterHealthText.Text = "Health: " + blackBeltCurrentHealth;
            }
            if (redMageCurrentHealth >= redMageHealth && redMageChosen)
            {
                redMageCurrentHealth = redMageHealth;
                GameCharacterHealthText.Text = "Health: " + redMageCurrentHealth;
            }
            if (blackMageCurrentHealth >= blackMageHealth && blackMageChosen)
            {
                blackMageCurrentHealth = blackMageHealth;
                GameCharacterHealthText.Text = "Health: " + blackMageCurrentHealth;
            }
            if (whiteMageCurrentHealth >= whiteMageHealth && whiteMageChosen)
            {
                whiteMageCurrentHealth = whiteMageHealth;
                GameCharacterHealthText.Text = "Health: " + whiteMageCurrentHealth;
            }

            if (fighterCurrentRage >= fighterRage && fighterChosen)
            {
                fighterCurrentRage = fighterRage;
                GameCharacterMagicText.Text = "Rage: " + fighterCurrentRage;
            }
            if (thiefCurrentEnergy >= thiefEnergy && thiefChosen)
            {
                thiefCurrentEnergy = thiefEnergy;
                GameCharacterMagicText.Text = "Energy: " + thiefCurrentEnergy;
            }
            if (blackBeltCurrentChi >= blackBeltChi && blackBeltChosen)
            {
                blackBeltCurrentChi = blackBeltChi;
                GameCharacterMagicText.Text = "Chi: " + blackBeltCurrentChi;
            }
            if (redMageCurrentMagic >= redMageMagic && redMageChosen)
            {
                redMageCurrentMagic = redMageMagic;
                GameCharacterMagicText.Text = "Magic: " + redMageCurrentMagic;
            }
            if (blackMageCurrentMagic >= blackMageMagic && blackMageChosen)
            {
                blackMageCurrentMagic = blackMageMagic;
                GameCharacterMagicText.Text = "Magic: " + blackMageCurrentMagic;
            }
            if (whiteMageCurrentMagic >= whiteMageMagic && whiteMageChosen)
            {
                whiteMageCurrentMagic = whiteMageMagic;
                GameCharacterMagicText.Text = "Magic: " + whiteMageCurrentMagic;
            }
            GameExpositionText.Text = "You feel completely revitalized!";
        }

        //These next methods handle each of the character's special attacks. They are handled in a similar way to the regular attacks. 
        //The difference is that these attacks are stronger, get the player gold, or use magical energy.
        public void GameRageAttackButton_Clicked(object sender, EventArgs e)
        {
            Random playerHitRandom = new Random();
            Random randomSword = new Random();

            playerHit = playerHitRandom.Next(0, 10);
            swordDamage = randomSword.Next(50, 100);

            if(fighterCurrentRage > 0)
            { 
                hasMagic = true;
            }
            else
            {
                hasMagic = false;
            }

            if (fighterCurrentRage <= 0)
            {
                fighterCurrentRage = 0;

                GameExpositionText.Text = "You have used up all your rage!";
            }

            if (hasMagic)
            {
                fighterCurrentRage = fighterCurrentRage - specialAttackCost;
                GameCharacterMagicText.Text = "Rage: " + fighterCurrentRage;

                //playerHit = playerHitRandom.Next(0, 10);
                //if (playerHit >= 5)
                //    {
                GamePlayerDamageText.Text = "Player Damage: " + swordDamage;
                monsterHealth = monsterHealth - swordDamage;
                GameMonsterHealthText.Text = "Monster Health: " + monsterHealth;
                GameExpositionText.Text = "In a fit of rage, you impale the enemy with a sword!";
                //}
                //    if (playerHit <= 4)
                //    {
                //    GameExpositionText.Text = "You miss the enemy with a sword!";                
                //}
                isMonsterDead();
            }
        }

        public void GamePilferAttackButton_Clicked(object sender, EventArgs e)
        {
            Random playerHitRandom = new Random();
            Random randomDagger = new Random();
            Random randomGold = new Random();

            playerHit = playerHitRandom.Next(0, 10);
            daggerDamage = randomDagger.Next(30, 80);
            lootedGold = randomGold.Next(0, 20);

            if (thiefCurrentEnergy > 0)
            {
                hasMagic = true;
            }
            else
            {
                hasMagic = false;
            }

            if (thiefCurrentEnergy <= 0)
            {
                thiefCurrentEnergy = 0;

                GameExpositionText.Text = "You have used up all your energy!";
            }

            if (hasMagic)
            {
                thiefCurrentEnergy = thiefCurrentEnergy - specialAttackCost;
                GameCharacterMagicText.Text = "Energy: " + thiefCurrentEnergy;

                //playerHit = playerHitRandom.Next(0, 10);
                //if (playerHit >= 5)
                //{
                GamePlayerDamageText.Text = "Player Damage: " + daggerDamage;
                monsterHealth = monsterHealth - daggerDamage;
                GameMonsterHealthText.Text = "Monster Health: " + monsterHealth;
                GameExpositionText.Text = "You slash the enemy with a dagger while stealing" + lootedGold + " gold!";
                //}
                //if (playerHit <= 4)
                //{
                //    GameExpositionText.Text = "You miss the enemy with a dagger!";
                //}
                isMonsterDead();
            }
        }
        public void GamePummelAttackButton_Clicked(object sender, EventArgs e)
        {
            Random playerHitRandom = new Random();
            Random randomFist = new Random();

            playerHit = playerHitRandom.Next(0, 10);
            fistDamage = randomFist.Next(40, 90);

            if (blackBeltCurrentChi > 0)
            {
                hasMagic = true;
            }
            else
            {
                hasMagic = false;
            }

            if (blackBeltCurrentChi <= 0)
            {
                blackBeltCurrentChi = 0;

                GameExpositionText.Text = "You have used up all your chi!";
            }

            if (hasMagic)
            {
                blackBeltCurrentChi = blackBeltCurrentChi - specialAttackCost;
                GameCharacterMagicText.Text = "Chi: " + blackBeltCurrentChi;

                //playerHit = playerHitRandom.Next(0, 10);
                //if (playerHit >= 5)
                //{
                GamePlayerDamageText.Text = "Player Damage: " + fistDamage;
                monsterHealth = monsterHealth - fistDamage;
                GameMonsterHealthText.Text = "Monster Health: " + monsterHealth;
                GameExpositionText.Text = "You hit the enemy with a wild fury of punches!";
                //}
                //if (playerHit <= 4)
                //{
                //    GameExpositionText.Text = "You miss the enemy with a fist!";
                //}
                isMonsterDead();
            }
        }

        public void GameFireBallAttackButton_Clicked(object sender, EventArgs e)
        {
            Random playerHitRandom = new Random();

            playerHit = playerHitRandom.Next(0, 10);
            fireBallDamage = 50;

            if (redMageChosen)
            {
                if (redMageCurrentMagic > 0)
                {
                    hasMagic = true;
                }
                else
                {
                    hasMagic = false;
                }

                if (redMageCurrentMagic <= 0)
                {
                    redMageCurrentMagic = 0;

                    GameExpositionText.Text = "You have used up all your magic!";
                }

                if (hasMagic)
                {
                    redMageCurrentMagic = redMageCurrentMagic - specialAttackCost;
                    GameCharacterMagicText.Text = "Magic: " + redMageCurrentMagic;
                    GamePlayerDamageText.Text = "Player Damage: " + fireBallDamage;
                    monsterHealth = monsterHealth - fireBallDamage;
                    GameMonsterHealthText.Text = "Monster Health: " + monsterHealth;
                    GameExpositionText.Text = "You engulf the enemy in a ball of flame!";
                    isMonsterDead();
                }
            }
            if (blackMageChosen)
            {
                if (blackMageCurrentMagic > 0)
                {
                    hasMagic = true;
                }
                else
                {
                    hasMagic = false;
                }

                if (blackMageCurrentMagic <= 0)
                {
                    blackMageCurrentMagic = 0;

                    GameExpositionText.Text = "You have used up all your magic!";
                }

                if (hasMagic)
                {
                    blackMageCurrentMagic = blackMageCurrentMagic - specialAttackCost;
                    GameCharacterMagicText.Text = "Magic: " + blackMageCurrentMagic;
                    GamePlayerDamageText.Text = "Player Damage: " + fireBallDamage;
                    monsterHealth = monsterHealth - fireBallDamage;
                    GameMonsterHealthText.Text = "Monster Health: " + monsterHealth;
                    GameExpositionText.Text = "You engulf the enemy in a ball of flame!";
                    isMonsterDead();
                }
            }
        }

        public void GameLightningAttackButton_Clicked(object sender, EventArgs e)
        {
            Random playerHitRandom = new Random();

            playerHit = playerHitRandom.Next(0, 10);
            lightningDamage = 50;

            if (redMageChosen)
            {
                if (redMageCurrentMagic > 0)
                {
                    hasMagic = true;
                }
                else
                {
                    hasMagic = false;
                }

                if (redMageCurrentMagic <= 0)
                {
                    redMageCurrentMagic = 0;

                    GameExpositionText.Text = "You have used up all your magic!";
                }

                if (hasMagic)
                {
                    redMageCurrentMagic = redMageCurrentMagic - specialAttackCost;
                    GameCharacterMagicText.Text = "Magic: " + redMageCurrentMagic;
                    GamePlayerDamageText.Text = "Player Damage: " + lightningDamage;
                    monsterHealth = monsterHealth - lightningDamage;
                    GameMonsterHealthText.Text = "Monster Health: " + monsterHealth;
                    GameExpositionText.Text = "A mighty bolt of lightning surges through the enemy!";
                    isMonsterDead();
                }
            }
            if (blackMageChosen)
            {
                if (blackMageCurrentMagic > 0)
                {
                    hasMagic = true;
                }
                else
                {
                    hasMagic = false;
                }

                if (blackMageCurrentMagic <= 0)
                {
                    blackMageCurrentMagic = 0;

                    GameExpositionText.Text = "You have used up all your magic!";
                }

                if (hasMagic)
                {
                    blackMageCurrentMagic = blackMageCurrentMagic - specialAttackCost;
                    GameCharacterMagicText.Text = "Magic: " + blackMageCurrentMagic;
                    GamePlayerDamageText.Text = "Player Damage: " + lightningDamage;
                    monsterHealth = monsterHealth - lightningDamage;
                    GameMonsterHealthText.Text = "Monster Health: " + monsterHealth;
                    GameExpositionText.Text = "A mighty bolt of lightning surges through the enemy!";
                    isMonsterDead();
                }
            }
            if (whiteMageChosen)
            {
                if (whiteMageCurrentMagic > 0)
                {
                    hasMagic = true;
                }
                else
                {
                    hasMagic = false;
                }

                if (whiteMageCurrentMagic <= 0)
                {
                    whiteMageCurrentMagic = 0;

                    GameExpositionText.Text = "You have used up all your magic!";
                }

                if (hasMagic)
                {
                    whiteMageCurrentMagic = whiteMageCurrentMagic - specialAttackCost;
                    GameCharacterMagicText.Text = "Magic: " + whiteMageCurrentMagic;
                    GamePlayerDamageText.Text = "Player Damage: " + lightningDamage;
                    monsterHealth = monsterHealth - lightningDamage;
                    GameMonsterHealthText.Text = "Monster Health: " + monsterHealth;
                    GameExpositionText.Text = "A mighty bolt of lightning surges through the enemy!";
                    isMonsterDead();
                }
            }
        }

        public void GameDarknessAttackButton_Clicked(object sender, EventArgs e)
        {
            Random playerHitRandom = new Random();

            playerHit = playerHitRandom.Next(0, 10);
            darkDamage = 50;

            if (blackMageChosen)
            {
                if (blackMageCurrentMagic > 0)
                {
                    hasMagic = true;
                }
                else
                {
                    hasMagic = false;
                }

                if (blackMageCurrentMagic <= 0)
                {
                    blackMageCurrentMagic = 0;

                    GameExpositionText.Text = "You have used up all your magic!";
                }

                if (hasMagic)
                {
                    blackMageCurrentMagic = blackMageCurrentMagic - specialAttackCost;
                    GameCharacterMagicText.Text = "Magic: " + blackMageCurrentMagic;
                    GamePlayerDamageText.Text = "Player Damage: " + darkDamage;
                    monsterHealth = monsterHealth - darkDamage;
                    GameMonsterHealthText.Text = "Monster Health: " + monsterHealth;
                    GameExpositionText.Text = "A cloud of dark gas envelops the enemy!";
                    isMonsterDead();
                }
            }
        }

        public void GameHarmAttackButton_Clicked(object sender, EventArgs e)
        {
            Random playerHitRandom = new Random();

            playerHit = playerHitRandom.Next(0, 10);
            harmDamage = 50;

            if (whiteMageChosen)
            {
                if (whiteMageCurrentMagic > 0)
                {
                    hasMagic = true;
                }
                else
                {
                    hasMagic = false;
                }

                if(whiteMageCurrentMagic <= 0)
                {
                    whiteMageCurrentMagic = 0;

                    GameExpositionText.Text = "You have used up all your magic!";
                }

                if (hasMagic)
                {
                    whiteMageCurrentMagic = whiteMageCurrentMagic - specialAttackCost;
                    GameCharacterMagicText.Text = "Magic: " + whiteMageCurrentMagic;
                    GamePlayerDamageText.Text = "Player Damage: " + harmDamage;
                    monsterHealth = monsterHealth - harmDamage;
                    GameMonsterHealthText.Text = "Monster Health: " + monsterHealth;
                    GameExpositionText.Text = "A bright light surrounds the enemy!";
                    isMonsterDead();
                }
            }
        }
    }
}