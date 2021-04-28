using System;
using System.Collections.Generic;
using System.Text;

namespace swe_3313_gui
{
    class ProgramControl ///singleton data class used to instantiate objects
    {
        private Table TableCurrentlySelected = null; 
        private string ScreenCurrentlyOn;
        private Restaurant Restaurant;

        private static readonly ProgramControl instance = new ProgramControl();

        private ProgramControl() { }  

        public static ProgramControl GetInstance()
        {
            return instance;
        }


    }
}
