namespace BizHawk.Client.EmuHawk
{
    partial class CustomMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonRight = new System.Windows.Forms.RadioButton();
            this.radioButtonLeft = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxSaveState = new System.Windows.Forms.CheckBox();
            this.checkBoxStrafe = new System.Windows.Forms.CheckBox();
            this.tabControlPlayer = new System.Windows.Forms.TabControl();
            this.tabPageBatman = new System.Windows.Forms.TabPage();
            this.buttonForceWall = new System.Windows.Forms.Button();
            this.buttonCapeMorph = new System.Windows.Forms.Button();
            this.buttonStickyGoo = new System.Windows.Forms.Button();
            this.buttonElectricPellet = new System.Windows.Forms.Button();
            this.buttonFlashPellet = new System.Windows.Forms.Button();
            this.buttonGas = new System.Windows.Forms.Button();
            this.tabPageRobin = new System.Windows.Forms.TabPage();
            this.buttonFlashlight = new System.Windows.Forms.Button();
            this.buttonElectroStaff = new System.Windows.Forms.Button();
            this.buttonWristRivets = new System.Windows.Forms.Button();
            this.buttonForceShield = new System.Windows.Forms.Button();
            this.buttonHeatWeapon = new System.Windows.Forms.Button();
            this.buttonTranqDarts = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonFloorBreaker = new System.Windows.Forms.Button();
            this.buttonBatarang = new System.Windows.Forms.Button();
            this.buttonSmokePellet = new System.Windows.Forms.Button();
            this.buttonRoll = new System.Windows.Forms.Button();
            this.buttonBatBola = new System.Windows.Forms.Button();
            this.buttonSlipperyGoo = new System.Windows.Forms.Button();
            this.buttonLoadState = new System.Windows.Forms.Button();
            this.buttonNeckBreaker = new System.Windows.Forms.Button();
            this.buttonHeadSmash = new System.Windows.Forms.Button();
            this.buttonTwinHeadSmash = new System.Windows.Forms.Button();
            this.buttonGrab = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControlPlayer.SuspendLayout();
            this.tabPageBatman.SuspendLayout();
            this.tabPageRobin.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonRight);
            this.groupBox1.Controls.Add(this.radioButtonLeft);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(114, 45);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Facing Direction";
            // 
            // radioButtonRight
            // 
            this.radioButtonRight.AutoSize = true;
            this.radioButtonRight.Checked = true;
            this.radioButtonRight.Location = new System.Drawing.Point(55, 19);
            this.radioButtonRight.Name = "radioButtonRight";
            this.radioButtonRight.Size = new System.Drawing.Size(50, 17);
            this.radioButtonRight.TabIndex = 0;
            this.radioButtonRight.TabStop = true;
            this.radioButtonRight.Text = "Right";
            this.radioButtonRight.UseVisualStyleBackColor = true;
            // 
            // radioButtonLeft
            // 
            this.radioButtonLeft.AutoSize = true;
            this.radioButtonLeft.Location = new System.Drawing.Point(6, 19);
            this.radioButtonLeft.Name = "radioButtonLeft";
            this.radioButtonLeft.Size = new System.Drawing.Size(43, 17);
            this.radioButtonLeft.TabIndex = 0;
            this.radioButtonLeft.Text = "Left";
            this.radioButtonLeft.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxSaveState);
            this.groupBox2.Controls.Add(this.checkBoxStrafe);
            this.groupBox2.Location = new System.Drawing.Point(132, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(147, 45);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modifiers";
            // 
            // checkBoxSaveState
            // 
            this.checkBoxSaveState.AutoSize = true;
            this.checkBoxSaveState.Location = new System.Drawing.Point(66, 19);
            this.checkBoxSaveState.Name = "checkBoxSaveState";
            this.checkBoxSaveState.Size = new System.Drawing.Size(79, 17);
            this.checkBoxSaveState.TabIndex = 0;
            this.checkBoxSaveState.Text = "Save State";
            this.checkBoxSaveState.UseVisualStyleBackColor = true;
            // 
            // checkBoxStrafe
            // 
            this.checkBoxStrafe.AutoSize = true;
            this.checkBoxStrafe.Location = new System.Drawing.Point(6, 19);
            this.checkBoxStrafe.Name = "checkBoxStrafe";
            this.checkBoxStrafe.Size = new System.Drawing.Size(54, 17);
            this.checkBoxStrafe.TabIndex = 0;
            this.checkBoxStrafe.Text = "Strafe";
            this.checkBoxStrafe.UseVisualStyleBackColor = true;
            // 
            // tabControlPlayer
            // 
            this.tabControlPlayer.Controls.Add(this.tabPageBatman);
            this.tabControlPlayer.Controls.Add(this.tabPageRobin);
            this.tabControlPlayer.Location = new System.Drawing.Point(12, 218);
            this.tabControlPlayer.Name = "tabControlPlayer";
            this.tabControlPlayer.SelectedIndex = 0;
            this.tabControlPlayer.Size = new System.Drawing.Size(314, 213);
            this.tabControlPlayer.TabIndex = 2;
            // 
            // tabPageBatman
            // 
            this.tabPageBatman.Controls.Add(this.buttonForceWall);
            this.tabPageBatman.Controls.Add(this.buttonCapeMorph);
            this.tabPageBatman.Controls.Add(this.buttonStickyGoo);
            this.tabPageBatman.Controls.Add(this.buttonElectricPellet);
            this.tabPageBatman.Controls.Add(this.buttonFlashPellet);
            this.tabPageBatman.Controls.Add(this.buttonGas);
            this.tabPageBatman.Location = new System.Drawing.Point(4, 22);
            this.tabPageBatman.Name = "tabPageBatman";
            this.tabPageBatman.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBatman.Size = new System.Drawing.Size(306, 187);
            this.tabPageBatman.TabIndex = 0;
            this.tabPageBatman.Text = "Batman";
            this.tabPageBatman.UseVisualStyleBackColor = true;
            // 
            // buttonForceWall
            // 
            this.buttonForceWall.Location = new System.Drawing.Point(80, 48);
            this.buttonForceWall.Name = "buttonForceWall";
            this.buttonForceWall.Size = new System.Drawing.Size(68, 36);
            this.buttonForceWall.TabIndex = 5;
            this.buttonForceWall.Text = "Force Wall";
            this.buttonForceWall.UseVisualStyleBackColor = true;
            this.buttonForceWall.Click += new System.EventHandler(this.buttonForceWall_Click);
            // 
            // buttonCapeMorph
            // 
            this.buttonCapeMorph.Location = new System.Drawing.Point(6, 6);
            this.buttonCapeMorph.Name = "buttonCapeMorph";
            this.buttonCapeMorph.Size = new System.Drawing.Size(68, 36);
            this.buttonCapeMorph.TabIndex = 5;
            this.buttonCapeMorph.Text = "Cape Morph";
            this.buttonCapeMorph.UseVisualStyleBackColor = true;
            this.buttonCapeMorph.Click += new System.EventHandler(this.buttonCapeMorph_Click);
            // 
            // buttonStickyGoo
            // 
            this.buttonStickyGoo.Location = new System.Drawing.Point(154, 48);
            this.buttonStickyGoo.Name = "buttonStickyGoo";
            this.buttonStickyGoo.Size = new System.Drawing.Size(68, 36);
            this.buttonStickyGoo.TabIndex = 5;
            this.buttonStickyGoo.Text = "Sticky Goo";
            this.buttonStickyGoo.UseVisualStyleBackColor = true;
            this.buttonStickyGoo.Click += new System.EventHandler(this.buttonStickyGoo_Click);
            // 
            // buttonElectricPellet
            // 
            this.buttonElectricPellet.Location = new System.Drawing.Point(6, 48);
            this.buttonElectricPellet.Name = "buttonElectricPellet";
            this.buttonElectricPellet.Size = new System.Drawing.Size(68, 36);
            this.buttonElectricPellet.TabIndex = 5;
            this.buttonElectricPellet.Text = "Electric Pellet";
            this.buttonElectricPellet.UseVisualStyleBackColor = true;
            this.buttonElectricPellet.Click += new System.EventHandler(this.buttonElectricPellet_Click);
            // 
            // buttonFlashPellet
            // 
            this.buttonFlashPellet.Location = new System.Drawing.Point(80, 6);
            this.buttonFlashPellet.Name = "buttonFlashPellet";
            this.buttonFlashPellet.Size = new System.Drawing.Size(68, 36);
            this.buttonFlashPellet.TabIndex = 5;
            this.buttonFlashPellet.Text = "Flash Pellet";
            this.buttonFlashPellet.UseVisualStyleBackColor = true;
            this.buttonFlashPellet.Click += new System.EventHandler(this.buttonFlashPellet_Click);
            // 
            // buttonGas
            // 
            this.buttonGas.Location = new System.Drawing.Point(154, 6);
            this.buttonGas.Name = "buttonGas";
            this.buttonGas.Size = new System.Drawing.Size(68, 36);
            this.buttonGas.TabIndex = 5;
            this.buttonGas.Text = "Gas";
            this.buttonGas.UseVisualStyleBackColor = true;
            this.buttonGas.Click += new System.EventHandler(this.buttonGas_Click);
            // 
            // tabPageRobin
            // 
            this.tabPageRobin.Controls.Add(this.buttonFlashlight);
            this.tabPageRobin.Controls.Add(this.buttonElectroStaff);
            this.tabPageRobin.Controls.Add(this.buttonWristRivets);
            this.tabPageRobin.Controls.Add(this.buttonForceShield);
            this.tabPageRobin.Controls.Add(this.buttonHeatWeapon);
            this.tabPageRobin.Controls.Add(this.buttonTranqDarts);
            this.tabPageRobin.Location = new System.Drawing.Point(4, 22);
            this.tabPageRobin.Name = "tabPageRobin";
            this.tabPageRobin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRobin.Size = new System.Drawing.Size(306, 187);
            this.tabPageRobin.TabIndex = 1;
            this.tabPageRobin.Text = "Robin";
            this.tabPageRobin.UseVisualStyleBackColor = true;
            // 
            // buttonFlashlight
            // 
            this.buttonFlashlight.Location = new System.Drawing.Point(6, 6);
            this.buttonFlashlight.Name = "buttonFlashlight";
            this.buttonFlashlight.Size = new System.Drawing.Size(68, 36);
            this.buttonFlashlight.TabIndex = 5;
            this.buttonFlashlight.Text = "Flashlight";
            this.buttonFlashlight.UseVisualStyleBackColor = true;
            this.buttonFlashlight.Click += new System.EventHandler(this.buttonFlashlight_Click);
            // 
            // buttonElectroStaff
            // 
            this.buttonElectroStaff.Location = new System.Drawing.Point(6, 48);
            this.buttonElectroStaff.Name = "buttonElectroStaff";
            this.buttonElectroStaff.Size = new System.Drawing.Size(68, 36);
            this.buttonElectroStaff.TabIndex = 5;
            this.buttonElectroStaff.Text = "Electro Staff Prod";
            this.buttonElectroStaff.UseVisualStyleBackColor = true;
            this.buttonElectroStaff.Click += new System.EventHandler(this.buttonElectroStaff_Click);
            // 
            // buttonWristRivets
            // 
            this.buttonWristRivets.Location = new System.Drawing.Point(80, 48);
            this.buttonWristRivets.Name = "buttonWristRivets";
            this.buttonWristRivets.Size = new System.Drawing.Size(68, 36);
            this.buttonWristRivets.TabIndex = 5;
            this.buttonWristRivets.Text = "Wrist Rivets";
            this.buttonWristRivets.UseVisualStyleBackColor = true;
            this.buttonWristRivets.Click += new System.EventHandler(this.buttonWristRivets_Click);
            // 
            // buttonForceShield
            // 
            this.buttonForceShield.Location = new System.Drawing.Point(80, 6);
            this.buttonForceShield.Name = "buttonForceShield";
            this.buttonForceShield.Size = new System.Drawing.Size(68, 36);
            this.buttonForceShield.TabIndex = 5;
            this.buttonForceShield.Text = "Force Shield";
            this.buttonForceShield.UseVisualStyleBackColor = true;
            this.buttonForceShield.Click += new System.EventHandler(this.buttonForceShield_Click);
            // 
            // buttonHeatWeapon
            // 
            this.buttonHeatWeapon.Location = new System.Drawing.Point(154, 48);
            this.buttonHeatWeapon.Name = "buttonHeatWeapon";
            this.buttonHeatWeapon.Size = new System.Drawing.Size(68, 36);
            this.buttonHeatWeapon.TabIndex = 5;
            this.buttonHeatWeapon.Text = "Heat Weapon";
            this.buttonHeatWeapon.UseVisualStyleBackColor = true;
            this.buttonHeatWeapon.Click += new System.EventHandler(this.buttonHeatWeapon_Click);
            // 
            // buttonTranqDarts
            // 
            this.buttonTranqDarts.Location = new System.Drawing.Point(154, 6);
            this.buttonTranqDarts.Name = "buttonTranqDarts";
            this.buttonTranqDarts.Size = new System.Drawing.Size(68, 36);
            this.buttonTranqDarts.TabIndex = 5;
            this.buttonTranqDarts.Text = "Tranq. Darts";
            this.buttonTranqDarts.UseVisualStyleBackColor = true;
            this.buttonTranqDarts.Click += new System.EventHandler(this.buttonTranqDarts_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonFloorBreaker);
            this.groupBox3.Controls.Add(this.buttonBatarang);
            this.groupBox3.Controls.Add(this.buttonSmokePellet);
            this.groupBox3.Controls.Add(this.buttonRoll);
            this.groupBox3.Controls.Add(this.buttonBatBola);
            this.groupBox3.Controls.Add(this.buttonSlipperyGoo);
            this.groupBox3.Location = new System.Drawing.Point(12, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(152, 149);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Common Controls";
            // 
            // buttonFloorBreaker
            // 
            this.buttonFloorBreaker.Location = new System.Drawing.Point(6, 19);
            this.buttonFloorBreaker.Name = "buttonFloorBreaker";
            this.buttonFloorBreaker.Size = new System.Drawing.Size(68, 36);
            this.buttonFloorBreaker.TabIndex = 5;
            this.buttonFloorBreaker.Text = "Floor Breaker";
            this.buttonFloorBreaker.UseVisualStyleBackColor = true;
            this.buttonFloorBreaker.Click += new System.EventHandler(this.buttonFloorBreaker_Click);
            // 
            // buttonBatarang
            // 
            this.buttonBatarang.Location = new System.Drawing.Point(6, 61);
            this.buttonBatarang.Name = "buttonBatarang";
            this.buttonBatarang.Size = new System.Drawing.Size(68, 36);
            this.buttonBatarang.TabIndex = 5;
            this.buttonBatarang.Text = "Batarang";
            this.buttonBatarang.UseVisualStyleBackColor = true;
            this.buttonBatarang.Click += new System.EventHandler(this.buttonBatarang_Click);
            // 
            // buttonSmokePellet
            // 
            this.buttonSmokePellet.Location = new System.Drawing.Point(80, 19);
            this.buttonSmokePellet.Name = "buttonSmokePellet";
            this.buttonSmokePellet.Size = new System.Drawing.Size(68, 36);
            this.buttonSmokePellet.TabIndex = 5;
            this.buttonSmokePellet.Text = "Smoke Pellet";
            this.buttonSmokePellet.UseVisualStyleBackColor = true;
            this.buttonSmokePellet.Click += new System.EventHandler(this.buttonSmokePellet_Click);
            // 
            // buttonRoll
            // 
            this.buttonRoll.Location = new System.Drawing.Point(80, 103);
            this.buttonRoll.Name = "buttonRoll";
            this.buttonRoll.Size = new System.Drawing.Size(68, 36);
            this.buttonRoll.TabIndex = 5;
            this.buttonRoll.Text = "Roll";
            this.buttonRoll.UseVisualStyleBackColor = true;
            this.buttonRoll.Click += new System.EventHandler(this.buttonRoll_Click);
            // 
            // buttonBatBola
            // 
            this.buttonBatBola.Location = new System.Drawing.Point(6, 103);
            this.buttonBatBola.Name = "buttonBatBola";
            this.buttonBatBola.Size = new System.Drawing.Size(68, 36);
            this.buttonBatBola.TabIndex = 5;
            this.buttonBatBola.Text = "Bat Bola";
            this.buttonBatBola.UseVisualStyleBackColor = true;
            this.buttonBatBola.Click += new System.EventHandler(this.buttonBatBola_Click);
            // 
            // buttonSlipperyGoo
            // 
            this.buttonSlipperyGoo.Location = new System.Drawing.Point(80, 61);
            this.buttonSlipperyGoo.Name = "buttonSlipperyGoo";
            this.buttonSlipperyGoo.Size = new System.Drawing.Size(68, 36);
            this.buttonSlipperyGoo.TabIndex = 5;
            this.buttonSlipperyGoo.Text = "Slippery Goo";
            this.buttonSlipperyGoo.UseVisualStyleBackColor = true;
            this.buttonSlipperyGoo.Click += new System.EventHandler(this.buttonSlipperyGoo_Click);
            // 
            // buttonLoadState
            // 
            this.buttonLoadState.Location = new System.Drawing.Point(283, 12);
            this.buttonLoadState.Name = "buttonLoadState";
            this.buttonLoadState.Size = new System.Drawing.Size(43, 45);
            this.buttonLoadState.TabIndex = 4;
            this.buttonLoadState.Text = "Load State";
            this.buttonLoadState.UseVisualStyleBackColor = true;
            this.buttonLoadState.Click += new System.EventHandler(this.buttonLoadState_Click);
            // 
            // buttonNeckBreaker
            // 
            this.buttonNeckBreaker.Location = new System.Drawing.Point(6, 61);
            this.buttonNeckBreaker.Name = "buttonNeckBreaker";
            this.buttonNeckBreaker.Size = new System.Drawing.Size(68, 36);
            this.buttonNeckBreaker.TabIndex = 5;
            this.buttonNeckBreaker.Text = "Neck Breaker";
            this.buttonNeckBreaker.UseVisualStyleBackColor = true;
            this.buttonNeckBreaker.Click += new System.EventHandler(this.buttonNeckBreaker_Click);
            // 
            // buttonHeadSmash
            // 
            this.buttonHeadSmash.Location = new System.Drawing.Point(80, 61);
            this.buttonHeadSmash.Name = "buttonHeadSmash";
            this.buttonHeadSmash.Size = new System.Drawing.Size(68, 36);
            this.buttonHeadSmash.TabIndex = 5;
            this.buttonHeadSmash.Text = "Head Smash";
            this.buttonHeadSmash.UseVisualStyleBackColor = true;
            this.buttonHeadSmash.Click += new System.EventHandler(this.buttonHeadSmash_Click);
            // 
            // buttonTwinHeadSmash
            // 
            this.buttonTwinHeadSmash.Location = new System.Drawing.Point(80, 19);
            this.buttonTwinHeadSmash.Name = "buttonTwinHeadSmash";
            this.buttonTwinHeadSmash.Size = new System.Drawing.Size(68, 36);
            this.buttonTwinHeadSmash.TabIndex = 5;
            this.buttonTwinHeadSmash.Text = "Two Head Smash";
            this.buttonTwinHeadSmash.UseVisualStyleBackColor = true;
            this.buttonTwinHeadSmash.Click += new System.EventHandler(this.buttonTwinHeadSmash_Click);
            // 
            // buttonGrab
            // 
            this.buttonGrab.Location = new System.Drawing.Point(6, 19);
            this.buttonGrab.Name = "buttonGrab";
            this.buttonGrab.Size = new System.Drawing.Size(68, 36);
            this.buttonGrab.TabIndex = 5;
            this.buttonGrab.Text = "Grab";
            this.buttonGrab.UseVisualStyleBackColor = true;
            this.buttonGrab.Click += new System.EventHandler(this.buttonGrab_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonGrab);
            this.groupBox4.Controls.Add(this.buttonTwinHeadSmash);
            this.groupBox4.Controls.Add(this.buttonHeadSmash);
            this.groupBox4.Controls.Add(this.buttonNeckBreaker);
            this.groupBox4.Location = new System.Drawing.Point(170, 63);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(156, 149);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Grabs";
            // 
            // CustomMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 443);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.buttonLoadState);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tabControlPlayer);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CustomMainForm";
            this.Text = "Batman Forever";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControlPlayer.ResumeLayout(false);
            this.tabPageBatman.ResumeLayout(false);
            this.tabPageRobin.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonRight;
        private System.Windows.Forms.RadioButton radioButtonLeft;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxSaveState;
        private System.Windows.Forms.CheckBox checkBoxStrafe;
        private System.Windows.Forms.TabControl tabControlPlayer;
        private System.Windows.Forms.TabPage tabPageBatman;
        private System.Windows.Forms.Button buttonForceWall;
        private System.Windows.Forms.Button buttonCapeMorph;
        private System.Windows.Forms.Button buttonStickyGoo;
        private System.Windows.Forms.Button buttonElectricPellet;
        private System.Windows.Forms.Button buttonFlashPellet;
        private System.Windows.Forms.Button buttonGas;
        private System.Windows.Forms.TabPage tabPageRobin;
        private System.Windows.Forms.Button buttonFlashlight;
        private System.Windows.Forms.Button buttonElectroStaff;
        private System.Windows.Forms.Button buttonWristRivets;
        private System.Windows.Forms.Button buttonForceShield;
        private System.Windows.Forms.Button buttonHeatWeapon;
        private System.Windows.Forms.Button buttonTranqDarts;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonFloorBreaker;
        private System.Windows.Forms.Button buttonBatarang;
        private System.Windows.Forms.Button buttonSmokePellet;
        private System.Windows.Forms.Button buttonRoll;
        private System.Windows.Forms.Button buttonBatBola;
        private System.Windows.Forms.Button buttonSlipperyGoo;
        private System.Windows.Forms.Button buttonLoadState;
        private System.Windows.Forms.Button buttonNeckBreaker;
        private System.Windows.Forms.Button buttonHeadSmash;
        private System.Windows.Forms.Button buttonTwinHeadSmash;
        private System.Windows.Forms.Button buttonGrab;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

