using System;

namespace Lab2
{
    // Declare a delegate for the event
    public delegate void AlarmEventHandler(object sender, EventArgs e);

    class AlarmClock
    {
        // Declare an event using the delegate
        public event AlarmEventHandler Alarm;

        private int _alarmHour;
        private int _alarmMinute;

        public void SetAlarm(int hour, int minute)
        {
            _alarmHour = hour;
            _alarmMinute = minute;
            Console.WriteLine($"Alarm set for {hour:D2}:{minute:D2}");
        }

        public void CheckTime(int hour, int minute)
        {
            Console.WriteLine($"Current time: {hour:D2}:{minute:D2}");
            if (hour == _alarmHour && minute == _alarmMinute)
            {
                Console.WriteLine("** ALARM TIME! **");
                // Raise the event
                Alarm?.Invoke(this, EventArgs.Empty);
            }
        }
    }

    class AlarmHandler
    {
        public void OnAlarm(object sender, EventArgs e)
        {
            Console.WriteLine("  -> AlarmHandler: Wake up! It's time!");
        }
    }

    class SnoozeHandler
    {
        public void OnAlarm(object sender, EventArgs e)
        {
            Console.WriteLine("  -> SnoozeHandler: Alarm snoozed for 5 minutes.");
        }
    }

    internal class EventDemo
    {
        /*
        static void Main(string[] args)
        {
            

            AlarmClock clock = new AlarmClock();
            AlarmHandler alarmHandler = new AlarmHandler();
            SnoozeHandler snoozeHandler = new SnoozeHandler();

            // Subscribe to the event
            clock.Alarm += alarmHandler.OnAlarm;
            clock.Alarm += snoozeHandler.OnAlarm;

            // Set alarm for a specific time
            clock.SetAlarm(7, 30);

            Console.WriteLine("\nSimulating time passing...\n");

            // Simulate different times
            clock.CheckTime(7, 28);
            clock.CheckTime(7, 29);
            clock.CheckTime(7, 30); // This triggers the alarm event
            clock.CheckTime(7, 31);
        }
        */
    }
}
