using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using MyFacebookLogic;

namespace MyFacebookUI
{
    public delegate Utilities.eGuessType NamePressed<T>(T i_NamePressed);

    public partial class FacebookForm : Form
    {
        private const string k_LoginTitleBar = " logged in to MyFacebook App";
        private readonly Image r_LiveImage = Properties.Resources.lives;
        private readonly Image r_skullImage = Properties.Resources.skull2;
        private readonly Image r_GameOver = Properties.Resources.gameOver;
        private readonly Image r_GuessWhoHeadLine = Properties.Resources.GuessWhoHeadLine;
        private readonly Image r_WinnerAnima = Properties.Resources.winner_anima;
        private bool m_eventIsBeingEdited = false;
        private LoginResult m_LoginResult;
        private User m_LoggedInUser;
        private List<PictureBox> m_LiveImageList;
        private MyFacbookLogicFacade m_AppLogicFacade;
        private ImageFilter m_ImageFilter;

        //public event NamePressed<string> m_NameHandler;

        private void facebookForm_Load(object sender, EventArgs e)
        {
            m_AppLogicFacade = new MyFacbookLogicFacade();

            m_AppLogicFacade.LoadSettingsFromFile();

            this.rememberMeCheckBox.Checked = m_AppLogicFacade.isLastUserRemembered();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if (m_AppLogicFacade.isLastUserRemembered())
            {
                Location = m_AppLogicFacade.AppSettings.m_LastWindowLocation;
                m_LoginResult = FacebookService.Connect(m_AppLogicFacade.AppSettings.m_LastAccessToken);

                new Thread(preapreAllAppComponents).Start();
            }
        }

        public FacebookForm()
        {
            InitializeComponent();

            new Thread(beforeLoginMode).Start();
        }

        private void beforeLoginMode()
        {
            checkIfCurrentThreadCreatordAndExecute(waitForLoginMode, this);
        }

        private void logInToFacebook()
        {
            m_LoginResult = FacebookService.Login(
                "879866769045693",
                "user_events",
                "user_friends",
                "user_photos",
                "user_birthday");

            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser;

                new Thread(preapreAllAppComponents).Start();
            }
            else
            {
                MessageBox.Show(m_LoginResult.ErrorMessage);
            }
        }

        private void preapreAllAppComponents()
        {
            checkIfCurrentThreadCreatordAndExecute(prepareApplicationAfterLogin, this);
        }

        private void prepareApplicationAfterLogin()
        {
            exitFromLogin();
           
            m_LoggedInUser = m_LoginResult.LoggedInUser;
            m_AppLogicFacade.SetFeaturesLogic(m_LoggedInUser);

            new Thread(initializeDelegates).Start();

            Text = m_LoggedInUser.Name + k_LoginTitleBar;

            initAllForGame();

            try
            {
                fetchUserInfo();
            }
            catch (Exception)
            {
                MessageBox.Show(string.Format(
                    "Error: An problem has been occurred! {0}" +
                    "No permission for user details from Facebook!",
                    Environment.NewLine));
            }

            this.Show();
        }

        private void checkIfCurrentThreadCreatordAndExecute(Action i_FuncToExecute, FacebookForm i_FacebookForm)
        {
            if(!i_FacebookForm.InvokeRequired)
            {
                i_FuncToExecute.Invoke();
            }
            else
            {
                i_FacebookForm.Invoke(i_FuncToExecute);
            }
        }

        private void doneEditing()
        {
            m_eventIsBeingEdited = false;
        }

        private void fetchUserInfo()
        {
            monthCalendar1.BoldedDates = m_AppLogicFacade.GetDatesToMark();

            if (m_AppLogicFacade.ThereIsNoFriends())
            {
                MessageBox.Show("No Friends to retrieve :(");
            }
        }

        private void initializeLiveImageList()
        {
            m_LiveImageList = new List<PictureBox>();

            m_LiveImageList.Add(pictureBox1);
            m_LiveImageList.Add(pictureBox2);
            m_LiveImageList.Add(pictureBox3);
            m_LiveImageList.Add(pictureBox4);
            m_LiveImageList.Add(pictureBox5);
            m_LiveImageList.Add(pictureBox6);
            m_LiveImageList.Add(pictureBox7);

            foreach (PictureBox pictureBox in m_LiveImageList)
            {
                pictureBox.Visible = true;
                Bitmap bmp = new Bitmap(r_LiveImage);
                bmp.MakeTransparent(Color.White);
                pictureBox.Image = bmp;
            }
        }

        private void handleWrongGuess(string i_MessageToUser)
        {
            informUserResult(i_MessageToUser);
            decreaseOneLiveAndShowToUser();
        }

        private void decreaseOneLiveAndShowToUser()
        {
            m_LiveImageList[m_AppLogicFacade.CounterLives() - 1].Image = r_skullImage;

            m_AppLogicFacade.OnWrongGuess();

            if (m_AppLogicFacade.IsGameOver())
            {
                guessWhoGameOver();
            }
        }

        private void handleCorrectGuess(string i_MessageToUser)
        {
            informUserResult(i_MessageToUser);
            imageProfileBox.Image = r_WinnerAnima;
            changeButtonsVisibility(false);
        }

        private void guessWhoGameOver()
        {
            imageProfileBox.Image = r_GameOver;

            changeButtonsVisibility(false);
        }

        private void changeButtonsVisibility(bool i_IsVisible)
        {
            submitBox.Text = null;
            submit.Visible = i_IsVisible;
            hintButton.Visible = i_IsVisible;
            label1.Visible = i_IsVisible;
            submitBox.Enabled = i_IsVisible;
        }

        private void informUserResult(string i_MessageToUser)
        {
            MessageBox.Show(i_MessageToUser);
        }

        private void restart_Click(object sender, EventArgs e)
        {
            initAllForGame();
            changeButtonsVisibility(true);
            movingToChooseBlurMode();
        }

        private void hintButton_Click(object sender, EventArgs e)
        {
            imageProfileBox.Image = m_ImageFilter.ChangeBlurness();

            decreaseOneLiveAndShowToUser();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            //string messageToUser;
            //string additionalString;

            string inputString = submitBox.Text;

            m_AppLogicFacade.onGuess(inputString);
            //Utilities.eGuessType userGuess = m_NameHandler(inputString);

            //if (m_AppLogicFacade.IsCorrect(userGuess))
            //{
            //    messageToUser = string.Format("Correct Guess!{0} Wanna play again?", Environment.NewLine);

            //}
            //else if (userGuess == Utilities.eGuessType.PARTIAL_FIRST_NAME)
            //{
            //    additionalString = string.Format("FirST Name");
            //}

            //else if (userGuess == Utilities.eGuessType.PARTIAL_FIRST_NAME)
            //{

            //}
            //messageToUser = string.Format("Wrong Guess!{0} Please Try Again!", Environment.NewLine);
            //m_AppLogicFacade.onGuess(messageToUser, Utilities.eGuessType.WRONG);
        }


        private void logoutbtn_Click(object sender, EventArgs e)
        {
            FacebookService.Logout(logoutUser);
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            logInToFacebook();
        }

        private void MonthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            IEnumerable<string> friendsBornInThatDate = new List<string>();
            IEnumerable<IEvent> eventsThatDate = new List<EventProxy>();
            birthDayFriendsListBox.Items.Clear();
            EventsOnDateListBox.Items.Clear();
            friendsBornInThatDate = m_AppLogicFacade.GetFriendsWhoBornThatDate(e.Start);

            foreach (string friendName in friendsBornInThatDate)
            {
                birthDayFriendsListBox.Items.Add(friendName);
            }

            eventsThatDate = m_AppLogicFacade.GetEventsOnThatDate(e.Start);
            EventsOnDateListBox.DisplayMember = "Name";
            foreach (IEvent eventName in eventsThatDate)
            {
                EventsOnDateListBox.Items.Add(eventName);
            }
        }

        private void postBtn_Click(object sender, EventArgs e)
        {
            string postContent = postEventTextBox.Text;
            if (!string.IsNullOrEmpty(postContent))
            {
                try
                {
                    m_LoggedInUser.PostStatus(postContent);
                    MessageBox.Show("Status Posted!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Something went wrong, post failed..");
                }

                postEventTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Can't post no text, please write something");
            }
        }

        private void EventsOnDateListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!m_eventIsBeingEdited)
            {
                m_eventIsBeingEdited = true;
                IEvent selectedEvent = (IEvent)sender;
                Form editEvent = new EditEventForm(selectedEvent, doneEditing);
                editEvent.Show();
            }
        }

        private void exitFromLogin()
        {
            TabControl.TabPages.Insert(1, tabPageChooseBlur);
            postbtn.Visible = true;
            logoutbtn.Visible = true;
            loginbtn.Visible = false;
            monthCalendar1.Enabled = true;
            rememberMeCheckBox.Visible = false;
        }

        private void waitForLoginMode()
        {
            TabControl.TabPages.Remove(tabPageGuessWhoGame);
            TabControl.TabPages.Remove(tabPageChooseBlur);

            postbtn.Visible = false;
            logoutbtn.Visible = false;
            loginbtn.Visible = true;
            monthCalendar1.Enabled = false;
            rememberMeCheckBox.Visible = true;
        }

        private void logoutUser()
        {
            if (m_LoggedInUser != null)
            {
                new Thread(beforeLoginMode).Start();
                m_LoggedInUser = null;
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            m_AppLogicFacade.AppSettings.m_LastWindowLocation = this.Location;
            m_AppLogicFacade.AppSettings.m_RememberUser = this.rememberMeCheckBox.Checked;

            if (m_AppLogicFacade.AppSettings.m_RememberUser)
            {
                m_AppLogicFacade.AppSettings.m_LastAccessToken = m_LoginResult.AccessToken;
            }
            else
            {
                m_AppLogicFacade.AppSettings.m_LastAccessToken = null;
            }

            m_AppLogicFacade.AppSettings.SaveToFile();

            logoutbtn.PerformClick();
        }

        private void pictureBoxTranparent_Click(object sender, EventArgs e)
        {
            m_ImageFilter = ImageFactory.CreateImageFilter(
                Utilities.eFilterType.TRANPARENT,
                m_AppLogicFacade.CurrentUserShown().ImageNormal);

            movingToPlayMode();
        }

        private void pictureBoxGamma_Click(object sender, EventArgs e)
        {
            m_ImageFilter = ImageFactory.CreateImageFilter(
                Utilities.eFilterType.GAMMA,
                m_AppLogicFacade.CurrentUserShown().ImageNormal);

            movingToPlayMode();
        }

        private void pictureBoxBlur_Click(object sender, EventArgs e)
        {
            m_ImageFilter = ImageFactory.CreateImageFilter(
                Utilities.eFilterType.BLUR,
                m_AppLogicFacade.CurrentUserShown().ImageNormal);

            movingToPlayMode();
        }

        private void movingToChooseBlurMode()
        {
            TabControl.TabPages.Remove(tabPageGuessWhoGame);
            TabControl.TabPages.Insert(1, tabPageChooseBlur);

            TabControl.SelectedTab = tabPageChooseBlur;
        }

        private void movingToPlayMode()
        {
            imageProfileBox.Image = m_ImageFilter.ResetImageFilter();

            TabControl.TabPages.Remove(tabPageChooseBlur);
            TabControl.TabPages.Insert(1, tabPageGuessWhoGame);

            TabControl.SelectedTab = tabPageGuessWhoGame;
        }

        private void initAllForGame()
        {
            new Thread(m_AppLogicFacade.PrepareComponents).Start();
           initializeLiveImageList();
        }

        private void initializeDelegates()
        {
            //m_NameHandler += m_AppLogicFacade.handleNamePressed;

            m_AppLogicFacade.initDelegatesInGuessWho(handleCorrectGuess, handleWrongGuess);
        }
    }
}
