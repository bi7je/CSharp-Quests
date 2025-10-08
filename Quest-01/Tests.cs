namespace Quest_01;

public class Tests
{
    public static void TestDoors()
    {
        //////////////////////////////////////////////////////
        /// Prepare for tests
        /// Create doors
        List<Door> doors = new List<Door>();
        doors.Add(new Door()); // default material and state. Wood and closed.
        doors.Add(new  Door(Materials.OBSIDION, DoorStates.LOCKED));
        doors.Add(new Door(Materials.IRON, DoorStates.OPEN));
        
        /// Set Test counter variable
        int testCounter = 0;
        
        /// Create test variables
        string material = String.Empty;
        string state = String.Empty;

        //////////////////////////////////////////////////////
        
        //////////////////////////////////////////////////////
        ///  Test Door.Inspect method
        UserInterface.DisplayMessage($"Testing Door.Inspect method...\n{UserInterface.DisplayLine()}");
        
        material = "You look closely at the";
        state = "door. It seems the door is";

        string[] inspectExpected =
        {
            $"{material} oak {state} closed.",
            $"{material} obsidian {state} locked.",
            $"{material} iron {state} open."
        };
        
        foreach (Door door in doors)
        {
            string actual = door.Inspect();
            if (inspectExpected[testCounter] == actual)
            {
                UserInterface.DisplayMessage($"Test {testCounter +1} passed");
            }
            else
            {
                FailedTestMessage(testCounter +1, inspectExpected[testCounter], actual);
            }
            
            testCounter++;
        }
        UserInterface.DisplayMessage(UserInterface.DisplayLine() + "\n");
        //////////////////////////////////////////////////////
        /// End test
        
        //////////////////////////////////////////////////////
        /// Test Door.Open method
        UserInterface.DisplayMessage($"Testing Door.Open() method...\n{UserInterface.DisplayLine()}");
        
        testCounter = 0;
        string[] openExpected =
        {
            "The oak door creaks open, scattering dus like ancient whispers.",
            "You push and pull with all the might you have but the door wont budge.\nThe door is locked.",
            "You see light coming through a crack at the edge of the door. It has already been opened."
            
        };

        DoorStates[] openStatesExpected =
        {
            DoorStates.OPEN,
            DoorStates.LOCKED,
            DoorStates.OPEN,
        };

        foreach (Door door in doors)
        {
            string actual = door.Open();
            if (openExpected[testCounter] == actual)
            {
                UserInterface.DisplayMessage($"Test {testCounter +1} passed");
            }
            else
            {
                FailedTestMessage(testCounter +1, openExpected[testCounter], actual);
            }
            testCounter++;
        }
        UserInterface.DisplayMessage(UserInterface.DisplayLine() + "\n");
        //////////////////////////////////////////////////////
        /// End test

        //////////////////////////////////////////////////////
        /// Test Door.Close method
        UserInterface.DisplayMessage($"Testing Door.Close() method...\n{UserInterface.DisplayLine()}");
        
        // Close the opened door from the last test.
        doors[0].Close();
        testCounter = 0;

        string[] closeExpected =
        {
            "You push with all your might but the door won't close any further.",
            "The door is already closed. No need to waste precious energy.",
            "The iron door closes with a loud screach that resembles the roar of a mechanical dragon.\n" +
            "The door is closed."
        };

        foreach (Door door in doors)
        {
            string actual = door.Close();
            if (closeExpected[testCounter] == actual)
            {
                UserInterface.DisplayMessage($"Test {testCounter +1} passed");
            }
            else
            {
                FailedTestMessage(testCounter +1, closeExpected[testCounter], actual);
            }
            testCounter++;
        }
        UserInterface.DisplayMessage(UserInterface.DisplayLine() + "\n");
        //////////////////////////////////////////////////////
        /// End test
        
        //////////////////////////////////////////////////////
        /// Test Door.Unlock method
        UserInterface.DisplayMessage($"Testing Door.Unlock() method...\n{UserInterface.DisplayLine()}");
        testCounter = 0;

        string[] unlockWithExpected =
        {
            "You bring the rune close to the door but nothing happens.",
            "The socket in the door lights up as you bring the rune close to the door.\n" +
            "You hear a loud noise of metal parts shifting and the door slow opens.",
            "You bring the rune close to the door but nothing happens."
        };

        string unlockWithoutExpected = "You bring the rune close to the door but nothing happens.";
        
        UserInterface.DisplayMessage($"\nTesting Door.Unlock() without rune...\n{UserInterface.DisplayLine("-")}");
        foreach (Door door in doors)
        {
            string actual = door.Unlock(false);
            if (unlockWithoutExpected == actual)
            {
                UserInterface.DisplayMessage($"Test {testCounter +1} passed");
            }
            else
            {
                FailedTestMessage(testCounter +1, unlockWithoutExpected, actual);
            }
            testCounter++;
        }

        testCounter = 0;
        
        UserInterface.DisplayMessage($"\nTesting Door.Unlock() with rune...\n{UserInterface.DisplayLine("-")}");
        foreach (Door door in doors)
        {
            string  actual = door.Unlock(true);
            if (unlockWithExpected[testCounter] == actual)
            {
                UserInterface.DisplayMessage($"Test {testCounter +1} passed");
            }
            else
            {
                FailedTestMessage(testCounter +1, unlockWithExpected[testCounter], actual);
            }
            testCounter++;
        }
    }

    public static void FailedTestMessage(int testCounter, string expected, string actual)
    {
        {
            UserInterface.DisplayBoxedMessage(
                $"Test {testCounter} failed.\n" +
                $"Expected: {expected}\n" +
                $"Actual:   {actual}"
            );
        }
    }
}