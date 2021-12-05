using System;  
class JTP  
{  
static long bits(int kilobytes)  
{  
    long Bits;  
    Bits = kilobytes * 8192;  
    return Bits;  
}  
static long bytes(int kilobytes)  
{  
    long Bytes;  
    Bytes = kilobytes * 1024;  
    return Bytes;  
}  
static public void Main ()  
{  
    int kilobytes;  
    Console.WriteLine("Enter the value of kilobytes: ");  
    kilobytes = Convert.ToInt32(Console.ReadLine());  
    Console.WriteLine ("There are " + bytes(kilobytes) + " Bytes in "+ kilobytes + " kilobytes");  
    Console.WriteLine ("There are " + bits(kilobytes) + " Bits in "+ kilobytes + " kilobytes");  
}  
} 