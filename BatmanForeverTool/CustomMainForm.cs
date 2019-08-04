using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using BizHawk.Client.ApiHawk;
using BizHawk.Client.Common;
using BizHawk.Emulation.Common;
using BizHawk.Client.ApiHawk.Classes.Events;

namespace BizHawk.Client.EmuHawk
{

    public partial class CustomMainForm : Form, IExternalToolForm
    {

        private const string SaveStateName = "BmfToolState";

        #region Fields
        /*
        The following stuff will be automatically filled
        by BizHawk runtime
        */
        [RequiredService]
        internal IMemoryDomains _memoryDomains { get; set; }
        [RequiredService]
        private IEmulator _emu { get; set; }

        /*private members for our needed*/
        private WatchList _watches;

        #endregion

        public CustomMainForm()
        {
            InitializeComponent();
        }


        #region BizHawk Required methods

        /// <summary>
        /// Return true if you want the <see cref="UpdateValues"/> method
        /// to be called before rendering
        /// </summary>
        public bool UpdateBefore
        {
            get
            {
                return true;
            }
        }

        public bool AskSaveChanges()
        {
            return true;
        }

        /// <summary>
        /// This method is called instead of regular <see cref="UpdateValues"/>
        /// when emulator is runnig in turbo mode
        /// </summary>
        public void FastUpdate()
        { }

        /// <summary>
        /// Restart is called the first time you call the form
        /// but also when you start playing a movie
        /// </summary>
        public void Restart()
        {
            //set a client padding
            //ClientApi.SetExtraPadding(50, 50);

            if (Global.Game.Name != "Null")
            {
            }
            else
            {
            }
        }

        /// <summary>
        /// This method is called when a frame is rendered
        /// You can comapre it the lua equivalent emu.frameadvance()
        /// </summary>
        public void UpdateValues()
        {
            if (Global.Game.Name != "Null")
            {
            }
        }


        public void NewUpdate(ToolFormUpdateType updateType)
        {
        }



        #endregion


        void AddButtons(SnesButtons buttons)
        {
            Joypad controller = ClientApi.GetInput(1);
            controller.ClearInputs();
            ClientApi.SetInput(1, controller);

            // D Pad
            if (buttons.HasFlag(SnesButtons.Left)) controller.AddInput(JoypadButton.Left);
            if (buttons.HasFlag(SnesButtons.Right)) controller.AddInput(JoypadButton.Right);
            if (buttons.HasFlag(SnesButtons.Down)) controller.AddInput(JoypadButton.Down);
            if (buttons.HasFlag(SnesButtons.Up)) controller.AddInput(JoypadButton.Up);

            // Toward/Away
            if (buttons.HasFlag(SnesButtons.Toward)) controller.AddInput(this.radioButtonLeft.Checked ? JoypadButton.Left : JoypadButton.Right);
            if (buttons.HasFlag(SnesButtons.Away)) controller.AddInput(this.radioButtonLeft.Checked ? JoypadButton.Right : JoypadButton.Left);

            // Face Buttons
            if (buttons.HasFlag(SnesButtons.A)) controller.AddInput(JoypadButton.A);
            if (buttons.HasFlag(SnesButtons.B)) controller.AddInput(JoypadButton.B);
            if (buttons.HasFlag(SnesButtons.X)) controller.AddInput(JoypadButton.X);
            if (buttons.HasFlag(SnesButtons.Y)) controller.AddInput(JoypadButton.Y);

            // S/s
            if (buttons.HasFlag(SnesButtons.Select)) controller.AddInput(JoypadButton.Select);
            if (buttons.HasFlag(SnesButtons.Start)) controller.AddInput(JoypadButton.Start);

            // Shoulder buttons
            if (buttons.HasFlag(SnesButtons.L)) controller.AddInput(JoypadButton.L);
            if (buttons.HasFlag(SnesButtons.R)) controller.AddInput(JoypadButton.R);

            if (this.checkBoxStrafe.Checked)
            {
                controller.AddInput(JoypadButton.R);
            }

            ClientApi.SetInput(1, controller);
        }

        private void ExecCommand(Command cmd)
        {
            if (this.checkBoxSaveState.Checked)
            {
                ClientApi.SaveState(SaveStateName);
            }

            for (int i = 0; i < cmd.ButtonPresses.Length; i++)
            {
                for (int f = 0; f < cmd.ButtonPresses[i].Frames; f++)
                {
                    this.AddButtons(cmd.ButtonPresses[i].Buttons);
                    ClientApi.DoFrameAdvance();
                }
            }

            Joypad controller = ClientApi.GetInput(1);
            controller.ClearInputs();
            ClientApi.SetInput(1, controller);
        }


        private void buttonGrab_Click(object sender, EventArgs e)
        {
            this.ExecCommand(Commands.Grab);
        }

        private void buttonSmokePellet_Click(object sender, EventArgs e)
        {
            this.ExecCommand(Commands.SmokePellet);
        }

        private void buttonBatarang_Click(object sender, EventArgs e)
        {
            this.ExecCommand(Commands.Batarang);
        }

        private void buttonSlipperyGoo_Click(object sender, EventArgs e)
        {
            this.ExecCommand(Commands.SlipperyGoo);
        }

        private void buttonBatBola_Click(object sender, EventArgs e)
        {
            this.ExecCommand(Commands.BatBola);
        }

        private void buttonRoll_Click(object sender, EventArgs e)
        {
            this.ExecCommand(Commands.Roll);
        }

        private void buttonFloorBreaker_Click(object sender, EventArgs e)
        {
            this.ExecCommand(Commands.FloorBreaker);
        }

        private void buttonNeckBreaker_Click(object sender, EventArgs e)
        {
            this.ExecCommand(Commands.NeckBreaker);
        }

        private void buttonHeadSmash_Click(object sender, EventArgs e)
        {
            this.ExecCommand(Commands.HeadSmash);
        }

        private void buttonTwinHeadSmash_Click(object sender, EventArgs e)
        {
            this.ExecCommand(Commands.DoubleHeadSmash);
        }

        private void buttonCapeMorph_Click(object sender, EventArgs e)
        {
            this.ExecCommand(Commands.CapeMorph);
        }

        private void buttonFlashPellet_Click(object sender, EventArgs e)
        {
            this.ExecCommand(Commands.FlashPellet);
        }

        private void buttonGas_Click(object sender, EventArgs e)
        {
            this.ExecCommand(Commands.Gas);
        }

        private void buttonStickyGoo_Click(object sender, EventArgs e)
        {
            this.ExecCommand(Commands.StickyGoo);
        }

        private void buttonForceWall_Click(object sender, EventArgs e)
        {
            this.ExecCommand(Commands.ForceWall);
        }

        private void buttonElectricPellet_Click(object sender, EventArgs e)
        {
            this.ExecCommand(Commands.ElectricPellet);
        }

        private void buttonFlashlight_Click(object sender, EventArgs e)
        {
            this.ExecCommand(Commands.Flashlight);
        }

        private void buttonForceShield_Click(object sender, EventArgs e)
        {
            this.ExecCommand(Commands.ForceShield);
        }

        private void buttonTranqDarts_Click(object sender, EventArgs e)
        {
            this.ExecCommand(Commands.TranqDarts);
        }

        private void buttonHeatWeapon_Click(object sender, EventArgs e)
        {
            this.ExecCommand(Commands.HeatWeapon);
        }

        private void buttonWristRivets_Click(object sender, EventArgs e)
        {
            this.ExecCommand(Commands.WristRivets);
        }

        private void buttonElectroStaff_Click(object sender, EventArgs e)
        {
            this.ExecCommand(Commands.ElectroStaffProd);
        }

        private void buttonLoadState_Click(object sender, EventArgs e)
        {
            ClientApi.LoadState(SaveStateName);

        }
    }
}
