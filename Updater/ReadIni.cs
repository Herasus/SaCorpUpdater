using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Updater
{
    static class ReadIni
    {
        [DllImport("kernel32", EntryPoint = "GetPrivateProfileStringA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]

        #region "GetVar"
        private static extern int GetPrivateProfileString(string lpApplicationName, string lpKeyName, string lpDefault, System.Text.StringBuilder lpReturnedString, int nSize, string lpFileName);
        public static string GetVar(string fichier, string Entete, string Variable)
        {
            string defval = "";
            try
            {
                System.Text.StringBuilder StrBuild = new System.Text.StringBuilder(32768);
                int Ret = GetPrivateProfileString(Entete, Variable, defval, StrBuild, 32768, fichier);
                return StrBuild.ToString();
            }
            catch
            {
                return defval;
            }
        }
        [DllImport("kernel32", EntryPoint = "WritePrivateProfileStringA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        #endregion

        #region "PutVar"
        private static extern int WritePrivateProfileString(string lpApplicationName, string lpKeyName, string lpString, string lpFileName);
        public static void PutVar(string fichier, string entete, string variable, string valeur)
        {
            WritePrivateProfileString(entete, variable, valeur, fichier);
        }
        #endregion
    }
}