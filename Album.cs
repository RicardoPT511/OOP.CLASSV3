using System;

class Album
{
    private string name;
    private string[] songNames = { "uno", "dos", "tres" }; 

    public Album(string nameN)
    {
        name = nameN;
    }


    public void PlaySong(string song)
    {
        bool found = false;

        for (int i = 0; i < songNames.Length; i++)
        {
            if (songNames[i] == song)
            {
                Console.WriteLine("Reproduciendo: " + songNames[i]);
                found = true;
                break;
            }
        }

        if (!found)
        {
            throw new ArgumentOutOfRangeException("La canción no existe en el álbum");
        }
    }

    
    public void PlaySong(int index)
    {
        if (index >= 0 && index < songNames.Length)
        {
            Console.WriteLine("Reproduciendo: " + songNames[index]);
        }
        else
        {
            throw new IndexOutOfRangeException("Índice fuera del rango");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Album album = new Album("Mi Album");

        try
        {
            album.PlaySong("uno"); 
            album.PlaySong(1);     

            album.PlaySong("cuatro"); 
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}