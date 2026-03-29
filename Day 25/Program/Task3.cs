using System;
using System.Collections.Generic;

class Message
{
    public string Text { get; set; }
    public string SenderName { get; set; }
}

class ChatApp
{
    public void SendMessage(Message msg)
    {
        if (msg == null)
            Console.WriteLine("The message does not exist yet");
        else if (msg.Text == null)
            Console.WriteLine("The message text does not exist yet");
        else if (msg.SenderName == null)
            Console.WriteLine("The message sender name does not exist yet");
        else
            Console.WriteLine($"{msg.SenderName} sent: {msg.Text}");
    }
}


class Task3
{
    public static void TaskThree()
    {
        Console.WriteLine("--- Task 3 ---");

        Message msg1 = new Message();
        msg1.Text = "Hello!";
        msg1.SenderName = "Anna";

        ChatApp app1 = new ChatApp();
        app1.SendMessage(msg1);

        Console.WriteLine();
    }
}