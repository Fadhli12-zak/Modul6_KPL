
using System.Diagnostics.Contracts;

class SayaTubeUser {
    private int id;
    private List<SayaTubeVideo> UploadedVideos;
    public string Username;
    public SayaTubeUser( string username)
    {
        Random random = new Random();
        this.id = random.Next();
        this.Username = username;
        this.UploadedVideos = new List<SayaTubeVideo>();
    }
    public int GetTotalVideoCount()
    {
        return this.UploadedVideos.Count;
    }
    public void AddVideo(string title)
    {
        SayaTubeVideo video = new SayaTubeVideo( title);
        Contract.Requires(title.Length <= 200, "Jumlah karakter harus kurang dari 200");
        Contract.Requires(title != null);

        this.UploadedVideos.Add(video);
    }
    public void PrintAllVideoPlayCounts()
    {
        Console.WriteLine($"User: {Username}");
        for (int i = 0; i < this.UploadedVideos.Count; i++)
        {
          Console.WriteLine($"Video {i+1}: {UploadedVideos[i].title}");
          Console.WriteLine($"playCount {i + 1}: {UploadedVideos[i]}");
        }
    }
}

class SayaTubeVideo
{
    private int id;
    public String title;
    public int playCount;
    public SayaTubeVideo( string title)
    {
        Random random = new Random();
        this.id = random.Next();
        this.title = title;
        this.playCount = 0;
    }
    public void increasePlayCount()
    {
        Contract.Requires(this.playCount <= 25000000, "Penambahan playcount tidak boleh lebih dari 25.000.000!");
        Contract.Requires(this.playCount >= 0, "Play tidak boleh negatif");
        try
        {
            if (this.playCount == int.MaxValue)
            {
                throw new Exception("PlayCount melebihi batas integer");
            }
            checked
            {
                this.playCount++;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);

        }
    }
    public void PrintVideoDetails()
    {
        Console.WriteLine("Video ID: " + this.id);
        Console.WriteLine("Video Title: " + this.title);
        Console.WriteLine("Play Count: " + this.playCount);
    }
}

class main {
    public static void Main(String[] args)
    {
        SayaTubeUser user = new SayaTubeUser( "fadhli");
        Contract.Requires(user.Username.Length < 100, "Ussername tidak boleh lebih dari 100 karakter!");
        Contract.Requires(user.Username != null, "Ussername tidak boleh kosong!");

        user.AddVideo("review film interstellar oleh Fadhli Muhammad Dzaki");
        user.AddVideo("review film Narcos oleh Fadhli Muhammad Dzaki");
        user.AddVideo("review film Better Call Saul oleh Fadhli Muhammad Dzaki");
        user.AddVideo("review film Breaking bad oleh Fadhli Muhammad Dzaki");
        user.AddVideo("review film Moana oleh Fadhli Muhammad Dzaki");
        user.AddVideo("review film la la land oleh Fadhli Muhammad Dzaki");
        user.AddVideo("review film Black Panther oleh Fadhli Muhammad Dzaki");
        user.AddVideo("review film Avengers oleh Fadhli Muhammad Dzaki");
        user.AddVideo("review film Moon Knight oleh Fadhli Muhammad Dzaki");
        user.AddVideo("review film Spirit away oleh Fadhli Muhammad Dzaki");
        user.PrintAllVideoPlayCounts();

        Console.WriteLine();
        Console.WriteLine("=====================================");
        SayaTubeVideo video1 = new SayaTubeVideo("review film interstellar oleh Fadhli Muhammad Dzaki");
        Contract.Requires(video1 != null, "Video tidak boleh kosong");
        Contract.Requires(video1.playCount < int.MaxValue, "PlayCount harus kurang dari bilangan maximum integer");
        video1.increasePlayCount();
        video1.PrintVideoDetails();
    }

}