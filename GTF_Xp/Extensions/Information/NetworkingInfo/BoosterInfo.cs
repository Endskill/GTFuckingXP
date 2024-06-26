﻿using GTFuckingXP.Information.Level;
using GTFuckingXP.Managers;
using System.Collections.Generic;

namespace GTFuckingXP.Information.NetworkingInfo
{
    public struct BoosterInfo
    {
        public BoosterInfo(float[] boosterValues)
        {
            if (boosterValues.Length > 54)
            {
                LogManager.Error("There are more values in Boosters values, than supported.\n"
                    + "Please message \"Endskill\" about that issue!");
            }
            else if(boosterValues.Length < 54)
            {
                LogManager.Error("There are less than 47 Booster values!");
            }

            F1 = boosterValues[0];
            F2 = boosterValues[1];
            F3 = boosterValues[2];
            F4 = boosterValues[3];
            F5 = boosterValues[4];
            F6 = boosterValues[5];
            F7 = boosterValues[6];
            F8 = boosterValues[7];
            F9 = boosterValues[8];
            F10 = boosterValues[9];
            F11 = boosterValues[10];
            F12 = boosterValues[11];
            F13 = boosterValues[12];
            F14 = boosterValues[13];
            F15 = boosterValues[14];
            F16 = boosterValues[15];
            F17 = boosterValues[16];
            F18 = boosterValues[17];
            F19 = boosterValues[18];
            F20 = boosterValues[19];
            F21 = boosterValues[20];
            F22 = boosterValues[21];
            F23 = boosterValues[22];
            F24 = boosterValues[23];
            F25 = boosterValues[24];
            F26 = boosterValues[25];
            F27 = boosterValues[26];
            F28 = boosterValues[27];
            F29 = boosterValues[28];
            F30 = boosterValues[29];
            F31 = boosterValues[30];
            F32 = boosterValues[31];
            F33 = boosterValues[32];
            F34 = boosterValues[33];
            F35 = boosterValues[34];
            F36 = boosterValues[35];
            F37 = boosterValues[36];
            F38 = boosterValues[37];
            F39 = boosterValues[38];
            F40 = boosterValues[39];
            F41 = boosterValues[40];
            F42 = boosterValues[41];
            F43 = boosterValues[42];
            F44 = boosterValues[43];
            F45 = boosterValues[44];
            F46 = boosterValues[45];
            F47 = boosterValues[46];
            F48 = boosterValues[47];
            F49 = boosterValues[48];
            F50 = boosterValues[49];
            F51 = boosterValues[50];
            F52 = boosterValues[51];
            F53 = boosterValues[52];
            F54 = boosterValues[53];
        }

        public float F1;
        public float F2;
        public float F3;
        public float F4;
        public float F5;
        public float F6;
        public float F7;
        public float F8;
        public float F9;
        public float F10;
        public float F11;
        public float F12;
        public float F13;
        public float F14;
        public float F15;
        public float F16;
        public float F17;
        public float F18;
        public float F19;
        public float F20;
        public float F21;
        public float F22;
        public float F23;
        public float F24;
        public float F25;
        public float F26;
        public float F27;
        public float F28;
        public float F29;
        public float F30;
        public float F31;
        public float F32;
        public float F33;
        public float F34;
        public float F35;
        public float F36;
        public float F37;
        public float F38;
        public float F39;
        public float F40;
        public float F41;
        public float F42;
        public float F43;
        public float F44;
        public float F45;
        public float F46;
        public float F47;
        public float F48; 
        public float F49;
        public float F50;
        public float F51;
        public float F52;
        public float F53;
        public float F54;

        public float[] GetBoosterValues()
        {
            return new float[] { F1, F2, F3, F4, F5, F6, F7, F8, F9, F10, F11, F12, F13, F14, F15, F16, F17, F18, F19, F20, F21, F22, F23, F24, F25, F26, F27, F28, F29, F30, F31, F32, F33, F34, F35, F36, F37, F38, F39, F40, F41, F42, F43, F44, F45, F46, F47, F48, F49, F50, F51, F52, F53, F54 };

            //float[] boosterValues = new float[48];
            //boosterValues[0] = F1;
            //boosterValues[1] = F2;
            //boosterValues[2] = F3;
            //boosterValues[3] = F4;
            //boosterValues[4] = F5;
            //boosterValues[5] = F6;
            //boosterValues[6] = F7;
            //boosterValues[7] = F8;
            //boosterValues[8] = F9;
            //boosterValues[9] = F10;
            //boosterValues[10] = F11;
            //boosterValues[11] = F12;
            //boosterValues[12] = F13;
            //boosterValues[13] = F14;
            //boosterValues[14] = F15;
            //boosterValues[15] = F16;
            //boosterValues[16] = F17;
            //boosterValues[17] = F18;
            //boosterValues[18] = F19;
            //boosterValues[19] = F20;
            //boosterValues[20] = F21;
            //boosterValues[21] = F22;
            //boosterValues[22] = F23;
            //boosterValues[23] = F24;
            //boosterValues[24] = F25;
            //boosterValues[25] = F26;
            //boosterValues[26] = F27;
            //boosterValues[27] = F28;
            //boosterValues[28] = F29;
            //boosterValues[29] = F30;
            //boosterValues[30] = F31;
            //boosterValues[31] = F32;
            //boosterValues[32] = F33;
            //boosterValues[33] = F34;
            //boosterValues[34] = F35;
            //boosterValues[35] = F36;
            //boosterValues[36] = F37;
            //boosterValues[37] = F38;
            //boosterValues[38] = F39;
            //boosterValues[39] = F40;
            //boosterValues[40] = F41;
            //boosterValues[41] = F42;
            //boosterValues[42] = F43;
            //boosterValues[43] = F44;
            //boosterValues[44] = F45;
            //boosterValues[45] = F46;
            //boosterValues[46] = F47;
            //boosterValues[47] = F48;

            //return boosterValues;
        }

        public static implicit operator BoosterInfo(BoosterBuffs buff)
        {
            var agentModifiers = System.Enum.GetValues(typeof(AgentModifier));
            var boosterValues = new float[agentModifiers.Length];

            for (int index = 0; index < agentModifiers.Length; index++)
            {
                var modifier = (AgentModifier)agentModifiers.GetValue(index);
                if (buff != null && buff.ValueToBoosterEffects.TryGetValue(modifier, out var value))
                {
                    boosterValues[index] = value;
                }
                else
                {
                    boosterValues[index] = 0f;
                }
            }

            return new BoosterInfo(boosterValues);
        }
    }
}
