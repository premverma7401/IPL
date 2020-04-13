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
    public partial class CreateTournamentForm : Form, IPrizeRequester, ITeamRequester
    {
        private List<TeamModel> availableTeams = GlobalConfig.Connections.GetTeam_All();
        private List<PrizeModel> selectedPrizes = new List<PrizeModel>();
        private List<TeamModel> selectedTeams = new List<TeamModel>();


        public CreateTournamentForm()
        {
            InitializeComponent();
            WireUpDD();
        }


        private void createTournamentBtn_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                TournamentModel model = new TournamentModel(eFeeInput.Text);
                model.TournamentName = trnNameInput.Text;
                model.EnteredTeams = selectedTeams;
                model.Prizes = selectedPrizes;

                // Create tournament goes here
                TournamentLogic.CreateRounds(model);
                GlobalConfig.Connections.CreateTournament(model);
                this.Close();
              
            }
            else
            {
                MessageBox.Show("Invalid");
            }
        }

        private bool Validation()
        {
            if (trnNameInput.Text.Length == 0)
            {
                return false;
            }
            decimal EntreeFee = 0;
            bool feeValidAmount = decimal.TryParse(eFeeInput.Text, out EntreeFee);
            return true;
        }

        private void addTeamBtn_Click(object sender, EventArgs e)
        {
            TeamModel p = (TeamModel)selectTeamDropDown.SelectedItem;
            if (p != null)
            {
                availableTeams.Remove(p);
                selectedTeams.Add(p);
                WireUpDD();
            }
        }
        private void WireUpDD()
        {
            selectTeamDropDown.DataSource = null;
            selectTeamDropDown.DataSource = availableTeams;
            selectTeamDropDown.DisplayMember = "TeamName";

            trnPlayerListBox.DataSource = null;
            trnPlayerListBox.DataSource = selectedTeams;
            trnPlayerListBox.DisplayMember = "TeamName";

            prizeListBox.DataSource = null;
            prizeListBox.DataSource = selectedPrizes;
            prizeListBox.DisplayMember = "PlaceName";
        }

        private void dltTeamPlyBtn_Click(object sender, EventArgs e)
        {

            TeamModel p = (TeamModel)trnPlayerListBox.SelectedItem;
            if (p != null)
            {
                selectedTeams.Remove(p);
                availableTeams.Add(p);
                WireUpDD();
            }

        }

        private void dtlPrizeBtn_Click(object sender, EventArgs e)
        {

            PrizeModel p = (PrizeModel)prizeListBox.SelectedItem;
            if (p != null)
            {
                selectedPrizes.Remove(p);
                WireUpDD();
            }

        }

        private void createPrizeBtn_Click(object sender, EventArgs e)
        {
            CreatePrizeForm frm = new CreatePrizeForm(this);
            frm.Show();
        }

        public void PrizeComplete(PrizeModel model)
        {
            selectedPrizes.Add(model);
            WireUpDD();
        }

        private void prizeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void createNewLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeamForm frm = new CreateTeamForm(this);
            frm.Show();
        }

        public void TeamComplete(TeamModel model)
        {
            selectedTeams.Add(model);
            WireUpDD();
        }
    }
}
