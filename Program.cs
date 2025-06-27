using System;

namespace bridge
{
  internal class Program
  {
    static void Main(string[] args)
    {
      IDevice windows = new WindowsDevice();
      RemoteControl remoteWindows = new RemoteControl(windows);
      remoteWindows.TurnOn();
      remoteWindows.TurnOff();

      IDevice tv = new TVDevice();
      RemoteControl remoteTV = new RemoteControl(tv);
      remoteTV.TurnOn();
      remoteTV.TurnOff();
    }
  }
  public class RemoteControl
  {
    protected IDevice device;

    public RemoteControl(IDevice device)
    {
      this.device = device;
    }

    public void TurnOn()
    {
      device.PowerOn();
    }

    public void TurnOff()
    {
      device.PowerOff();
    }
  }

  public interface IDevice
  {
    void PowerOn();
    void PowerOff();
  }

  public class WindowsDevice : IDevice
  {
    public void PowerOn()
    {
      Console.WriteLine("Windows устройство включено");
    }

    public void PowerOff()
    {
      Console.WriteLine("Windows устройство выключено");
    }
  }

  public class TVDevice : IDevice
  {
    public void PowerOn()
    {
      Console.WriteLine("Телевизор включён");
    }

    public void PowerOff()
    {
      Console.WriteLine("Телевизор выключен");
    }
  }
}
