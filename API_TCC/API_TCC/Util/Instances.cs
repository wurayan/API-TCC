using API_TCC.Controllers;
using API_TCC.Controllers.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_TCC.Util
{
    internal class Instances
    {
        private static Instances fInstances;
        public static Instances Current => fInstances ??= new Instances();
        internal Controller_integracao_base Integracao { get; private set; }

        private Instances()
        {
            Integracao = new Controller_integracao_ef();
        }
    }
}