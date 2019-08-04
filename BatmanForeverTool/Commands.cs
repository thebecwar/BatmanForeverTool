using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizHawk.Client.EmuHawk
{
    public static class Commands
    {
        #region Grab Commands

        private static Command _grab;
        public static Command Grab {
            get
            {
                if (_grab == null)
                {
                    _grab = new Command("Grab", "Toward|None|Toward|Ax10");
                }
                return _grab;
            }
        }

        private static Command _neckBreaker;
        public static Command NeckBreaker
        {
            get
            {
                if (_neckBreaker == null)
                {
                    _neckBreaker = new Command("NeckBreaker", "Down,A|Nonex10");
                }
                return _neckBreaker;
            }
        }

        private static Command _headSmash;
        public static Command HeadSmash
        {
            get
            {
                if (_headSmash == null)
                {
                    _headSmash = new Command("HeadSmash", "Toward,A|Nonex14");
                }
                return _headSmash;
            }
        }

        private static Command _doubleHeadSmash;
        public static Command DoubleHeadSmash
        {
            get
            {
                if (_doubleHeadSmash == null)
                {
                    _doubleHeadSmash = new Command("DoubleHeadSmash", "Toward|None|Toward|B|Nonex48");
                }
                return _doubleHeadSmash;
            }

        }

        private static Command _knee;
        public static Command Knee
        {
            get
            {
                if (_knee == null)
                {
                    _knee = new Command("Knee", "Up,A|Nonex14");
                }
                return _knee;
            }

        }
        #endregion

        #region Movement

        private static Command _roll;
        public static Command Roll
        {
            get
            {
                if (_roll == null)
                {
                    _roll = new Command("Roll", "Toward|None|Toward|Y|Nonex28");
                }
                return _roll;
            }

        }


        #endregion

        #region Shared Gadgets

        private static Command _floorBreaker;
        public static Command FloorBreaker
        {
            get
            {
                if (_floorBreaker == null)
                {
                    _floorBreaker = new Command("FloorBreaker", "Down|Toward|B|Nonex64");
                }
                return _floorBreaker;
            }

        }

        private static Command _batarang;
        public static Command Batarang
        {
            get
            {
                if (_batarang == null)
                {
                    _batarang = new Command("Batarang", "Down|Down,Toward|Toward|Y|Nonex57");
                }
                return _batarang;
            }

        }

        private static Command _smokePellet;
        public static Command SmokePellet
        {
            get
            {
                if (_smokePellet == null)
                {
                    _smokePellet = new Command("SmokePellet", "Toward|Toward,Down|Down|None|A|Nonex64");
                }
                return _smokePellet;
            }

        }

        private static Command _slipperyGoo;
        public static Command SlipperyGoo
        {
            get
            {
                if (_slipperyGoo == null)
                {
                    _slipperyGoo = new Command("SlipperyGoo", "Toward|Down|None|B|Nonex27");
                }
                return _slipperyGoo;
            }

        }

        private static Command _batBola;
        public static Command BatBola
        {
            get
            {
                if (_batBola == null)
                {
                    _batBola = new Command("BatBola", "Down|None|Down|A|Nonex57");
                }
                return _batBola;
            }

        }

        #endregion


        #region Batman Gadgets

        private static Command _capeMorph;
        public static Command CapeMorph
        {
            get
            {
                if (_capeMorph == null)
                {
                    _capeMorph = new Command("CapeMorph", "L,Y|L|L,Y|L|L,Y|L|L+Y|L");
                }
                return _capeMorph;
            }
        }

        private static Command _flashPellet;
        public static Command FlashPellet
        {
            get
            {
                if (_flashPellet == null)
                {
                    _flashPellet = new Command("FlashPellet", "Toward|Toward,Down|Down|None|X|Nonex55");
                }
                return _flashPellet;
            }

        }

        private static Command _gas;
        public static Command Gas
        {
            get
            {
                if (_gas == null)
                {
                    _gas = new Command("Gas", "Down|Toward|A|Nonex60");
                }
                return _gas;
            }
        }

        private static Command _electricPellet;
        public static Command ElectricPellet
        {
            get
            {
                if (_electricPellet == null)
                {
                    _electricPellet = new Command("ElectricPellet", "Toward|Down|None|A|Nonex60");
                }
                return _electricPellet;
            }

        }

        private static Command _forceWall;
        public static Command ForceWall
        {
            get
            {
                if (_forceWall == null)
                {
                    _forceWall = new Command("ForceWall", "Down|None|Down|None|Down|B|Nonex17");
                }
                return _forceWall;
            }
        }

        private static Command _stickyGoo;
        public static Command StickyGoo
        {
            get
            {
                if (_stickyGoo == null)
                {
                    _stickyGoo = new Command("StickyGoo", "");
                }
                return _stickyGoo;
            }

        }


        #endregion

        #region Robin Gadgets

        private static Command _forceShield;
        public static Command ForceShield
        {
            get
            {
                if (_forceShield == null)
                {
                    _forceShield = new Command("ForceShield", "L,Y|L|L,Y|L|L,Y|L|L,Y|L");
                }
                return _forceShield;
            }
        }

        private static Command _tranqDarts;
        public static Command TranqDarts
        {
            get
            {
                if (_tranqDarts == null)
                {
                    _tranqDarts = new Command("TranqDarts", "Toward|Down|None|A|Nonex60");
                }
                return _tranqDarts;
            }
        }

        private static Command _flashlight;
        public static Command Flashlight
        {
            get
            {
                if (_flashlight == null)
                {
                    _flashlight = new Command("Flashlight", "Away|Toward|None|Toward|X|Nonex60");
                }
                return _flashlight;
            }
        }

        private static Command _electroStaffProd;
        public static Command ElectroStaffProd
        {
            get
            {
                if (_electroStaffProd == null)
                {
                    _electroStaffProd = new Command("ElectroStaffProd", "Down|Down|Toward|Y|Nonex39");
                }
                return _electroStaffProd;
            }
        }

        private static Command _wristRivets;
        public static Command WristRivets
        {
            get
            {
                if (_wristRivets == null)
                {
                    _wristRivets = new Command("WristRivets", "Away|Toward|Y|Nonex60");
                }
                return _wristRivets;
            }

        }

        private static Command _heatWeapon;
        public static Command HeatWeapon
        {
            get
            {
                if (_heatWeapon == null)
                {
                    _heatWeapon = new Command("HeatWeapon", "Toward|Away|Toward|Away|A|Nonex57");
                }
                return _heatWeapon;
            }

        }


        #endregion

        // Blueprint Garbage todo

    }

    public class Command
    {
        public Command(string name, string cmdText)
        {
            this.Name = name;

            List<ButtonPress> presses = new List<ButtonPress>();
            string[] parts = cmdText.Split('|');
            for (int i = 0; i < parts.Length; i++)
            {
                string[] current = parts[i].Split('x');
                int frames = 1;
                if (current.Length > 1)
                {
                    frames = int.Parse(current[1]);
                }
                SnesButtons buttons = (SnesButtons)Enum.Parse(typeof(SnesButtons), current[0]);
                presses.Add(new ButtonPress(frames, buttons));
            }
            this.ButtonPresses = presses.ToArray();
        }
        public string Name { get; set; }
        public ButtonPress[] ButtonPresses { get; set; }
    }

    public class ButtonPress
    {
        public ButtonPress(int frames, SnesButtons buttons)
        {
            this.Frames = frames;
            this.Buttons = buttons;
        }
        public int Frames { get; set; }
        public SnesButtons Buttons { get; set; }
    }


    [Flags]
    public enum SnesButtons
    {
        None = 0x00,
        Up = 0x01,
        Down = 0x02,
        Left = 0x04,
        Right = 0x08,
        Select = 0x10,
        Start = 0x20,
        A = 0x40,
        B = 0x80,
        X = 0x100,
        Y = 0x200,
        L = 0x400,
        R = 0x800,
        Toward = 0x1000,
        Away = 0x2000,
    }

}
