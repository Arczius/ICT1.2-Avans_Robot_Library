using System.Device.Gpio;

namespace Avans.StatisticalRobot;

public class Led
{
    private readonly int _pin;
    private bool _status;

    /// <summary>
    /// This is a digital device
    /// 3.3V/5V
    /// </summary>
    /// <param name="pin">Pin number on grove board</param>
    public Led(int pin)
    {
        Robot.SetDigitalPinMode(pin, PinMode.Output);
        _pin = pin;
        _status = false;
    }

    public void SetOn()
    {
        Robot.WriteDigitalPin(_pin, PinValue.High);
        _status = true;
    }
    public void SetOff()
    {
        Robot.WriteDigitalPin(_pin, PinValue.Low);
        _status = false;
    }

    public string GetStatus()
    {
        return _status ? "on" : "off";
    }
}