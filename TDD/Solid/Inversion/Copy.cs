using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface Reader
{
    char Read();
}

public class Keyboard : Reader
{
    public char Read()
    {
        throw new NotImplementedException();
    }
}

public interface Writer
{
    void Write(char c);
}

public class Printer : Writer
{
    public void Write(char c)
    {
        throw new NotImplementedException();
    }
}

public class Program
{
    private char EOF = (char) 26; 
    public void Copy(Reader reader, Writer writer)
    {
        char c = reader.Read();
        while (c != EOF)
        {
            writer.Write(c);
        }
    }
}


