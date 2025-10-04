using System.Text;

namespace Quest_01;

public class Door
{
    public Materials Material { get; private init; }
    public DoorStates State { get; private set; }
    public string RuneCode { get; private init; }

    public Door(Materials _material, DoorStates _state)
    {
        Material = _material;
        State = _state;
    }

    public Door() : this(Materials.WOOD, DoorStates.CLOSED)
    {
    }
    
    public string Inspect()
    {
        return $"You look closely at the {GetMaterial().ToLower()} door. " +
               $"It seems the door is {GetState().ToLower()}.";
    }

    public string Open()
    {
        string message = String.Empty;

        switch (State)
        {
            case  DoorStates.CLOSED:
                message = $"The {GetMaterial().ToLower()} door creaks open, scattering dus like ancient whispers.";
                State = DoorStates.OPEN;
                break;
            case DoorStates.OPEN:
                message = "You see light coming through a crack at the edge of the door. It has already been opened.";
                break;
            case DoorStates.LOCKED:
                message = "You push and pull with all the might you have but the door wont budge.\n" +
                          "The door is locked.";
                break;
        }
        
        return message;
    }

    public string Close()
    {
        string message = String.Empty;
        
        switch (State)
        {
            case  DoorStates.CLOSED:
                message = "You push with all your might but the door won't close any further.";
                break;
            case DoorStates.OPEN:
                message = $"The {GetMaterial().ToLower()} door closes with a loud screach that resembles the roar of a mechanical dragon.\n" +
                          "The door is closed.";
                State = DoorStates.CLOSED;
                break;
            case DoorStates.LOCKED:
                message = "The door is already closed. No need to waste precious energy.";
                break;
        }
        
        return message;
    }

    public string Unlock(bool rune)
    {
        string message = String.Empty;
        if (State == DoorStates.LOCKED && rune == true)
        {
            State = DoorStates.OPEN;
            message = "The socket in the door lights up as you bring the rune close to the door.\n" +
                      "You hear a loud noise of metal parts shifting and the door slow opens.";
        }
        else
        {
            message = "You bring the rune close to the door but nothing happens.";
        }

        return message;
    }

    private string GetState()
    {
        return State switch
        {
            DoorStates.CLOSED => "Closed",
            DoorStates.OPEN   => "Open",
            DoorStates.LOCKED => "Locked"
        };
    }

    private string GetMaterial()
    {
        return Material switch
        {
            Materials.WOOD      => "Oak",
            Materials.IRON      => "Iron",
            Materials.OBSIDION  => "Obsidian"
        };
    }
}

public enum Materials
{
    WOOD,
    IRON,
    OBSIDION
};

public enum DoorStates
{
    OPEN,
    CLOSED,
    LOCKED
};