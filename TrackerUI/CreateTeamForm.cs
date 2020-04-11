using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTrackerLibrary;
using TTrackerLibrary.DataAccess;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connections.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
        private ITeamRequester callingForm;
        public CreateTeamForm(ITeamRequester caller)
        {
            InitializeComponent();
            callingForm = caller;
            WireUpDD();
        }
        private void addTeamBtn_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)teamMemberDropDown.SelectedItem;
            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);
                WireUpDD();
            }
        }
        private void WireUpDD()
        {
            teamMemberDropDown.DataSource = null;
            teamMemberDropDown.DataSource = availableTeamMembers;
            teamMemberDropDown.DisplayMember = "FullName";

            tmMemberListBox.DataSource = null;
            tmMemberListBox.DataSource = selectedTeamMembers;
            tmMemberListBox.DisplayMember = "FullName";
        }
        private void createMemberBtn_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel model = new PersonModel();
                model.FirstName = fNameInput.Text;
                model.LastName = lNameInput.Text;
                model.EmailAddress = mailInput.Text;
                model.PhoneNumber = mobileInput.Text;

                // Here sending model data to db.
                GlobalConfig.Connections.CreatePerson(model);
                selectedTeamMembers.Add(model);
                WireUpDD();

                ClearForm();

            }
            else
            {
                MessageBox.Show("Invalid");
            }
        }
        private bool ValidateForm()
        {
            if (fNameInput.Text.Length == 0)
            {
                return false;
            }
            if (lNameInput.Text.Length == 0)
            {
                return false;
            }
            if (mailInput.Text.Length == 0)
            {
                return false;
            }
            if (mobileInput.Text.Length == 0)
            {
                return false;
            }
            return true;
        }
        private void ClearForm()
        {
            fNameInput.Text = "";
            lNameInput.Text = "";
            mailInput.Text = "";
            mobileInput.Text = "";
        }
        private void dltMemberBtn_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)tmMemberListBox.SelectedItem;
            if (p != null)
            {
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);
                WireUpDD();
            }
        }
        private void createTeamBtn_Click(object sender, EventArgs e)
        {
            //save team and get team id
            TeamModel model = new TeamModel();
            model.TeamName = teamNameInput.Text;
            model.TeamMembers = selectedTeamMembers;
            GlobalConfig.Connections.CreateTeam(model);
            callingForm.TeamComplete(model);
            this.Close();



        }
    }
}
