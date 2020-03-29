using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGame_AzuaraFonseca {
    class Input {
        // Load keys available
        private static Hashtable keyTable = new Hashtable();

        // Check button pressed
        public static bool KeyPressed(Keys key) {
            if(keyTable[key] == null) {
                return false;
            }

            return (bool)keyTable[key];
        }

        // Verify button pressed
        public static void ChangeState(Keys key, bool state) {
            keyTable[key] = state;
        }
    }
}
