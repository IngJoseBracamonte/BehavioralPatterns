using BehavioralPatterns.Command.LightOn.Commands;
using BehavioralPatterns.Command.LightOn.Models;

var light = new Light();
var lightOnCommand = new LightOnCommand(light);
var lightOffCommand = new LightOffCommand(light); 
var remoteControl = new RemoteControl(); 
remoteControl.SetCommand("on", lightOnCommand);
remoteControl.SetCommand("off", lightOffCommand);
// Encender la luz
remoteControl.PressButton("on");
// Apagar la luz
remoteControl.PressButton("off");
// Deshacer la última acción (encender la luz nuevamente)
remoteControl.PressUndoButton("off");

//Explicación:
//Modificación de RemoteControl: Ahora usa un diccionario(Dictionary<string, ICommand>) para almacenar comandos por identificador.

//Métodos SetCommand, PressButton y PressUndoButton: Permiten gestionar y ejecutar comandos por su identificador.

//Uso en Program: Los comandos se registran con un identificador, y el control remoto los ejecuta usando esos identificadores.