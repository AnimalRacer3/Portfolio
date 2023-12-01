using System;

public class Package
{
    public int PackageID {get; private set;}
    public string Sender {get; private set;}
    public string Receiver {get; private set;}
    public string Status {get; private set;}
    public float Weight {get; private set;}
    public DateTime DeliveryDate {get; private set;}
}