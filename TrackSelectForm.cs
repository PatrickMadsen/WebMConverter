﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WebMConverter
{
    public partial class TrackSelectForm : Form
    {
        public int SelectedTrack
        { get { return (int)comboBoxTracks.SelectedValue; } }

        public TrackSelectForm(string tracktype, IEnumerable<int> tracks)
        {
            InitializeComponent();

            labelSelect.Text = string.Format("{0} track:", tracktype);

            Dictionary<int, string> dropdownTracks = new Dictionary<int,string>();
            foreach (int Track in tracks)
            {
                dropdownTracks.Add(Track, string.Format("Track #{0}", Track));
            }
            comboBoxTracks.DataSource = new BindingSource(dropdownTracks, null);
            comboBoxTracks.ValueMember = "Key";
            comboBoxTracks.DisplayMember = "Value";
        }
    }
}
