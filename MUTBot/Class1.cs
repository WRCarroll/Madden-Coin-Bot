using PS4MacroAPI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace MUTBot2
{
    public class Script : ScriptBase
    {
        /*Contructor */
        public Script()
        {
            Config.Name = "MUTBot Script";
        }

        public override void Start()
        {
            base.Start();

        }

        public override void Update()
        {
            Press(new DualShockState() { DPad_Right = true });
            Sleep(100);
            Press(new DualShockState() { DPad_Right = true });
            Sleep(100);
            Press(new DualShockState() { DPad_Right = true });
            Sleep(100);
            Press(new DualShockState() { DPad_Right = true });
            Sleep(100);
            Press(new DualShockState() { DPad_Right = true });
            Sleep(100);
            Press(new DualShockState() { DPad_Right = true });
            Sleep(100);
            Press(new DualShockState() { DPad_Right = true });
            Sleep(100);
            Press(new DualShockState() { DPad_Right = true });
            Sleep(100);
            Press(new DualShockState() { DPad_Right = true });
            Sleep(100);
            Press(new DualShockState() { DPad_Right = true });
            Sleep(500);
            Press(new DualShockState() { Cross = true });
            Sleep(500);
            Press(new DualShockState() { Cross = true });
            Sleep(200);
            Press(new DualShockState() { DPad_Up = true });
            Sleep(5);
            Press(new DualShockState() { Cross = true });
            Sleep(3500);
            Press(new DualShockState() { Cross = true });
            Sleep(1500);
            Press(new DualShockState() { Cross = true });
            Sleep(2000);
            Press(new DualShockState() { Cross = true });
            Sleep(4000);
            Press(new DualShockState() { Cross = true });
            Sleep(500);
            Press(new DualShockState() { DPad_Up = true });
            Sleep(5);
            Press(new DualShockState() { Cross = true });
            Sleep(7000);
            Press(new DualShockState() { Circle = true });
            Sleep(5500);
        }
    }
}
