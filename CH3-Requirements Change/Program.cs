﻿namespace CH3_Requirements_Change
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Requirements list:
            // 1. The dog door opening must be at least 12" tall
            // 2. A button on the remote control opens the dog door
            //      if the door is closed, and closes the dog door
            //      if the door is open.
            // 3. Once the dog door has opened, it should close
            //      automatically if the door isn't already closed.

            // Use Case:
            // Describes what a system does to accomplish a particular goal.
            // Three parts: 
            //  1. Clear value to achieving the goal
            //  2. Definite starting & stopping points
            //  3. External initiator

            // Use Case:
            // 1. Fido barks to be let out.
            // 2. Todd or Gina hears Fido barking.
            // 3. Todd or Gina presses the button on the remote control.
            // 4. The dog door opens.
            // 5. Fido goes outside.
            // 6. Fido does his business
            //      6.1. The door shuts automatically
            //      6.2. Fido barks to be let back inside.
            //      6.3. Todd or Gina hears Fido barking (again).
            //      6.4. Todd or Gina presses the button on the remote control.
            //      6.5. The door opens (again).
            // 7. Fido goes back inside.
            // 8. The door shuts automatically.

            DogDoorSimulator.DogDoorTestPath();
        }
    }
}
