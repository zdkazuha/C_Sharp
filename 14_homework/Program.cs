using System;

internal class Program
{
    static void Moderator(string file1, string file2)
    {
 
        List<string> words1 = new List<string>();
        using (BinaryReader br1 = new BinaryReader(new FileStream(file1, FileMode.Open)))
        {
            while (br1.BaseStream.Position < br1.BaseStream.Length)
            {
                words1.Add(br1.ReadString());
            }
        }

 
        List<string> words2 = new List<string>();
        using (BinaryReader br2 = new BinaryReader(new FileStream(file2, FileMode.Open)))
        {
            while (br2.BaseStream.Position < br2.BaseStream.Length)
            {
                words2.Add(br2.ReadString());
            }
        }

 
        for (int i = 0; i < words1.Count; i++)
        {
            for (int j = 0; j < words2.Count; j++)
            {
                if (words1[i] == words2[j])
                {
                    words1[i] = new string('*', words1[i].Length);
                }
            }
        }

 
        using (BinaryWriter bw = new BinaryWriter(new FileStream(file1, FileMode.Create)))
        {
            foreach (string word in words1)
            {
                bw.Write(word);
            }
        }
    }

    private static void Main(string[] args)
    {
        string mfile = "../../../modernFile.txt";
        string fname = "../../../File.txt";
        string[] st = { "test", "best", "rest", "car" };
        string[] st2 = { "man", "telephone" };

        using (BinaryWriter bw = new BinaryWriter(new FileStream(mfile, FileMode.Create)))
        {
            bw.Write("car");
            bw.Write("telephone");
        }

        using (BinaryReader br = new BinaryReader(new FileStream(mfile, FileMode.Open)))
        {
            Console.WriteLine(br.ReadString());
            Console.WriteLine(br.ReadString());
        }

        Console.WriteLine();

        using (BinaryWriter bw = new BinaryWriter(new FileStream(fname, FileMode.Create)))
        {
            foreach (string s in st)
                bw.Write(s);
            foreach (string s in st2)
                bw.Write(s);
        }

        using (BinaryReader br = new BinaryReader(new FileStream(fname, FileMode.Open)))
        {
            for (int i = 0; i < (st.Length + st2.Length); i++)
            {
                Console.WriteLine(br.ReadString());
            }
        }

        Moderator(fname, mfile);

        Console.WriteLine("\nПісля модерування:");

        using (BinaryReader br = new BinaryReader(new FileStream(fname, FileMode.Open)))
        {
            for (int i = 0; i < (st.Length + st2.Length); i++)
            {
                Console.WriteLine(br.ReadString());
            }
        }
    }
}