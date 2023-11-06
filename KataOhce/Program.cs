// See https://aka.ms/new-console-template for more information

using KataOhce;

var ohce = new Ohce(new MyConsole(), new MyClock());
string name = args[0]; 
ohce.Greet(name);
while(!ohce.IsFinish)
{
    ohce.Echo();
}