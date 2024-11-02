using BehavioralPatterns.Command.LightOn.Interfaces;

namespace BehavioralPatterns.Command.LightOn.Models
{
    public class RemoteControl
    {
        private readonly Dictionary<string, ICommand> _commands;

        public RemoteControl()
        {
            _commands = new Dictionary<string, ICommand>();
        }
        public void SetCommand(string id, ICommand command) 
        { 
            _commands[id] = command; 
        }

        public void PressButton(string id)
        {
            if (_commands.ContainsKey(id)) 
            {
                _commands[id].Execute(); 
            }
            else
            {
                Console.WriteLine($"No command found for id: {id}");
            }
        }

        public void PressUndoButton(string id)
        { 
            if (_commands.ContainsKey(id)) 
            {
                _commands[id].Undo();
            }
            else 
            {
                Console.WriteLine($"No command found for id: {id}"); 
            }
        }
    }
}
