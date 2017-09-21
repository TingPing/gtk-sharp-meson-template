using Gtk;

namespace Example
{
  public class App
  {
    static void Main(string[] args)
    {
      Application.Init();
      var window = new Gtk.Window("Example");
      window.Show();
      Application.Run();
    }
  }
}