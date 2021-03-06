﻿using Intralism_Mapping_Assistant.Util;
using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;

namespace Intralism_Mapping_Assistant
{
    public partial class MainForm : Form
    {
        private string FullVersion => Assembly.GetEntryAssembly().GetName().Version.ToString();
        private string Version => FullVersion.Substring(0, FullVersion.LastIndexOf('.'));

        private string LoadedMapFolderLocation;

        // TODO: Make a "LoadedMap" for loading from config and a "CurrentMap" for whatever is
        // in the currently active TextBox
        private Map CurrentMap => MakeMapFromPath(LoadedMapFolderLocation + @"\config.txt");

        private bool Config3 = false;

        private bool DeleteZoomsButtonActivated = false;
        private bool DeleteNonZoomsButtonActivated = false;

        public MainForm()
        {
            InitializeComponent();
            label7.Text += Version;
        }

        private void CalcFED_CheckedChanged(object sender, EventArgs e)
        {
            ChangeZoomStopOutputLabel("First Event Distance");
            ReactivateAllZoomStopBoxes();
            FirstEventDistanceBox.Enabled = false;
            ZoomStopCalculate.Enabled = true;
        }

        private void CalcSET_CheckedChanged(object sender, EventArgs e)
        {
            ChangeZoomStopOutputLabel("Second Event Time");
            ReactivateAllZoomStopBoxes();
            SecondEventTimeBox.Enabled = false;
            ZoomStopCalculate.Enabled = true;
        }

        private void CalcSED_CheckedChanged(object sender, EventArgs e)
        {
            ChangeZoomStopOutputLabel("Second Event Distance");
            ReactivateAllZoomStopBoxes();
            SecondEventDistanceBox.Enabled = false;
            ZoomStopCalculate.Enabled = true;
        }

        private void ZoomStopCalculate_Click(object sender, EventArgs e)
        {
            if (!StartingDistanceBox.Enabled)
                return;

            if (!FirstEventDistanceBox.Enabled)
                FindFED();

            if (!FirstEventTimeBox.Enabled)
                FindFET();

            if (!SecondEventDistanceBox.Enabled)
                FindSED();

            if (!SecondEventTimeBox.Enabled)
                FindSET();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            => Process.Start("https://github.com/FlyingRabidUnicornPig/Intralism-Mapping-Assistant");

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            => Process.Start("https://ko-fi.com/flyingrabidunicornpig");

        private void label43_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            => Process.Start("http://steamcommunity.com/profiles/76561198112790598");

        private void label44_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            => Process.Start("https://steamcommunity.com/profiles/76561198403090794");

        private void label45_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            => Process.Start("http://steamcommunity.com/profiles/76561198815634731");

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            => Process.Start("https://steamcommunity.com/profiles/76561198113890125");

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            => Process.Start("https://steamcommunity.com/profiles/76561198173832361");

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            => Process.Start("http://steamcommunity.com/profiles/76561198350337391");

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            => Process.Start("https://steamcommunity.com/profiles/76561198865036761");

        private void AdvancedFrameRateCalc_CheckedChanged(object sender, EventArgs e)
            => CustomFrameRate.Enabled = AdvancedFrameRateCalc.Checked;

        private void AdvancedCustomRangeCalc_CheckedChanged(object sender, EventArgs e)
            => CustomRangeZSCalc.Enabled = AdvancedCustomRangeCalc.Checked;

        private void ModifyConfigPreviewZEM_CheckedChanged(object sender, EventArgs e)
            => ChangeReadOnly(ModifyConfigPreviewZEM, ConfigPreviewRTBZEM);

        private void ModifyConfigPreviewZSC_CheckedChanged(object sender, EventArgs e)
            => ChangeReadOnly(ModifyConfigPreviewZSC, ConfigPreviewRTBZSC);

        private void ModifyConfigPreviewSCP1_CheckedChanged(object sender, EventArgs e)
            => ChangeReadOnly(ModifyConfigPreviewSCP1, SplitConfigPart1);

        private void ModifyConfigPreviewSCP2_CheckedChanged(object sender, EventArgs e)
            => ChangeReadOnly(ModifyConfigPreviewSCP2, SplitConfigPart2);

        private void DestructiveCheckZEM_CheckedChanged(object sender, EventArgs e)
        {
            DeleteAllZoomsButton.Enabled = DestructiveCheckZEM.Checked && DeleteZoomsButtonActivated;
            button1.Enabled = DestructiveCheckZEM.Checked && DeleteNonZoomsButtonActivated;
        }

        private void LoadMapButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = BrowseForMapFolder.ShowDialog();

            if (dialogResult == DialogResult.OK)
                AddressBox.Text = BrowseForMapFolder.SelectedPath;
            else if (dialogResult == DialogResult.Cancel)
                return;
        }

        private void DeleteAllZooms_Click(object sender, EventArgs e)
            => DeleteZooms();

        private void LoadButton_Click(object sender, EventArgs e)
        {
            if (!IsAddressBoxLegal())
            {
                ErrorMessage("Please provide a proper directory address!");
                return;
            }

            UpdateAllRTBs();
            UpdateModifiedTracker();
            ActivateEverythingElse();
        }

        private void CopyPreviewBox_Click(object sender, EventArgs e)
            => Copy(ConfigPreviewRTBZEM.Text);

        private void CopyPreviewBoxZSC_Click(object sender, EventArgs e)
            => Copy(ConfigPreviewRTBZSC.Text);

        private void CopySCP1_Click(object sender, EventArgs e)
            => Copy(SplitConfigPart1.Text);

        private void CopySCP2_Click(object sender, EventArgs e)
            => Copy(SplitConfigPart2.Text);

        private void CopyAudioOffsetSplit_Click(object sender, EventArgs e)
            => Copy(AudioOffsetSplitter.Text);

        private void CopyEOC_Click(object sender, EventArgs e)
            => Copy(ConfigPreviewEOC.Text);

        private void FindPrevZoomZSC_Click(object sender, EventArgs e)
            => SelectPrevZoomEvent(ConfigPreviewRTBZSC);

        private void FindNextZoomZSC_Click(object sender, EventArgs e)
            => SelectNextZoomEvent(ConfigPreviewRTBZSC);

        private void FindPrevZoomZEM_Click(object sender, EventArgs e)
            => SelectPrevZoomEvent(ConfigPreviewRTBZEM);

        private void FindNextZoomZEM_Click(object sender, EventArgs e)
            => SelectNextZoomEvent(ConfigPreviewRTBZEM);

        private void FindPrevEventSCP1_Click(object sender, EventArgs e)
            => SelectPrevEvent(SplitConfigPart1);

        private void FindNextEventSCP1_Click(object sender, EventArgs e)
            => SelectNextEvent(SplitConfigPart1);

        private void FindPrevEventSCP2_Click(object sender, EventArgs e)
            => SelectPrevEvent(SplitConfigPart2);

        private void FindNextEventSCP2_Click(object sender, EventArgs e)
            => SelectNextEvent(SplitConfigPart2);

        private void ModifySelectedZoomZSC_Click(object sender, EventArgs e)
            => ChangeSelectionZSC();

        private void ResetSelectedZoomZSC_Click(object sender, EventArgs e)
            => ResetSelectionZSC();

        private void SplitAfterEventButton_Click(object sender, EventArgs e)
            => SplitAfterSelectedEvent();

        private void SplitAtHalfButton_Click(object sender, EventArgs e)
            => SplitAtHalf();

        private void SplitAtTimeButton_Click(object sender, EventArgs e)
            => SplitAtTime((double)SplitTimeSelect.Value);

        private void ModifyConfigPreviewHS_CheckedChanged(object sender, EventArgs e)
            => ChangeReadOnly(ModifyConfigPreviewHS, ConfigPreviewRTBHS);

        private void CopyConfigPreviewHS_Click(object sender, EventArgs e)
            => Copy(ConfigPreviewRTBHS.Text);

        private void HandOneButton_Click(object sender, EventArgs e)
            => MakeAllEventsHand(1);

        private void HandTwoButton_Click(object sender, EventArgs e)
            => MakeAllEventsHand(2);

        private void HandZeroButton_Click(object sender, EventArgs e)
            => MakeAllEventsHand(0);

        private void CreateEventsESM_Click(object sender, EventArgs e)
            => CreateEnvSpriteMovementEvents();

        private void ModifyConfigPreviewESM_CheckedChanged(object sender, EventArgs e)
            => ChangeReadOnly(ModifyConfigPreviewESM, ConfigPreviewESMRTB);

        private void CopyConfigPreviewESM_Click(object sender, EventArgs e)
            => Copy(ConfigPreviewESMRTB.Text);

        private void InvertHandButton_Click(object sender, EventArgs e)
            => InvertHandOfAllEvents();

        private void ModifyEOC_CheckedChanged(object sender, EventArgs e)
            => ChangeReadOnly(ModifyEOC, ConfigPreviewEOC);

        private void SunRB_CheckedChanged(object sender, EventArgs e)
            => ReactivatePropertyBoxes(EnvironmentObjectType.Sun);

        private void SatelliteRB_CheckedChanged(object sender, EventArgs e)
            => ReactivatePropertyBoxes(EnvironmentObjectType.Satellite);

        private void ParticleEmitterRB_CheckedChanged(object sender, EventArgs e)
            => ReactivatePropertyBoxes(EnvironmentObjectType.ParticleEmitter);

        private void ColorPickSunMaxLives_Click(object sender, EventArgs e)
            => FillTextBoxWithSelectedColorCode(MaxLivesColorTB);

        private void ColorPickSunNoLives_Click(object sender, EventArgs e)
            => FillTextBoxWithSelectedColorCode(NoLivesColorTB);

        private void ColorPickSatellite_Click(object sender, EventArgs e)
            => FillTextBoxWithSelectedColorCode(SatelliteColorTB);

        private void ColorPickParticleEmitter_Click(object sender, EventArgs e)
            => FillTextBoxWithSelectedColorCode(ParticleEmitterColorTB);

        private void ParentIDCB_CheckedChanged(object sender, EventArgs e)
        {
            ParentIDTB.Enabled = ParentIDCB.Checked;
            MultipleParentsCB.Enabled = ParentIDCB.Checked && MakeMultipleCopiesCB.Checked;
        }

        private void RemoveTimeCB_CheckedChanged(object sender, EventArgs e)
            => RemoveTimeNUD.Enabled = RemoveTimeCB.Checked;

        private void PositionCB_CheckedChanged(object sender, EventArgs e)
            => ChangeEnabledStatus(new Control[] { PositionXNUD, PositionYNUD, PositionZNUD }, PositionCB.Checked);

        private void RotationCB_CheckedChanged(object sender, EventArgs e)
            => ChangeEnabledStatus(new Control[] { RotationXNUD, RotationYNUD, RotationZNUD }, RotationCB.Checked);

        private void ScaleCB_CheckedChanged(object sender, EventArgs e)
            => ChangeEnabledStatus(new Control[] { ScaleXNUD, ScaleYNUD, ScaleZNUD }, ScaleCB.Checked);

        private void ColorsCB_CheckedChanged(object sender, EventArgs e)
            => ChangeEnabledStatus(new Control[] { MaxLivesColorTB, ColorPickSunMaxLives, NoLivesColorTB, ColorPickSunNoLives }, ColorsCB.Checked);

        private void SunEmissionCB_CheckedChanged(object sender, EventArgs e)
            => SunEmissionNUD.Enabled = SunEmissionCB.Checked;

        private void SunInputCB_CheckedChanged(object sender, EventArgs e)
            => SunInputNUD.Enabled = SunInputCB.Checked;

        private void SunLerpSpeedCB_CheckedChanged(object sender, EventArgs e)
            => SunLerpNUD.Enabled = SunLerpSpeedCB.Checked;

        private void SunSensivityCB_CheckedChanged(object sender, EventArgs e)
            => SunSensitivityNUD.Enabled = SunSensivityCB.Checked;

        private void SunMinSizeCB_CheckedChanged(object sender, EventArgs e)
            => ChangeEnabledStatus( new Control[] { SunMinSizeXNUD, SunMinSizeYNUD, SunMinSizeZNUD },
                                    SunMinSizeCB.Checked);

        private void SunMaxSizeCB_CheckedChanged(object sender, EventArgs e)
            => ChangeEnabledStatus( new Control[] { SunMaxSizeXNUD, SunMaxSizeYNUD, SunMaxSizeZNUD },
                                    SunMaxSizeCB.Checked);

        private void SunDirectionVectorCB_CheckedChanged(object sender, EventArgs e)
            => ChangeEnabledStatus( new Control[] { DirectionVectorXNUD, DirectionVectorYNUD, DirectionVectorZNUD },
                                    SunDirectionVectorCB.Checked);

        private void SatelliteColorCB_CheckedChanged(object sender, EventArgs e)
            => ChangeEnabledStatus(new Control[] { SatelliteColorTB, ColorPickSatellite }, SatelliteColorCB.Checked);

        private void SatelliteEmissionCB_CheckedChanged(object sender, EventArgs e)
            => SatelliteEmissionNUD.Enabled = SatelliteEmissionCB.Checked;

        private void SatelliteTypeCB_CheckedChanged(object sender, EventArgs e)
            => SatelliteInputNUD.Enabled = SatelliteTypeCB.Checked;

        private void SatelliteLerpSpeedCB_CheckedChanged(object sender, EventArgs e)
            => SatelliteLerpSpeedNUD.Enabled = SatelliteLerpSpeedCB.Checked;

        private void SatelliteSensitivityCB_CheckedChanged(object sender, EventArgs e)
            => SatelliteSensitivityNUD.Enabled = SatelliteSensitivityCB.Checked;

        private void SatelliteRotationCB_CheckedChanged(object sender, EventArgs e)
            => SatelliteRotationSpeedNUD.Enabled = SatelliteRotationCB.Checked;

        private void SatelliteRadiusCB_CheckedChanged(object sender, EventArgs e)
            => SatelliteRadiusNUD.Enabled = SatelliteRadiusCB.Checked;

        private void SatelliteTrailFadeTimeCB_CheckedChanged(object sender, EventArgs e)
            => SatelliteTrailTimeNUD.Enabled = SatelliteTrailFadeTimeCB.Checked;

        private void SatellieTrailWidthCB_CheckedChanged(object sender, EventArgs e)
            => SatelliteTrailWidthNUD.Enabled = SatellieTrailWidthCB.Checked;

        private void SatelliteMinimumVertexCB_CheckedChanged(object sender, EventArgs e)
            => SatelliteMinimumVertexDistanceNUD.Enabled = SatelliteMinimumVertexCB.Checked;

        private void ParticleEmitterColorCB_CheckedChanged(object sender, EventArgs e)
            => ChangeEnabledStatus(new Control[] { ParticleEmitterColorTB, ColorPickParticleEmitter }, ParticleEmitterColorCB.Checked);

        private void ParticleEmitterEmissionCB_CheckedChanged(object sender, EventArgs e)
            => ParticleEmitterEmissionNUD.Enabled = ParticleEmitterEmissionCB.Checked;

        private void ParticleEmitterTypeCB_CheckedChanged(object sender, EventArgs e)
            => ParticleEmitterInputNUD.Enabled = ParticleEmitterTypeCB.Checked;

        private void ParticleEmitterGravityCB_CheckedChanged(object sender, EventArgs e)
            => ParticleEmitterGravityNUD.Enabled = ParticleEmitterGravityCB.Checked;

        private void ParticleEmitterSpeedCB_CheckedChanged(object sender, EventArgs e)
            => ParticleEmitterSpeedNUD.Enabled = ParticleEmitterSpeedCB.Checked;

        private void ParticleEmitterPPBCB_CheckedChanged(object sender, EventArgs e)
            => ParticleEmitterPPBNUD.Enabled = ParticleEmitterPPBCB.Checked;

        private void ParticleEmitterSizeCB_CheckedChanged(object sender, EventArgs e)
            => ParticleEmitterSizeNUD.Enabled = ParticleEmitterSizeCB.Checked;

        private void CreateEnvObjButton_Click(object sender, EventArgs e)
            => CreateEnvObjects();

        private void button1_Click(object sender, EventArgs e)
            => DeleteNonZooms();

        private void MakeMultipleCopiesCB_CheckedChanged(object sender, EventArgs e)
        {
            MultipleParentsCB.Enabled = MakeMultipleCopiesCB.Checked && ParentIDCB.Checked;
            MakeMultipleCopiesNUD.Enabled = MakeMultipleCopiesCB.Checked;

            if (!MakeMultipleCopiesCB.Checked)
            {
                MirrorXCB.Enabled = false;
                MirrorYCB.Enabled = false;
                MirrorZCB.Enabled = false;
            }
        }

        private void EndTimeCBESA_CheckedChanged(object sender, EventArgs e)
            => LoopAmountCBESA.Checked = !EndTimeCBESA.Checked;

        private void LoopAmountCBESA_CheckedChanged(object sender, EventArgs e)
            => EndTimeCBESA.Checked = !LoopAmountCBESA.Checked;

        private void FrameTimeCBESA_CheckedChanged(object sender, EventArgs e)
            => FramesPerSecondCBESA.Checked = !FrameTimeCBESA.Checked;

        private void FramesPerSecondCBESA_CheckedChanged(object sender, EventArgs e)
            => FrameTimeCBESA.Checked = !FramesPerSecondCBESA.Checked;

        private void CreateButtonESA_Click(object sender, EventArgs e)
            => CreateAnimationESA();

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
            => PreviewRTBESA.Enabled = checkBox1.Checked;

        private void button2_Click(object sender, EventArgs e)
            => Copy(PreviewRTBESA.Text);

        private void MakeMultipleCopiesNUD_ValueChanged(object sender, EventArgs e)
        {
            if (MakeMultipleCopiesNUD.Value != 0 && MakeMultipleCopiesNUD.Value % 2 == 0)
            {
                MirrorXCB.Enabled = true;
                MirrorYCB.Enabled = true;
                MirrorZCB.Enabled = true;
            }
            else
            {
                MirrorXCB.Enabled = false;
                MirrorYCB.Enabled = false;
                MirrorZCB.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
            => RefreshEnvSpriteTB();

        private void EnvSpriteRB_CheckedChanged(object sender, EventArgs e)
            => ReactivatePropertyBoxes(EnvironmentObjectType.EnvironmentSprite);

        private void button3_Click(object sender, EventArgs e)
        {
            ColorDialog.ShowDialog();
            RefreshEnvSpriteTB();
        }

        private void TrailZoomSpeedCB_CheckedChanged(object sender, EventArgs e)
            => TrailZoomSpeedNUD.Enabled = TrailZoomSpeedCB.Checked;

        private void ZEMAddLZToConfig_Click(object sender, EventArgs e)
            => AddLongZoomToConfig();
    }
}
