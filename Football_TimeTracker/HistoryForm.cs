﻿using Newtonsoft.Json;
using Octokit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Football_TimeTracker
{
    public partial class HistoryForm : Form
    {
        List<Segment> totalSegments, tempSegments;
        int numberOfGames;
        List<Game> tempGames, nameGames, competitionGames, dateGames, loadedGames;
        GitHubClient github;
        

        public HistoryForm()
        {
            InitializeComponent();
            this.FormClosing += HistoryForm_FormClosing;
            PieChart.Series[ 0 ].Points[ 0 ].LegendText = "A seguir";
            PieChart.Series[ 0 ].Points[ 1 ].LegendText = "Bola fora";
            PieChart.Series[ 0 ].Points[ 2 ].LegendText = "Arbitro apita";
            PieChart.Series[ 0 ].Points[ 3 ].LegendText = "Golo";
            totalSegments = new List<Segment>();

            InterceptKeys.ResizeForm( this ); //resize form
            CenterToScreen(); // then center
        }

        private void HistoryForm_Load( object sender, EventArgs e )
        {
            DataGridViewButtonColumn SelectButton = new DataGridViewButtonColumn();
            SelectButton.Name = "Ver Detalhe";
            SelectButton.Text = "Detalhe";
            SelectButton.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Insert( 5, SelectButton );

            loadedGames = new List<Game>();

            var path = Directory.CreateDirectory( Constants.SavesDir );
            string[] files = Directory.GetFiles( path.Name, "*.txt" );
            string[] info;
            foreach ( string file in files )
            {
                if ( !file.Contains( '\\' ) )
                    continue;
                if ( !file.Contains( '.' ) )
                    continue;

                info = file.Split( '\\' );
                info = info[ 1 ].Split( '.' );
                info = info[ 0 ].Split( '_' );

                if ( info.Length != 3 )
                    continue;

                if (loadedGames.Any( x => x.Name == info[ 0 ] && x.Date == info[ 2 ] ))
                    continue;

                Game loadingGame = new Game() { filePath = file, Name = info[ 0 ], Competition = info[ 1 ], Date = info[ 2 ] };
                loadedGames.Add( loadingGame );

                dataGridView1.Rows.Add( loadingGame.filePath, false, loadingGame.Name, loadingGame.Competition, loadingGame.Date, null );
            }

            dataGridView1.Sort( GameDate, ListSortDirection.Descending );
        }

        private void BackButton_Click( object sender, EventArgs e )
        {
            InterceptKeys.CloseHistory();
        }

        private void HistoryForm_FormClosing( Object sender, FormClosingEventArgs e )
        {
            System.Windows.Forms.Application.Exit();
        }

        private void dataGridView1_SortCompare( object sender, DataGridViewSortCompareEventArgs e )
        {
            if(e.Column == GameDate)
            {
                string s1 = e.CellValue1.ToString();
                string s2 = e.CellValue2.ToString();

                DateTime d1 = DateTime.Parse(s1);
                DateTime d2 = DateTime.Parse(s2);

                e.SortResult = d1.CompareTo( d2 );
                e.Handled = true;
            }
        }

        private void dataGridView1_CellContentClick( object sender, DataGridViewCellEventArgs e )
        {
            var senderGrid = (DataGridView)sender;

            if ( senderGrid.Columns[ e.ColumnIndex ] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 )
            {
                var path = senderGrid.Rows[ e.RowIndex ].Cells[0].Value;
                InterceptKeys.ShowHistoryDetail(path.ToString());
            }

            if ( senderGrid.Columns[ e.ColumnIndex ] is DataGridViewCheckBoxColumn &&
                e.RowIndex >= 0 )
            {
                senderGrid.CommitEdit( DataGridViewDataErrorContexts.Commit );
                
                LoadSelectedGames( senderGrid );
            }
        }

        private void LoadSelectedGames( DataGridView sender)
        {
            totalSegments = new List<Segment>();
            List<Segment> currSegments = new List<Segment>();
            numberOfGames = 0;
            foreach ( DataGridViewRow row in sender.Rows )
            {
                bool isSelected = Convert.ToBoolean( row.Cells[ "SelectedCheckbox" ].Value );
                if ( isSelected )
                {
                    string path = row.Cells[ 0 ].Value.ToString();

                    List<Segment> thisSegment = JsonSerialization.ReadFromJsonFile<List<Segment>>( path );
                    totalSegments.AddRange( thisSegment );
                    numberOfGames++;

                }
            }

            UpdateTotals();
        }

        private void UpdateTotals()
        {
            #region Text Stats
            int elapsedMinutesActive = 0;
            int elapsedMinutesOutofBounds = 0;
            int elapsedMinutesRefBlow = 0;
            int elapsedMinutesGoal = 0;

            int elapsedSecondsActive = totalSegments.Where( x => x.segmentType == Constants.segmentTypeActive ).Sum( x => x.elapsedSeconds );
            int elapsedSecondsOutofBounds = totalSegments.Where( x => x.segmentType == Constants.segmentTypeOutofBounds ).Sum( x => x.elapsedSeconds );
            int elapsedSecondsRefBlow = totalSegments.Where( x => x.segmentType == Constants.segmentTypeRefBlow ).Sum( x => x.elapsedSeconds );
            int elapsedSecondsGoal = totalSegments.Where( x => x.segmentType == Constants.segmentTypeGoal ).Sum( x => x.elapsedSeconds );

            if (numberOfGames > 0)
            {
                elapsedSecondsActive = elapsedSecondsActive / numberOfGames;
                elapsedSecondsOutofBounds = elapsedSecondsOutofBounds / numberOfGames;
                elapsedSecondsRefBlow = elapsedSecondsRefBlow / numberOfGames;
                elapsedSecondsGoal = elapsedSecondsGoal / numberOfGames;
            }

            while ( elapsedSecondsActive >= 60 )
            {
                elapsedSecondsActive -= 60;
                elapsedMinutesActive++;
            }
            while ( elapsedSecondsOutofBounds >= 60 )
            {
                elapsedSecondsOutofBounds -= 60;
                elapsedMinutesOutofBounds++;
            }
            while ( elapsedSecondsRefBlow >= 60 )
            {
                elapsedSecondsRefBlow -= 60;
                elapsedMinutesRefBlow++;
            }
            while ( elapsedSecondsGoal >= 60 )
            {
                elapsedSecondsGoal -= 60;
                elapsedMinutesGoal++;
            }


            StateActiveTimer.Text = elapsedMinutesActive.ToString( "D2" ) + ":" + elapsedSecondsActive.ToString( "D2" );
            StateOutofBoundsTimer.Text = elapsedMinutesOutofBounds.ToString( "D2" ) + ":" + elapsedSecondsOutofBounds.ToString( "D2" );
            StateRefBlowTimer.Text = elapsedMinutesRefBlow.ToString( "D2" ) + ":" + elapsedSecondsRefBlow.ToString( "D2" );
            StateGoalTimer.Text = elapsedMinutesGoal.ToString( "D2" ) + ":" + elapsedSecondsGoal.ToString( "D2" );

            int TotalMinutes = 0;
            int TotalSeconds = totalSegments.Sum( x => x.elapsedSeconds );
            if (numberOfGames > 0)
                TotalSeconds = TotalSeconds / numberOfGames;
            while ( TotalSeconds >= 60 )
            {
                TotalSeconds -= 60;
                TotalMinutes++;
            }
            TotalGameTimeLabel.Text = TotalMinutes.ToString( "D2" ) + ":" + TotalSeconds.ToString( "D2" );
            #endregion

            #region Pie Chart

            elapsedSecondsActive = totalSegments.Where( x => x.segmentType == Constants.segmentTypeActive ).Sum( x => x.elapsedSeconds );
            elapsedSecondsOutofBounds = totalSegments.Where( x => x.segmentType == Constants.segmentTypeOutofBounds ).Sum( x => x.elapsedSeconds );
            elapsedSecondsRefBlow = totalSegments.Where( x => x.segmentType == Constants.segmentTypeRefBlow ).Sum( x => x.elapsedSeconds );
            elapsedSecondsGoal = totalSegments.Where( x => x.segmentType == Constants.segmentTypeGoal ).Sum( x => x.elapsedSeconds );

            int totalSecondsElapsed = elapsedSecondsActive + elapsedSecondsOutofBounds + elapsedSecondsRefBlow + elapsedSecondsGoal;

            if ( elapsedSecondsActive > 0 )
            {
                PieChart.Series[ 0 ].Points[ 0 ].IsEmpty = false;
                PieChart.Series[ 0 ].Points[ 0 ].Label = ( ( (decimal)elapsedSecondsActive / (decimal)totalSecondsElapsed ) * 100 ).ToString( "0.##" ) + "%";
            }
            else
            {
                PieChart.Series[ 0 ].Points[ 0 ].Label = "";
            }
            if ( elapsedSecondsOutofBounds > 0 )
            {
                PieChart.Series[ 0 ].Points[ 1 ].IsEmpty = false;
                PieChart.Series[ 0 ].Points[ 1 ].Label = ( ( (decimal)elapsedSecondsOutofBounds / (decimal)totalSecondsElapsed ) * 100 ).ToString( "0.##" ) + "%";
            }
            else
            {
                PieChart.Series[ 0 ].Points[ 1 ].Label = "";
            }
            if ( elapsedSecondsRefBlow > 0 )
            {
                PieChart.Series[ 0 ].Points[ 2 ].IsEmpty = false;
                PieChart.Series[ 0 ].Points[ 2 ].Label = ( ( (decimal)elapsedSecondsRefBlow / (decimal)totalSecondsElapsed ) * 100 ).ToString( "0.##" ) + "%";
            }
            else
            {
                PieChart.Series[ 0 ].Points[ 2 ].Label = "";
            }
            if ( elapsedSecondsGoal > 0 )
            {
                PieChart.Series[ 0 ].Points[ 3 ].IsEmpty = false;
                PieChart.Series[ 0 ].Points[ 3 ].Label = ( ( (decimal)elapsedSecondsGoal / (decimal)totalSecondsElapsed ) * 100 ).ToString( "0.##" ) + "%";
            }
            else
            {
                PieChart.Series[ 0 ].Points[ 3 ].Label = "";
            }

            PieChart.Series[ 0 ].Points[ 0 ].SetValueY( elapsedSecondsActive );
            PieChart.Series[ 0 ].Points[ 1 ].SetValueY( elapsedSecondsOutofBounds );
            PieChart.Series[ 0 ].Points[ 2 ].SetValueY( elapsedSecondsRefBlow );
            PieChart.Series[ 0 ].Points[ 3 ].SetValueY( elapsedSecondsGoal );
            #endregion

            #region Other Text Stats
            totalGamesResult.Text = numberOfGames.ToString();
            int formattedMinutes, formattedSeconds;

            Segment biggestActive = totalSegments.Where( x => x.segmentType == Constants.segmentTypeActive ).OrderByDescending( x => x.elapsedSeconds ).FirstOrDefault();
            if ( biggestActive != null )
            {
                formattedMinutes = 0;
                formattedSeconds = biggestActive.elapsedSeconds;
                while ( formattedSeconds >= 60 )
                {
                    formattedSeconds -= 60;
                    formattedMinutes++;
                }
                biggestActiveSegmentResult.Text = formattedMinutes.ToString( "D2" ) + ":" + formattedSeconds.ToString( "D2" );
            }
            else
            {
                biggestActiveSegmentResult.Text = "00:00";
            }
            Segment biggestStopped = totalSegments.Where( x => x.segmentType != Constants.segmentTypeActive ).OrderByDescending( x => x.elapsedSeconds ).FirstOrDefault();
            if ( biggestStopped != null )
            {
                formattedMinutes = 0;
                formattedSeconds = biggestStopped.elapsedSeconds;
                while ( formattedSeconds >= 60 )
                {
                    formattedSeconds -= 60;
                    formattedMinutes++;
                }
                switch ( biggestStopped.segmentType )
                {
                    case Constants.segmentTypeOutofBounds:
                        biggestStoppedSegmentLabel.BackColor = Constants.colorSegmentOutofBounds;
                        biggestStoppedSegmentResult.BackColor = Constants.colorSegmentOutofBounds;
                        averageStoppedSegmentLabel.BackColor = Constants.colorSegmentOutofBounds;
                        averageStoppedSegmentResult.BackColor = Constants.colorSegmentOutofBounds;
                        break;
                    case Constants.segmentTypeRefBlow:
                        biggestStoppedSegmentLabel.BackColor = Constants.colorSegmentRefBlow;
                        biggestStoppedSegmentResult.BackColor = Constants.colorSegmentRefBlow;
                        averageStoppedSegmentLabel.BackColor = Constants.colorSegmentRefBlow;
                        averageStoppedSegmentResult.BackColor = Constants.colorSegmentRefBlow;
                        break;
                    case Constants.segmentTypeGoal:
                        biggestStoppedSegmentLabel.BackColor = Constants.colorSegmentGoal;
                        biggestStoppedSegmentResult.BackColor = Constants.colorSegmentGoal;
                        averageStoppedSegmentLabel.BackColor = Constants.colorSegmentGoal;
                        averageStoppedSegmentResult.BackColor = Constants.colorSegmentGoal;
                        break;
                }
                biggestStoppedSegmentResult.Text = formattedMinutes.ToString( "D2" ) + ":" + formattedSeconds.ToString( "D2" );
            }
            else
            {
                biggestStoppedSegmentLabel.BackColor = Constants.colorBackgroundGray;
                biggestStoppedSegmentResult.BackColor = Constants.colorBackgroundGray;
                averageStoppedSegmentLabel.BackColor = Constants.colorBackgroundGray;
                averageStoppedSegmentResult.BackColor = Constants.colorBackgroundGray;
                biggestStoppedSegmentResult.Text = "00:00";
            }

            int CountSecondsActive = totalSegments.Where( x => x.segmentType == Constants.segmentTypeActive ).Count();
            if ( CountSecondsActive > 0 )
            {
                int TotalSecondsActive = totalSegments.Where( x => x.segmentType == Constants.segmentTypeActive ).Sum( x => x.elapsedSeconds );
                int AverageActiveSeconds = TotalSecondsActive / CountSecondsActive;
                int AverageActiveMinutes = 0;
                while ( AverageActiveSeconds >= 60 )
                {
                    AverageActiveSeconds -= 60;
                    AverageActiveMinutes++;
                }

                averageActiveSegmentResult.Text = AverageActiveMinutes.ToString( "D2" ) + ":" + AverageActiveSeconds.ToString( "D2" );
            }
            else
            {
                averageActiveSegmentResult.Text = "00:00";
            }

            int CountSecondsStopped = totalSegments.Where( x => x.segmentType != Constants.segmentTypeActive ).Count();
            if ( CountSecondsStopped > 0 )
            {
                int TotalSecondsStopped = totalSegments.Where( x => x.segmentType != Constants.segmentTypeActive ).Sum( x => x.elapsedSeconds );
                int AverageStoppedSeconds = TotalSecondsStopped / CountSecondsStopped;
                int AverageStoppedMinutes = 0;
                while ( AverageStoppedSeconds >= 60 )
                {
                    AverageStoppedSeconds -= 60;
                    AverageStoppedMinutes++;
                }

                averageStoppedSegmentResult.Text = AverageStoppedMinutes.ToString( "D2" ) + ":" + AverageStoppedSeconds.ToString( "D2" );
            }
            else
            {
                averageStoppedSegmentResult.Text = "00:00";
            }

            int CountSecondsGoal = totalSegments.Where( x => x.segmentType == Constants.segmentTypeGoal ).Count();
            if ( CountSecondsGoal > 0 )
            {
                int TotalSecondsGoal = totalSegments.Where( x => x.segmentType == Constants.segmentTypeGoal ).Sum( x => x.elapsedSeconds );
                int AverageGoalSeconds = TotalSecondsGoal / CountSecondsGoal;
                int AverageGoalMinutes = 0;
                while ( AverageGoalSeconds >= 60 )
                {
                    AverageGoalSeconds -= 60;
                    AverageGoalMinutes++;
                }

                averageGoalSegmentResult.Text = AverageGoalMinutes.ToString( "D2" ) + ":" + AverageGoalSeconds.ToString( "D2" );
            }
            else
            {
                averageGoalSegmentResult.Text = "00:00";
            }
            #endregion
        }

        private void addGameFilter2_Click( object sender, EventArgs e )
        {
            removeGameFilter1.Visible = false;
            addGameFilter2.Visible = false;
            nameFilter2.Text = string.Empty;
            nameFilter2.Visible = true;
            removeGameFilter2.Visible = true;
            addGameFilter3.Visible = true;
            comboBoxNameFilter2.Visible = true;
            comboBoxNameFilter2.SelectedIndex = 1;
        }

        private void removeGameFilter2_Click( object sender, EventArgs e )
        {
            removeGameFilter1.Visible = true;
            addGameFilter2.Visible = true;
            nameFilter2.Text = string.Empty;
            nameFilter2.Visible = false;
            removeGameFilter2.Visible = false;
            addGameFilter3.Visible = false;
            comboBoxNameFilter2.Visible = false;
        }

        private void addGameFilter3_Click( object sender, EventArgs e )
        {
            addGameFilter3.Visible = false;
            nameFilter3.Text = string.Empty;
            nameFilter3.Visible = true;
            removeGameFilter2.Visible = false;
            removeGameFilter3.Visible = true;
            addGameFilter3.Visible = false;
            comboBoxNameFilter3.Visible = true;
            comboBoxNameFilter3.SelectedIndex = 1;
        }

        private void removeGameFilter3_Click( object sender, EventArgs e )
        {
            addGameFilter3.Visible = true;
            nameFilter3.Text = string.Empty;
            nameFilter2.Visible = true;
            nameFilter3.Visible = false;
            removeGameFilter2.Visible = true;
            removeGameFilter3.Visible = false;
            comboBoxNameFilter3.Visible = false;
        }

        private void nameFilter1_TextChanged( object sender, EventArgs e )
        {
            var regex = new Regex( @"[^a-zA-Z0-9\s]" );

            if ( !string.IsNullOrEmpty( nameFilter1.Text ) )
            {
                foreach ( char c in nameFilter1.Text )
                {
                    if ( regex.IsMatch( c.ToString() ) )
                    {
                        nameFilter1.Text = nameFilter1.Text.Replace( c.ToString(), string.Empty );
                        nameFilter1.SelectionStart = nameFilter1.Text.Length;
                    }
                }                
            }
        }

        private void nameFilter2_TextChanged( object sender, EventArgs e )
        {
            var regex = new Regex( @"[^a-zA-Z0-9\s]" );

            if ( !string.IsNullOrEmpty( nameFilter2.Text ) )
            {
                foreach ( char c in nameFilter2.Text )
                {
                    if ( regex.IsMatch( c.ToString() ) )
                    {
                        nameFilter2.Text = nameFilter2.Text.Replace( c.ToString(), string.Empty );
                        nameFilter2.SelectionStart = nameFilter2.Text.Length;
                    }
                }
            }
        }

        private void removeGameFilter1_Click( object sender, EventArgs e )
        {
            nameFilter1.Text = string.Empty;
        }

        private void nameFilter3_TextChanged( object sender, EventArgs e )
        {
            var regex = new Regex( @"[^a-zA-Z0-9\s]" );

            if ( !string.IsNullOrEmpty( nameFilter3.Text ) )
            {
                foreach ( char c in nameFilter3.Text )
                {
                    if ( regex.IsMatch( c.ToString() ) )
                    {
                        nameFilter3.Text = nameFilter3.Text.Replace( c.ToString(), string.Empty );
                        nameFilter3.SelectionStart = nameFilter3.Text.Length;
                    }
                }
            }
        }

        private void removeCompetitionFilter1_Click( object sender, EventArgs e )
        {
            competitionFilter1.Text = string.Empty;
        }

        private void competitionFilter1_TextChanged( object sender, EventArgs e )
        {
            var regex = new Regex( @"[^a-zA-Z0-9\s]" );

            if ( !string.IsNullOrEmpty( competitionFilter1.Text ) )
            {
                foreach ( char c in competitionFilter1.Text )
                {
                    if ( regex.IsMatch( c.ToString() ) )
                    {
                        competitionFilter1.Text = competitionFilter1.Text.Replace( c.ToString(), string.Empty );
                        competitionFilter1.SelectionStart = competitionFilter1.Text.Length;
                    }
                }
            }
        }

        private void competitionFilter2_TextChanged( object sender, EventArgs e )
        {
            var regex = new Regex( @"[^a-zA-Z0-9\s]" );

            if ( !string.IsNullOrEmpty( competitionFilter2.Text ) )
            {
                foreach ( char c in competitionFilter2.Text )
                {
                    if ( regex.IsMatch( c.ToString() ) )
                    {
                        competitionFilter2.Text = competitionFilter2.Text.Replace( c.ToString(), string.Empty );
                        competitionFilter2.SelectionStart = competitionFilter2.Text.Length;
                    }
                }
            }
        }

        private void competitionFilter3_TextChanged( object sender, EventArgs e )
        {
            var regex = new Regex( @"[^a-zA-Z0-9\s]" );

            if ( !string.IsNullOrEmpty( competitionFilter3.Text ) )
            {
                foreach ( char c in competitionFilter3.Text )
                {
                    if ( regex.IsMatch( c.ToString() ) )
                    {
                        competitionFilter3.Text = competitionFilter3.Text.Replace( c.ToString(), string.Empty );
                        competitionFilter3.SelectionStart = competitionFilter3.Text.Length;
                    }
                }
            }
        }

        private void addCompetitionFilter2_Click( object sender, EventArgs e )
        {
            removeCompetitionFilter1.Visible = false;
            addCompetitionFilter2.Visible = false;
            competitionFilter2.Text = string.Empty;
            competitionFilter2.Visible = true;
            removeCompetitionFilter2.Visible = true;
            addCompetitionFilter3.Visible = true;
            comboBoxCompetitionFilter2.Visible = true;
            comboBoxCompetitionFilter2.SelectedIndex = 0;
        }

        private void removeCompetitionFilter2_Click( object sender, EventArgs e )
        {
            removeCompetitionFilter1.Visible = true;
            addCompetitionFilter2.Visible = true;
            competitionFilter2.Text = string.Empty;
            competitionFilter2.Visible = false;
            removeCompetitionFilter2.Visible = false;
            addCompetitionFilter3.Visible = false;
            comboBoxCompetitionFilter2.Visible = false;
        }

        private void addCompetitionFilter3_Click( object sender, EventArgs e )
        {
            addCompetitionFilter3.Visible = false;
            competitionFilter3.Text = string.Empty;
            competitionFilter3.Visible = true;
            removeCompetitionFilter2.Visible = false;
            removeCompetitionFilter3.Visible = true;
            addCompetitionFilter3.Visible = false;
            comboBoxCompetitionFilter3.Visible = true;
            comboBoxCompetitionFilter3.SelectedIndex = 0;
        }

        private void removeCompetitionFilter3_Click( object sender, EventArgs e )
        {
            addCompetitionFilter3.Visible = true;
            competitionFilter3.Text = string.Empty;
            competitionFilter2.Visible = true;
            competitionFilter3.Visible = false;
            removeCompetitionFilter2.Visible = true;
            removeCompetitionFilter3.Visible = false;
            comboBoxCompetitionFilter3.Visible = false;
        }

        private void removeDateFilter1_Click( object sender, EventArgs e )
        {
            dateFilter1.Text = string.Empty;
        }

        private void addDateFilter2_Click( object sender, EventArgs e )
        {
            removeDateFilter1.Visible = false;
            addDateFilter2.Visible = false;
            dateFilter2.Text = string.Empty;
            dateFilter2.Visible = true;
            removeDateFilter2.Visible = true;
            comboBoxDateFilter2.Visible = true;
            comboBoxDateFilter2.SelectedIndex = 0;
        }

        private void removeDateFilter2_Click( object sender, EventArgs e )
        {
            removeDateFilter1.Visible = true;
            addDateFilter2.Visible = true;
            dateFilter2.Text = string.Empty;
            dateFilter2.Visible = false;
            removeDateFilter2.Visible = false;
            comboBoxDateFilter2.Visible = false;
        }

        private void dateFilter1_TextChanged( object sender, EventArgs e )
        {
            var regex = new Regex( @"[^0-9]" );

            if ( !string.IsNullOrEmpty( dateFilter1.Text ) )
            {
                foreach ( char c in dateFilter1.Text )
                {
                    if ( regex.IsMatch( c.ToString() ) )
                    {
                        dateFilter1.Text = dateFilter1.Text.Replace( c.ToString(), string.Empty );
                        dateFilter1.SelectionStart = dateFilter1.Text.Length;
                    }
                }
            }
        }

        private void dateFilter2_TextChanged( object sender, EventArgs e )
        {
            var regex = new Regex( @"[^0-9]" );

            if ( !string.IsNullOrEmpty( dateFilter2.Text ) )
            {
                foreach ( char c in dateFilter2.Text )
                {
                    if ( regex.IsMatch( c.ToString() ) )
                    {
                        dateFilter2.Text = dateFilter2.Text.Replace( c.ToString(), string.Empty );
                        dateFilter2.SelectionStart = dateFilter2.Text.Length;
                    }
                }
            }
        }

        private void button1_Click( object sender, EventArgs e )
        {
            DialogResult diag = MessageBox.Show( "Sincronizar com GitHub? Atenção que existe um limite de acessos e esta funcionalidade pode não funcionar. \nAo confirmar vai buscar os jogos existentes no GitHub e criar os ficheiros localmente. Isto deve ser feito de forma manual sempre que possivel.", "Confirmar", MessageBoxButtons.OKCancel );
            if (diag == DialogResult.OK)
            {
                github = new GitHubClient( new ProductHeaderValue( Constants.ProjectName ) );
                try
                {
                    var result = github.Repository.Content.GetAllContents( Constants.GitHubUserName, Constants.ProjectName, Constants.SavesDir ).Result;
                    foreach (var item in result)
                    {
                        string[] itemInfo;
                        itemInfo = item.Name.Split( '.' );
                        itemInfo = itemInfo[ 0 ].Split( '_' );

                        if (itemInfo.Length != 3)
                            continue;

                        if (loadedGames.Any( x => x.Name == itemInfo[ 0 ] && x.Date == itemInfo[ 2 ] ))
                            continue;

                        Game loadingGame = new Game() { filePath = item.Path, Name = itemInfo[ 0 ], Competition = itemInfo[ 1 ], Date = itemInfo[ 2 ] };


                        var result1 = github.Repository.Content.GetAllContents( Constants.GitHubUserName, Constants.ProjectName, item.Path ).Result;
                        IEnumerable<Segment> deserialized = JsonConvert.DeserializeObject<IEnumerable<Segment>>( result1.SingleOrDefault().Content );

                        tempSegments = deserialized.ToList();

                        var path = Directory.CreateDirectory( "saved_games" );

                        string res = itemInfo[ 0 ] + "_" + itemInfo[ 1 ] + "_" + itemInfo[ 2 ];
                        string fullpath = path.Name + "\\" + res + ".txt";

                        JsonSerialization.WriteToJsonFile( fullpath, tempSegments );

                        loadedGames.Add( loadingGame );

                        dataGridView1.Rows.Add( loadingGame.filePath, false, loadingGame.Name, loadingGame.Competition, loadingGame.Date, null );
                    }
                    dataGridView1.Sort( GameDate, ListSortDirection.Descending );
                }
                catch
                {
                    string message = "Sem ligação à internet, ou ultrapassado o limite máximo de acesso ao GitHub.";
                    string title = "Erro";
                    MessageBox.Show( message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning );
                }
            }
        }

        public void filterTableButton_Click( object sender, EventArgs e )
        {
            tempGames = new List<Game>();
            nameGames = new List<Game>();
            competitionGames = new List<Game>();
            dateGames = new List<Game>();
            dataGridView1.Rows.Clear();
            totalSegments.Clear();

            foreach ( Game game in loadedGames )
            {
                tempGames.Add( game );
            }

            ApplyNameFilters();
            ApplyCompetitionFilters();
            ApplyDateFilters();

            foreach ( Game eachgame in tempGames )
            {
                if ( nameGames.Contains(eachgame) && competitionGames.Contains( eachgame ) && dateGames.Contains( eachgame ))
                    dataGridView1.Rows.Add( eachgame.filePath, false, eachgame.Name, eachgame.Competition, eachgame.Date, null );
            }

            dataGridView1.Sort( GameDate, ListSortDirection.Descending );

            UpdateTotals();
        }

        private void ApplyNameFilters()
        {
            nameGames.Clear();
            foreach (Game game in tempGames)
            {
                //third name filter
                if ( string.IsNullOrEmpty( nameFilter3.Text ) )
                {
                    //second name filter
                    if ( !string.IsNullOrEmpty( nameFilter2.Text ) )
                    {
                        if(comboBoxNameFilter2.SelectedIndex == 1)
                        {
                            if ( game.Name.IndexOf( nameFilter1.Text, StringComparison.OrdinalIgnoreCase ) >= 0 || game.Name.IndexOf( nameFilter2.Text, StringComparison.OrdinalIgnoreCase ) >= 0 )
                            {
                                nameGames.Add( game );
                                continue;
                            }
                        }
                        else
                        {
                            if ( game.Name.IndexOf( nameFilter1.Text, StringComparison.OrdinalIgnoreCase ) >= 0 && game.Name.IndexOf( nameFilter2.Text, StringComparison.OrdinalIgnoreCase ) >= 0 )
                            {
                                nameGames.Add( game );
                                continue;
                            }
                        }
                        //first name filter
                        if ( string.IsNullOrEmpty( nameFilter1.Text ) )
                        {
                            if ( game.Name.IndexOf( nameFilter1.Text, StringComparison.OrdinalIgnoreCase ) >= 0 )
                            {
                                nameGames.Add( game );
                                continue;
                            }
                        }
                    }
                    else
                    {
                        if ( game.Name.IndexOf( nameFilter3.Text, StringComparison.OrdinalIgnoreCase ) >= 0 )
                        {
                            if ( !string.IsNullOrEmpty( nameFilter1.Text ) )
                            {
                                if ( game.Name.IndexOf( nameFilter1.Text, StringComparison.OrdinalIgnoreCase ) >= 0 )
                                {
                                    nameGames.Add( game );
                                    continue;
                                }
                            }
                            else
                            {
                                nameGames.Add( game );
                                continue;
                            }
                        }
                    }
                }
                else
                {
                    if ( comboBoxNameFilter3.SelectedIndex == 1 )
                    {
                        if ( comboBoxNameFilter2.SelectedIndex == 1 )
                        {
                            if ( game.Name.IndexOf( nameFilter1.Text, StringComparison.OrdinalIgnoreCase ) >= 0 || game.Name.IndexOf( nameFilter2.Text, StringComparison.OrdinalIgnoreCase ) >= 0 || game.Name.IndexOf( nameFilter3.Text, StringComparison.OrdinalIgnoreCase ) >= 0 )
                            {
                                nameGames.Add( game );
                                continue;
                            }
                        }
                        else
                        {
                            if ( game.Name.IndexOf( nameFilter1.Text, StringComparison.OrdinalIgnoreCase ) >= 0 && game.Name.IndexOf( nameFilter2.Text, StringComparison.OrdinalIgnoreCase ) >= 0 || game.Name.IndexOf( nameFilter3.Text, StringComparison.OrdinalIgnoreCase ) >= 0 )
                            {
                                nameGames.Add( game );
                                continue;
                            }
                        }
                    }
                    else
                    {
                        if ( comboBoxNameFilter2.SelectedIndex == 1 )
                        {
                            if ( game.Name.IndexOf( nameFilter1.Text, StringComparison.OrdinalIgnoreCase ) >= 0 || game.Name.IndexOf( nameFilter2.Text, StringComparison.OrdinalIgnoreCase ) >= 0 && game.Name.IndexOf( nameFilter3.Text, StringComparison.OrdinalIgnoreCase ) >= 0 )
                            {
                                nameGames.Add( game );
                                continue;
                            }
                        }
                        else
                        {
                            if ( game.Name.IndexOf( nameFilter1.Text, StringComparison.OrdinalIgnoreCase ) >= 0 && game.Name.IndexOf( nameFilter2.Text, StringComparison.OrdinalIgnoreCase ) >= 0 && game.Name.IndexOf( nameFilter3.Text, StringComparison.OrdinalIgnoreCase ) >= 0 )
                            {
                                nameGames.Add( game );
                                continue;
                            }
                        }
                    }
                }
            }
        }

        private void ApplyCompetitionFilters()
        {
            competitionGames.Clear();
            foreach ( Game game in tempGames )
            {
                //third competition filter
                if ( string.IsNullOrEmpty( competitionFilter3.Text ) )
                {
                    //second competition filter
                    if ( !string.IsNullOrEmpty( competitionFilter2.Text ) )
                    {
                        if ( game.Competition.IndexOf( competitionFilter1.Text, StringComparison.OrdinalIgnoreCase ) >= 0 || game.Competition.IndexOf( competitionFilter2.Text, StringComparison.OrdinalIgnoreCase ) >= 0 )
                        {
                            competitionGames.Add( game );
                            continue;
                        }
                        //first name filter
                        if ( string.IsNullOrEmpty( competitionFilter1.Text ) )
                        {
                            if ( game.Competition.IndexOf( competitionFilter1.Text, StringComparison.OrdinalIgnoreCase ) >= 0 )
                            {
                                competitionGames.Add( game );
                                continue;
                            }
                        }
                    }
                    else
                    {
                        if ( game.Competition.IndexOf( competitionFilter3.Text, StringComparison.OrdinalIgnoreCase ) >= 0 )
                        {
                            if ( !string.IsNullOrEmpty( competitionFilter1.Text ) )
                            {
                                if ( game.Competition.IndexOf( competitionFilter1.Text, StringComparison.OrdinalIgnoreCase ) >= 0 )
                                {
                                    competitionGames.Add( game );
                                    continue;
                                }
                            }
                            else
                            {
                                competitionGames.Add( game );
                                continue;
                            }
                        }
                    }
                }
                else
                {
                    if ( game.Competition.IndexOf( competitionFilter1.Text, StringComparison.OrdinalIgnoreCase ) >= 0 || game.Competition.IndexOf( competitionFilter2.Text, StringComparison.OrdinalIgnoreCase ) >= 0 || game.Competition.IndexOf( competitionFilter3.Text, StringComparison.OrdinalIgnoreCase ) >= 0 )
                    {
                        competitionGames.Add( game );
                        continue;
                    }
                }
            }
        }

        private void ApplyDateFilters()
        {
            dateGames.Clear();
            foreach ( Game game in tempGames )
            {
                //second date filter
                if ( !string.IsNullOrEmpty( dateFilter2.Text ) )
                {
                    if ( game.Date.IndexOf( dateFilter1.Text, StringComparison.OrdinalIgnoreCase ) >= 0 || game.Date.IndexOf( dateFilter2.Text, StringComparison.OrdinalIgnoreCase ) >= 0 )
                    {
                        dateGames.Add( game );
                        continue;
                    }
                    //first name filter
                    if ( string.IsNullOrEmpty( dateFilter1.Text ) )
                    {
                        if ( game.Date.IndexOf( dateFilter1.Text, StringComparison.OrdinalIgnoreCase ) >= 0 )
                        {
                            dateGames.Add( game );
                            continue;
                        }
                    }
                }
                else
                {
                    if ( game.Date.IndexOf( dateFilter1.Text, StringComparison.OrdinalIgnoreCase ) >= 0 )
                    {
                        if ( !string.IsNullOrEmpty( dateFilter1.Text ) )
                        {
                            if ( game.Date.IndexOf( dateFilter1.Text, StringComparison.OrdinalIgnoreCase ) >= 0 )
                            {
                                dateGames.Add( game );
                                continue;
                            }
                        }
                        else
                        {
                            dateGames.Add( game );
                            continue;
                        }
                    }
                }
            }
        }
    }

    public class Game
    {
        public string filePath;
        public string Name;
        public string Competition;
        public string Date;

        public Game()
        {
        }
    }
}
