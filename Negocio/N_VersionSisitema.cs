using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio
{
    public class N_VersionSisitema
    {
        private static string SisVersion = "Pintureria V 2.0";

        public static string GETVERSION()
        {
            return SisVersion;
        }
    }
}
