﻿using Intralism_Mapping_Assistant.Util;
using System.Windows.Forms;

namespace Intralism_Mapping_Assistant
{
    partial class MainForm : Form
    {
        private void MakeAllEventsHand(int hand)
        {
            Map map = CurrentMap;

            for (int i = 0; i < CurrentMap.events.Length; i++)
                map.events[i] = MakeEventHand(map.events[i], hand);

            ConfigPreviewRTBHS.Text = MakeTextFromMap(map);
        }

        private Event MakeEventHand(Event evnt, int hand)
        {
            if (evnt.GetTypeString() != "SpawnObj")
                return evnt;

            evnt.data[1] = evnt.data[1].Replace(",", "").Replace("1", "").Replace("2", "");
                
            if (hand != 0)
                evnt.data[1] += "," + hand.ToString();

            return evnt;
        }
    }
}