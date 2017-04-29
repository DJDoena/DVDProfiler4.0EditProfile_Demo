using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DoenaSoft.DVDProfiler.DVDProfilerXML.Version381;

namespace DVD_Profiler_4._0
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OnOpenCollectionxmlToolStripMenuItemClick(Object sender
            , EventArgs e)
        {
            String fileName;

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.FileName = "collection.xml";
                ofd.Filter = "collection.xml|*.xml";
                ofd.CheckFileExists = true;
                ofd.Multiselect = false;
                ofd.RestoreDirectory = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    fileName = ofd.FileName;
                }
                else
                {
                    return;
                }
            }

            Collection collection;
            try
            {
                collection = Collection.Deserialize(fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (collection.DVDList?.Length > 0)
            {
                ClearScreen();

                ImportProfile(collection.DVDList[0]);
            }
            else
            {
                MessageBox.Show("No DVD in collection!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
        }

        private void ImportProfile(DVD dvd)
        {
            ImportAudio(dvd);

            ImportSubtitles(dvd);

            ImportFeatures(dvd);

            MessageBox.Show("\"" + dvd.Title + "\" succesfully imported.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ImportFeatures(DVD dvd)
        {
            if (dvd.Features != null)
            {
                List<String> availableFeatures = new List<String>(AvailableFeaturesListBox.Items.Cast<String>());

                List<String> profileFeatures = new List<String>();

                if (dvd.Features.BDLive)
                {
                    String feature = "BD-Live";

                    profileFeatures.Add(feature);

                    availableFeatures.Remove(feature);
                }

                if (dvd.Features.BonusTrailers)
                {
                    String feature = "Bonus Trailers";

                    profileFeatures.Add(feature);

                    availableFeatures.Remove(feature);
                }

                if (dvd.Features.ClosedCaptioned)
                {
                    Int32 index = SubtitleGrid.Rows.Add();

                    DataGridViewRow row = SubtitleGrid.Rows[index];

                    row.Cells[0].Value = "Main Feature";
                    row.Cells[1].Value = "Close Captioned (CC)";
                }

                if (dvd.Features.Commentary)
                {
                    //
                }

                if (dvd.Features.DeletedScenes)
                {
                    String feature = "Deleted Scenes";

                    profileFeatures.Add(feature);

                    availableFeatures.Remove(feature);
                }

                if (dvd.Features.DigitalCopy)
                {
                    String feature = "Digital Copy";

                    profileFeatures.Add(feature);

                    availableFeatures.Remove(feature);
                }

                if (dvd.Features.DVDROMContent)
                {
                    String feature = "DVD-ROM Content";

                    profileFeatures.Add(feature);

                    availableFeatures.Remove(feature);
                }

                if (dvd.Features.Game)
                {
                    String feature = "Interactive Games";

                    profileFeatures.Add(feature);

                    availableFeatures.Remove(feature);
                }

                if (dvd.Features.Interviews)
                {
                    String feature = "Interviews";

                    profileFeatures.Add(feature);

                    availableFeatures.Remove(feature);
                }

                if (dvd.Features.MakingOf)
                {
                    String feature = "Featurettes";

                    profileFeatures.Add(feature);

                    availableFeatures.Remove(feature);
                }

                if (dvd.Features.MultiAngle)
                {
                    String feature = "Multi-Angle";

                    profileFeatures.Add(feature);

                    availableFeatures.Remove(feature);
                }

                if (dvd.Features.MusicVideos)
                {
                    String feature = "Music Videos";

                    profileFeatures.Add(feature);

                    availableFeatures.Remove(feature);
                }

                if (dvd.Features.Outtakes)
                {
                    String feature = "Outtakes/Bloopers";

                    profileFeatures.Add(feature);

                    availableFeatures.Remove(feature);
                }

                if (dvd.Features.PhotoGallery)
                {
                    String feature = "Gallery";

                    profileFeatures.Add(feature);

                    availableFeatures.Remove(feature);
                }

                if (dvd.Features.PIP)
                {
                    String feature = "Picture-in-Picture";

                    profileFeatures.Add(feature);

                    availableFeatures.Remove(feature);
                }

                if (dvd.Features.ProductionNotes)
                {
                    String feature = "Production Notes/Bios";

                    profileFeatures.Add(feature);

                    availableFeatures.Remove(feature);
                }

                if (dvd.Features.SceneAccess)
                {
                    String feature = "Scene Access";

                    profileFeatures.Add(feature);

                    availableFeatures.Remove(feature);
                }

                if (dvd.Features.StoryboardComparisons)
                {
                    String feature = "Storyboard Comparison";

                    profileFeatures.Add(feature);

                    availableFeatures.Remove(feature);
                }

                if (dvd.Features.THXCertified)
                {
                    String feature = "THX Certified";

                    profileFeatures.Add(feature);

                    availableFeatures.Remove(feature);
                }

                if (dvd.Features.Trailer)
                {
                    String feature = "Feature Trailers";

                    profileFeatures.Add(feature);

                    availableFeatures.Remove(feature);
                }

                availableFeatures.Sort();

                profileFeatures.Sort();

                AvailableFeaturesListBox.Items.Clear();
                AvailableFeaturesListBox.Items.AddRange(availableFeatures.ToArray());

                ProfileFeatureListBox.Items.AddRange(profileFeatures.ToArray());

                ImportOtherFeatures(dvd.Features.OtherFeatures);
            }
        }

        private void ImportOtherFeatures(String otherFeatures)
        {
            if (String.IsNullOrEmpty(otherFeatures) == false)
            {
                String[] split = otherFeatures.Replace(Environment.NewLine, ",").Split(',');

                foreach (String otherFeature in split)
                {
                    String temp = otherFeature.Trim();

                    if (String.IsNullOrEmpty(temp) == false)
                    {
                        ProfileOtherFeatureListBox.Items.Add(temp);
                    }
                }
            }
        }

        private void ImportSubtitles(DVD dvd)
        {
            if (dvd.SubtitleList?.Length > 0)
            {
                foreach (String subtitle in dvd.SubtitleList)
                {
                    Int32 index = SubtitleGrid.Rows.Add();

                    DataGridViewRow row = SubtitleGrid.Rows[index];

                    row.Cells[0].Value = "Main Feature";

                    switch (subtitle)
                    {
                        case ("Commentary"):
                            {
                                row.Cells[1].Value = subtitle;

                                break;
                            }
                        case ("Trivia"):
                            {
                                row.Cells[1].Value = subtitle;

                                break;
                            }
                        default:
                            {
                                row.Cells[2].Value = subtitle;

                                break;
                            }
                    }
                }
            }
        }

        private void ImportAudio(DVD dvd)
        {
            if (dvd.AudioList?.Length > 0)
            {
                foreach (AudioTrack track in dvd.AudioList)
                {
                    Int32 index = AudioGrid.Rows.Add();

                    DataGridViewRow row = AudioGrid.Rows[index];

                    row.Cells[0].Value = "Main Feature";

                    switch (track.Content)
                    {
                        case ("Audio Descriptive"):
                            {
                                row.Cells[1].Value = track.Content;

                                break;
                            }
                        case ("Commentary"):
                            {
                                row.Cells[1].Value = track.Content;

                                break;
                            }
                        case ("Special Effects"):
                            {
                                row.Cells[1].Value = track.Content;

                                break;
                            }
                        default:
                            {
                                row.Cells[4].Value = track.Content;

                                break;
                            }
                    }

                    row.Cells[2].Value = track.Format;
                    row.Cells[3].Value = track.Channels;
                }
            }
        }

        private void ClearScreen()
        {
            AudioGrid.Rows.Clear();

            SubtitleGrid.Rows.Clear();

            while (ProfileFeatureListBox.Items.Count > 0)
            {
                ProfileFeatureListBox.SelectedIndex = 0;

                OnRemoveFeatureButtonClick(this, EventArgs.Empty);
            }

            ProfileOtherFeatureListBox.Items.Clear();

            ProfileOtherFeatureTextBox.Text = String.Empty;
        }

        private void OnAvailableFeaturesListBoxSelectedIndexChanged(Object sender
            , EventArgs e)
        {
            AddFeatureButton.Enabled = (AvailableFeaturesListBox.SelectedIndex != -1);
        }

        private void OnProfileFeatureListBoxSelectedIndexChanged(Object sender
            , EventArgs e)
        {
            RemoveFeatureButton.Enabled = (ProfileFeatureListBox.SelectedIndex != -1);
        }

        private void OnOtherFeatureTextBoxTextChanged(Object sender
            , EventArgs e)
        {
            AddOtherFeatureButton.Enabled = (String.IsNullOrEmpty(ProfileOtherFeatureTextBox.Text) == false);
        }

        private void OnAddFeatureButtonClick(Object sender
            , EventArgs e)
        {
            Int32 selectedIndex = AvailableFeaturesListBox.SelectedIndex;

            String feature = AvailableFeaturesListBox.Items[selectedIndex].ToString();

            AddFeature(feature, ProfileFeatureListBox.Items);

            AvailableFeaturesListBox.Items.RemoveAt(selectedIndex);
        }

        private static void AddFeature(String feature
            , ListBox.ObjectCollection items)
        {
            List<String> features = new List<String>(items.Cast<String>());

            features.Add(feature);
            features.Sort();

            items.Clear();
            items.AddRange(features.ToArray());
        }

        private void OnRemoveFeatureButtonClick(Object sender
            , EventArgs e)
        {
            Int32 selectedIndex = ProfileFeatureListBox.SelectedIndex;

            String feature = ProfileFeatureListBox.Items[selectedIndex].ToString();

            AddFeature(feature, AvailableFeaturesListBox.Items);

            ProfileFeatureListBox.Items.RemoveAt(selectedIndex);
        }

        private void OnAddOtherFeatureButtonClick(Object sender
            , EventArgs e)
        {
            AddFeature(ProfileOtherFeatureTextBox.Text, ProfileOtherFeatureListBox.Items);

            ProfileOtherFeatureTextBox.Text = String.Empty;
        }

        private void OnRemoveOtherFeatureButtonClick(Object sender
            , EventArgs e)
        {
            Int32 selectedIndex = ProfileOtherFeatureListBox.SelectedIndex;

            String feature = ProfileOtherFeatureListBox.Items[selectedIndex].ToString();

            ProfileOtherFeatureListBox.Items.RemoveAt(selectedIndex);

            ProfileOtherFeatureTextBox.Text = feature;
        }

        private void OnProfileOtherFeatureListBoxSelectedIndexChanged(Object sender
            , EventArgs e)
        {
            RemoveOtherFeatureButton.Enabled = (ProfileOtherFeatureListBox.SelectedIndex != -1);
        }
    }
}