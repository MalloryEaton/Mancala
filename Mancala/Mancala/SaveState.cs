using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mancala
{
    class SaveState
    {
        public List<Cup> cups = new List<Cup>();
        public bool isPlayerOneTurn = true;
        public string boardSaveConfig = "";

        public SaveState(List<Cup> cupsToSave, bool isPlayerOneTurnToSave)
        {
            cups = cupsToSave;
            isPlayerOneTurn = isPlayerOneTurnToSave;
            boardSaveConfig += isPlayerOneTurnToSave ? "T" : "F";
            for (int i = 0; i < 14; i++)
            {
                boardSaveConfig += "." + cups[i].marbleCount;
            }
            boardSaveConfig += ".";
        }
    }
    
}
